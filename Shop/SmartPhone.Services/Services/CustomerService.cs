using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Models.ViewModel;

namespace SmartPhone.Services
{
    public class CustomerService : GenericService<Customer>, ICustomerService
    {

        public CustomerViewModel GetCustomer(long Id)
        {
            CustomerViewModel data = new CustomerViewModel();
            data.customer = db.Customers.Where(n => n.Id == Id).FirstOrDefault();
            data.district = db.Districts.Find(data.customer.DistrictId);
            data.provinces = db.Provinces.Find(data.district.ProvinceId);
            return data;
        }
        public Customer GetCustomerById(long Id)
        {
            return db.Customers.Where(n => n.Id == Id).FirstOrDefault();
        }

        public ResponseDataAdmin<CustomerView> GetListCustomer(GetViewData getViewData)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string Search = getViewData.Search;

            var data = db.Customers.Where(n => n.IsDelete == false).OrderByDescending(n => n.Status).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.Customers.Where(n => n.IsDelete == false).Count();
            if (!String.IsNullOrEmpty(Search))
            {
                if (Search == null)
                    Search = "";
                Search = Search.Trim();
                data = db.Customers.Where(n => (n.Name.ToLower().Contains(Search.ToLower()) || n.Phone.Contains(Search) || n.Email.ToLower().Contains(Search.ToLower())) && n.IsDelete == false).OrderByDescending(n => n.Status).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.Customers.Where(n => (n.Name.ToLower().Contains(Search.ToLower()) || n.Phone.Contains(Search) || n.Email.ToLower().Contains(Search.ToLower())) && n.IsDelete == false).Count();
            }

            List<CustomerView> datacv = new List<CustomerView>();
            foreach (var item in data)
            {
                CustomerView cmv = new CustomerView();
                {
                    cmv.customer = item;
                    List<DistrictView> datadv = new List<DistrictView>();
                    foreach (var item1 in db.Districts.ToList())
                    {
                        DistrictView dv = new DistrictView();
                        {
                            dv.district = item1;
                            dv.provinces = db.Provinces.Find(item1.ProvinceId);
                        }
                        datadv.Add(dv);

                    }
                    datacv.Add(cmv);
                }

            }
            ResponseDataAdmin<CustomerView> dataCustomer = new ResponseDataAdmin<CustomerView>();
            dataCustomer.data = datacv;
            dataCustomer.pageNumber = pageNumber;
            dataCustomer.pageSize = pageSize;
            dataCustomer.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            return dataCustomer;

        }
        public bool AddOrUpdate(Customer customer)
        {
            if (customer != null)
            {
                if (customer.Id == 0)
                {
                    customer.IsDelete = false;
                    customer.CreatedDate = DateTime.Now;
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
                else
                {
                    var obj = db.Customers.Find(customer.Id);
                    obj.Name = customer.Name;
                    obj.Phone = customer.Phone;
                    obj.Email = customer.Email;
                    obj.Address = customer.Address;
                    obj.Password = customer.Password;
                    obj.DistrictId = customer.DistrictId;
                    obj.Status = customer.Status;
                    obj.UpdatedBy = customer.UpdatedBy;
                    obj.UpdatedDate = DateTime.Now;
                    db.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCustomerById(long Id)
        {
            var data = db.Customers.Where(n => n.Id == Id).FirstOrDefault();
            data.IsDelete = true;
            db.SaveChanges();
            return true;
        }

        public List<District> GetListDistrict(string Id)
        {
            return db.Districts.Where(n => n.IsDelete == false && n.ProvinceId == Id).ToList();
        }
        public List<Province> GetListProvince()
        {
            return db.Provinces.Where(n => n.IsDelete == false).ToList();
        }
        public District GetDistrict(string Id)
        {
            return db.Districts.Where(n => n.IsDelete == false && n.Id == Id).FirstOrDefault();
        }
        public DistrictView GetProvince(string districtId)
        {
            DistrictView data = new DistrictView();
            data.district = db.Districts.Where(n => n.Id == districtId).FirstOrDefault();
            data.provinces = db.Provinces.Find(data.district.ProvinceId);
            return data;

        }
        public Customer Login(string username, string password)
        {
            return db.Customers.Where(n => (n.Email == username || n.Phone == username) && n.Password == password && n.Status == 1 && n.IsDelete == false).FirstOrDefault();
        }
        public bool Register(Customer customer)
        {
            if (customer != null)
            {
                if (customer.Id == 0)
                {
                    bool check = db.Customers.Where(n => n.Email == customer.Email).Count() > 0;
                    if (check)
                    {
                        return false;
                    }
                    customer.IsDelete = false;
                    customer.Status = 1;
                    customer.CreatedDate = DateTime.Now;
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

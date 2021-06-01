using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Models.ViewModel;

namespace SmartPhone.Services
{
    public interface ICustomerService
    {

        public CustomerViewModel GetCustomer(long Id );
        public Customer GetCustomerById(long Id);
        public ResponseDataAdmin<CustomerView> GetListCustomer(GetViewData getViewData);
        public bool AddOrUpdate(Customer customer);
        public bool DeleteCustomerById(long Id);
        public List<District> GetListDistrict(string Id);
        public District GetDistrict(string Id);
        public List<Province> GetListProvince();
        public DistrictView GetProvince(string districtId);

        //login
        public Customer Login(string username, string password);
        public bool Register(Customer customer);

    }
}

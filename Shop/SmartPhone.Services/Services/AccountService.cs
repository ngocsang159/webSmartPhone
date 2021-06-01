using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Services
{
    public class AccountService : GenericService<Account>, IAccountService
    {
        /// <summary>
        /// truy vấn tài khoản admin
        /// </summary>
        /// <param name="username">string</param>
        /// <param name="password">string</param>
        /// <returns></returns>
        public Account Login(string username, string password)
        {
            return db.Accounts.Where(n => (n.Email == username || n.Phone == username) && n.Password == password && n.Status == 1 && n.IsDelete == false).FirstOrDefault();
        }

        
        /// <summary>
        /// Lấy danh sách tải khoản với ResponseData<T>
        /// </summary>
        /// <param name="getViewData">pageSize,pageNumber,Search</param>
        /// <returns></returns>
        public ResponseDataAdmin<Account> GetListAccount(GetViewData getViewData)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string search = getViewData.Search;


            var data = db.Accounts.Where(n => n.IsDelete == false).OrderByDescending(n => n.IsAdmin).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.Accounts.Where(n => n.IsDelete == false).Count();
            if (!string.IsNullOrEmpty(search))
            {
                if (search == null)
                    search = "";
                search = search.Trim();
                data = db.Accounts.Where(n => (n.Name.ToLower().Contains(search.ToLower()) || n.Phone.Contains(search))).OrderByDescending(n => n.IsAdmin).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.Accounts.Where(n => (n.Name.ToLower().Contains(search.ToLower()) || n.Phone.Contains(search)) && n.IsDelete == false).Count();
            }

            ResponseDataAdmin<Account> dataAdmin = new ResponseDataAdmin<Account>();
            dataAdmin.data = data;
            dataAdmin.pageSize = pageSize;
            dataAdmin.pageNumber = pageNumber;
            dataAdmin.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            dataAdmin.Total = total;
            return dataAdmin;
        }
        /// <summary>
        /// Lấy thông tin theo ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Account GetAccountByID(long Id)
        {
            return db.Accounts.Find(Id);
        }
        /// <summary>
        /// thêm mới Or cập nhật tài khoản
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public bool AddOrUpdateAdmin(Account admin)
        {
            if (admin != null)
            {
                if (admin.Id == 0)
                {

                    admin.CreatedDate = DateTime.Now;
                    admin.CreatedBy = "";
                    admin.IsDelete = false;
                    db.Accounts.Add(admin);
                    db.SaveChanges();


                }
                else
                {
                    var obj = db.Accounts.Find(admin.Id);
                    obj.Name = admin.Name;
                    obj.Image = admin.Image;
                    obj.Phone = admin.Phone;
                    obj.Birthday = admin.Birthday;
                    obj.Email = admin.Email;
                    obj.Address = admin.Address;
                    obj.Password = admin.Password;
                    obj.IsAdmin = admin.IsAdmin;
                    obj.Status = admin.Status;
                    obj.UpdatedDate = DateTime.Now;
                    obj.UpdatedBy = admin.UpdatedBy;
                    db.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Xóa
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(long Id)
        {
            var admin = db.Accounts.Find(Id);
            admin.IsDelete = true;
            db.SaveChanges();
            return true;
        }
    }

}

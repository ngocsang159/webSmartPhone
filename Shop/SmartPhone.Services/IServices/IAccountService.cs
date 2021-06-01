using SmartPhone.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone.Services
{
    public interface IAccountService
    {
        public Account Login(string username, string password);
        public ResponseDataAdmin<Account> GetListAccount(GetViewData getViewData);
        public Account GetAccountByID(long Id);
        public bool AddOrUpdateAdmin(Account admin);
        public bool Delete(long Id);
    }
}

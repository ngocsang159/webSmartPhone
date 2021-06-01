using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Models.ViewModel;

namespace SmartPhone.Services
{
    public interface IPolicyService
    {
        public Policy GetPolicyById(long Id);
        public ResponseDataAdmin<Policy> GetListPolicy(GetViewData getViewData,long ParentId);
        public bool AddOrUpdate(Policy policy, long ParentId);
        public bool DeleteById(long Id);

        //web
        public List<Policy> GetCategoryPolicy(long Id);
        public List<Policy> GetPolicy(long Id);
        public List<Policy> GetCategoryPolicyAll();
        public List<PolicyViewModel> GetListPolicyWeb();


    }
}

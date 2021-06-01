using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartPhone.Commons;
using SmartPhone.Models.EF;
using SmartPhone.Models.ViewModel;

namespace SmartPhone.Services
{
    public class PolicyService : GenericService<Policy>, IPolicyService
    {
        public Policy GetPolicyById(long Id)
        {
            return db.Policies.Find(Id);
        }
        public ResponseDataAdmin<Policy> GetListPolicy(GetViewData getViewData, long ParentId)
        {
            int pageSize = getViewData.pageSize;
            int pageNumber = getViewData.pageNumber;
            string search = getViewData.Search;

            var data = db.Policies.Where(n => n.ParentId == ParentId && n.IsDelete == false).OrderBy(n => n.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var total = db.Policies.Where(n => n.ParentId == ParentId && n.IsDelete == false).Count();
            if (!string.IsNullOrEmpty(search))
            {
                search = "";
                search = search.Trim();
                data = db.Policies.Where(n => n.ParentId == ParentId && n.IsDelete == false && n.Name.ToLower().Contains
                (search.ToLower())).OrderBy(n => n.Position).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
                total = db.Policies.Where(n => n.ParentId == ParentId && n.IsDelete == false && n.Name.ToLower().Contains
                (search.ToLower())).Count();
            }
            ResponseDataAdmin<Policy> dataPolicy = new ResponseDataAdmin<Policy>();
            dataPolicy.data = data;
            dataPolicy.pageSize = pageSize;
            dataPolicy.pageNumber = pageNumber;
            dataPolicy.pageCount = total % pageSize == 0 ? total / pageSize : total / pageSize + 1;
            dataPolicy.Total = total;
            return dataPolicy;

        }


        public bool AddOrUpdate(Policy policy, long ParentId)
        {
            if (policy != null)
            {
                if(policy.Id == 0)
                {
                    policy.Slug = Constant.ConvertString(policy.Name);
                    policy.ParentId = ParentId;
                    policy.IsDelete = false;
                    policy.CreatedDate = DateTime.Now;
                    db.Policies.Add(policy);
                    db.SaveChanges();
                }    
                else
                {
                    var obj = db.Policies.Find(policy.Id);
                    obj.Name = policy.Name;
                    obj.Slug = Constant.ConvertString(policy.Name);
                    obj.Image = policy.Image;
                    obj.Content = policy.Content;
                    obj.Position = policy.Position;
                    obj.UpdatedBy = policy.UpdatedBy;
                    obj.Status = policy.Status;
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

        public bool DeleteById(long Id)
        {
            var data = db.Policies.Where(n => n.Id == Id).FirstOrDefault();
            data.IsDelete = true;
            db.SaveChanges();
            return true;
        }

        /// <summary>
        /// web
        /// </summary>
        /// <returns></returns>
        public List<Policy> GetCategoryPolicy(long Id)
        {
            List<Policy> data = new List<Policy>();
            if (Id > 0)
            {
                data = db.Policies.Where(n => n.ParentId == Id && n.Status == 1 && n.IsDelete == false).ToList();
            }
            if(Id ==0)
            {
                data = db.Policies.Where(n => n.ParentId != 0  && n.Status == 1 && n.IsDelete == false).ToList();
            }
            return data;
            
        }
        public List<Policy> GetCategoryPolicyAll()
        {
            return db.Policies.Where(n => n.ParentId == 0 && n.Status == 1 && n.IsDelete == false).ToList();
        }    

        public List<Policy> GetPolicy(long Id)
        {

            return db.Policies.Where(n => n.ParentId == Id && n.Status == 1 && n.IsDelete == false).ToList();
        }
        public List<PolicyViewModel> GetListPolicyWeb()
        {
            List<PolicyViewModel> data = new List<PolicyViewModel>();
            var PolicyParent = db.Policies.Where(n => n.ParentId == 0 && n.Status == 1 && n.IsDelete == false).OrderBy(n => n.Position).ToList();
            foreach (var item in PolicyParent)
            {
                PolicyViewModel sub = new PolicyViewModel();
                sub.policy = item;
                sub.subPolicy = db.Policies.Where(n => n.ParentId == item.Id && n.Status == 1 && n.IsDelete == false).ToList();
                data.Add(sub);
            }
            return data;
        }
    }
}

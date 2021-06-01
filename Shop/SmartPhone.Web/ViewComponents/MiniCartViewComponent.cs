using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SmartPhone.Commons;
using SmartPhone.Models.ViewModel;
using SmartPhone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone.Web.ViewComponents
{
    public class MiniCartViewComponent : ViewComponent
    { 
        List<CartViewModel> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsonCart = session.GetString(Constant.cartSession);
            if (jsonCart != null)
            {
                return JsonConvert.DeserializeObject<List<CartViewModel>>(jsonCart);
            }
            return new List<CartViewModel>();
        }
        //lưu cart vào session
        void SaveCartSession(List<CartViewModel> cartViews)
        {
            var session = HttpContext.Session;
            string jsonCart = JsonConvert.SerializeObject(cartViews);
            session.SetString(Constant.cartSession, jsonCart);
        }
        public IViewComponentResult Invoke()
        {
            List<CartViewModel> lst = GetCartItems();
            decimal total = 0;
            if (lst != null)
            {
                foreach(var item in lst)
                {
                    if(item.product.PriceSale == 0)
                    {
                        total += (item.product.Price.GetValueOrDefault(0) * item.Quantity);
                    }    
                    else
                    {
                        total += (item.product.PriceSale.GetValueOrDefault(0) * item.Quantity);
                    }    

                }
                ViewBag.count = lst.Count;
            }
            else
            {
                ViewBag.count = 0;
            }

            return View(GetCartItems());

        }
    }
}

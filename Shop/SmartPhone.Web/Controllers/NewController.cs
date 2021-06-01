using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.EF;
using SmartPhone.Services;

namespace SmartPhone.Web.Controllers
{

    public class NewController : Controller
    {
        private readonly INewService newService;
        public NewController(INewService _newService)
        {
            newService = _newService;
        }
        [Route("tin-tuc")]
        [Route("tin-tuc/{slug}/{Id}")]
        [Route("New/Index/{Id}")]
        public IActionResult Index(long? Id)
        {

            if(Id == null || Id == 0)
            {
                Id = 0;
            }

            //ViewBag.categoryName = newService.GetCategoryNew().FirstOrDefault(x => x.Id == (long)Id).Name.ToString();
         
            ViewBag.GetNewSide = newService.GetNewSide();
            ViewBag.IdNew = Id;
            ViewBag.GetCategoryNew = newService.GetCategoryNew();
            ViewBag.GetListNewSide = newService.GetListNewSide();
            var data = newService.GetListNew((long) Id,1,1,9);
      
            return View(data);
        }
        public PartialViewResult GetListNew(long Id, int Order,int pageNumber)
        {
            var data = newService.GetListNew(Id, Order, pageNumber, 9);
            return PartialView("GetListNew", data);
        }
        //chi tiết tin tức
        [Route("chi-tiet-tin-tuc/{slug}/{id}")]
        public  IActionResult newDetail(long Id)
        {
            ViewBag.GetCategoryNew = newService.GetCategoryNew();
            ViewBag.GetListNewSample = newService.GetListNewSample(Id);
            ViewBag.GetListNewSide = newService.GetListNewSide();
            var newDetail = newService.GetNewById(Id);
            ViewBag.NewDetail = newDetail;
            ViewBag.Category = newService.GetNewById((int)newDetail.ParentId).Name;
            var data = newService.GetNewSide();
       
            return View(data);
        }

    }
}

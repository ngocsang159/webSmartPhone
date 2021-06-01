using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO;
using SmartPhone.Models.EF;
using Newtonsoft.Json;

namespace SmartPhone.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private LanHangContext db = new LanHangContext();
        private IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="upload"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult UploadFileImage(IFormFile upload)
        {
            try
            {
                var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), _hostingEnvironment.WebRootPath, "Upload/Image", fileName);
                var stream = new FileStream(path, FileMode.Create);
                upload.CopyToAsync(stream);
                return Json(new { upload = true, url = "/Upload/Image/" + fileName });
            }
            catch (Exception)
            {
                return Json(new { uploaded = false });
            }
        }
        [HttpPost]
        public JsonResult UploadListFileImage()
        {
            try
            {
                var ListImage = Request.Form.Files;
                List<string> data = new List<string>();
                if (ListImage != null)
                {
                    if (ListImage.Count > 0)
                    {
                        foreach (var upload in ListImage)
                        {
                            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
                            var path = Path.Combine(Directory.GetCurrentDirectory(), _hostingEnvironment.WebRootPath, "Upload/Image", fileName);
                            var stream = new FileStream(path, FileMode.Create);
                            upload.CopyToAsync(stream);
                            data.Add(fileName);
                        }
                    }
                    else
                    {
                        return Json(false);
                    }
                }
                else
                {
                    return Json(false);
                }
                return Json(data);
            }
            catch (Exception)
            {
                return Json(false);
            }
        }


        [HttpPost]
        public JsonResult DeleteImageByName([FromBody] string fileName)
        {
            var path = _hostingEnvironment.WebRootPath + "/Upload/Image/" + fileName;
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult FileBrower()
        {
            var dir = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), _hostingEnvironment.WebRootPath, "Upload/Image"));
            ViewBag.data = dir.GetFiles().OrderBy(n => n.FullName);
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ReadFileBrower()
        {
            var dir = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), _hostingEnvironment.WebRootPath, "Upload/Image"));
            ViewBag.data = dir.GetFiles().OrderBy(n => n.FullName);
            return PartialView();
        }
        [HttpPost]
        public JsonResult ChangeAvatar()
        {
            var session = HttpContext.Session;
            try
            {
                var ListImage = Request.Form.Files;
                var url = "";
                foreach (var upload in ListImage)
                {
                    var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), _hostingEnvironment.WebRootPath, "Upload/Image", fileName);
                    var stream = new FileStream(path, FileMode.Create);
                    upload.CopyToAsync(stream);
                    url = "/Upload/Image/" + fileName;
                }
                var user = db.Accounts.Find(JsonConvert.DeserializeObject<Account>(session.GetString("User")).Id);
                if (user != null)
                {
                    user.Image = url;
                    string userkey = JsonConvert.SerializeObject(user);
                    HttpContext.Session.SetString("User", userkey);
                    db.SaveChanges();
                }
                return Json(url);
            }
            catch (Exception)
            {
                return Json(new { uploaded = false });
            }
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartPhone.Models.ViewModel;
using SmartPhone.Models.EF;
using SmartPhone.Services;
using SmartPhone.Commons;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text;

namespace SmartPhone.Web.Controllers
{

    public class CartController : Controller
    {
        protected readonly LanHangContext db = new LanHangContext();
        public IProductDetailService _productDetailService;
        public IOrderService _orderService;
        public ICustomerService _customerService;
        public ISendMailService _sendMailService;


        private const string USER = "USER";
        public CartController(ISendMailService sendMailService)
        {
            _productDetailService = new ProductDetailService();
            _orderService = new OrderService();
            _customerService = new CustomerService();
            _sendMailService = sendMailService;
        }
        [Route("dat-hang")]
        [Route("Cart/Index")]
        public IActionResult Index()
        {
            return View(GetCartItems());
        }
        //Lấy cart từ session 
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

        public class PostObj
        {
            public int productId { get; set; }
            public int colorId { get; set; }
        }
        [HttpPost]
        public JsonResult AddToCart(PostObj postObj)
        {
            var product = _productDetailService.GetProductId(postObj.productId);
            var color = _productDetailService.GetColor(postObj.colorId);
            // tìm color như product
            List<CartViewModel> currentCart = new List<CartViewModel>();
            var cart = GetCartItems();
            int quantity = 1;
            var cartItem = cart.Find(n => n.product.Id == postObj.productId);
            if (cartItem != null)
            {

                cartItem.Quantity++;
            }
            else
            {
                // idcolor 
                //tìm color theo Id
                var cartView = new CartViewModel();
                {
                    cartView.color = color;
                    cartView.product = product;
                    cartView.Quantity = quantity;
                };
                cart.Add(cartView);
            }

            //if (currentCart == null) currentCart = new List<CartViewModel>();


            SaveCartSession(cart);
            return Json(true);

        }
        [Route("/xoa-don-hang/{ProductId}")]
        public IActionResult RemoveCart(long ProductId)
        {
            var cart = GetCartItems();
            var carItem = cart.Find(n => n.product.Id == ProductId);
            if (carItem != null)
            {
                cart.Remove(carItem);
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult UpdateCart(CartViewModel cartView)
        {
            if (cartView != null)
            {
                var cart = GetCartItems();
                //var cartItem = cart.Find(n => n.product.Id == cartView.product.Id);
                foreach (var item in cart)
                {
                    if (item.product.Id == cartView.product.Id)
                    {
                        item.Quantity = cartView.Quantity;
                    }
                }
                SaveCartSession(cart);
            }
            List<CartViewModel> lst = GetCartItems();
            return Json(lst);

        }
        [Route("dat-hang/thanh-toan")]
        public IActionResult Payment()
        {
            List<CartViewModel> lst = GetCartItems();
            ViewBag.province = _customerService.GetListProvince();
            return View(lst);
        }

        [HttpPost]
        public JsonResult GetDistrict(string Id)
        {
            return Json(_customerService.GetListDistrict(Id));
        }



        [HttpPost]
        public JsonResult Order(Order order, List<OrderDetail> orderDetails)
        {
            //var customer = HttpContext.Request.Cookies["USER"];
            //if (customer == null)
            //    return Json(false);
            //var cus = JsonConvert.DeserializeObject<Customer>(customer);

            //order.CustomerId = cus.Id;
            order.CreatedDate = DateTime.Now;
            order.Status = 1;
            order.OrderStatusId = 1;
            order.IsDelete = false;
            order.Code = "LH - " + GenerateNumber();
            var res = _orderService.Order(order, orderDetails);

            //string content = System.IO.File.ReadAllText("~/Content/template/SendEmail.html");
            //content = content.Replace("{{CustomerName}}", order.FullName);
            //content = content.Replace("{{Phone}}", order.Phone);
            //content = content.Replace("{{Email}}", order.Email);
            //content = content.Replace("{{Address}}", order.Address);


            List<Product> products = new List<Product>();
            foreach (var item in orderDetails)
            {
                Product product = db.Products.Find(item.ProductId);
                products.Add(product);
            }
            //foreach (var item in orderDetails)
            //{
            //    MasterDatum Color = new MasterDatum();
            //    var color = db.MasterData.Where(n => n.Id == item.ColorId).FirstOrDefault();
            //}
            var district = db.Districts.Where(n => n.Id == order.DistrictId).FirstOrDefault();
            DistrictView dv = new DistrictView();
            {
                dv.district = district;
                dv.provinces = db.Provinces.Find(district.ProvinceId);
            }
            var total = orderDetails.Sum(n => n.Price * n.Quantity);
            StringBuilder MyStringBuilder2 = new StringBuilder("<h3>Cảm ơn quý khách đã đặt mua sản phẩm tại LanHangMobile</h3>" + "<p><strong>Đơn hàng của bạn đã được tạo và cửa hàng sẽ liên hệ với bạn trong thời gian sớm nhất để xác nhận đơn hàng.</strong></p>" +
                "<p>Thông tin đơn hàng</p>" +
                "<ul>" +
                "<li><b>Đơn hàng: </b>" + order.Code + "</li>" +
                "<li><b>Thời gian đặt hàng: </b>" + order.CreatedDate.Value.ToString("dd/MM/yyyy hh:mm:ss") + "</li>" +
                "<li><b> Họ tên: </b>" + order.FullName + "</li>" +
                "<li><b> Điện thoại: </b> " + order.Phone + " </li>" +
                "<li><b>Email: </b> " + order.Email + "</li>" +
                "<li><b> Địa chỉ: </b>" + order.Address + "," + dv.district.Name + "," + dv.provinces.Name + "</li>" +
                "<li><b>Nội dung: </b>" + order.Note + "</li>" +
                "<li><b>Tổng tiền: </b>" + total.Value.ToString("N0") + " VNĐ</li></ul>");
            foreach (var item in orderDetails)
            {
                foreach (var product in products)
                {
                    if (product.Id == item.ProductId)
                    {

                        MyStringBuilder2.Append("<h4>Chi tiết đơn hàng</h4>" +
                       "<ul>" +
                       "<li><b class='a'>Tên sản phẩm :</b>" + product.Name + "</li>");

                        break;
                    }
                }
                var thanhtien = item.Price * item.Quantity;
               
                MyStringBuilder2.Append("<li><b>Số lượng: </b>" + item.Quantity + "</li>" +
                        "<li><b>Thành Tiền:</b>" + thanhtien.Value.ToString("N0") + " VNĐ </li></ul>");
               
            }

            MyStringBuilder2.Append("<h3>Mọi thắc mắc về sản phẩm - dịch vụ, vui lòng liên hệ với chúng tôi theo số Hotline:0383515382</h3>");
            MailContent content = new MailContent
            {
                To = order.Email,
                Subject = "Thông báo đặt hàng thành công tại LanHangMobile",
                Body = MyStringBuilder2.ToString(),

            };
            _sendMailService.SendMail(content);
            return Json(res);

        }


        public string GenerateNumber()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 5; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return r;
        }

        [Route("dat-hang-thanh-cong")]
        public IActionResult SuccesCart()
        {
            return View();
        }



    }
}

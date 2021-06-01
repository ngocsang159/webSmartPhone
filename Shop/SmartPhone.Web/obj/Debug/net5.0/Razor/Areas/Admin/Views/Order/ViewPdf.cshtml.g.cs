#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e764c30b8b0b916b140264e24c1520b2ec65781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_ViewPdf), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/ViewPdf.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
using SmartPhone.Models.EF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
using SmartPhone.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e764c30b8b0b916b140264e24c1520b2ec65781", @"/Areas/Admin/Views/Order/ViewPdf.cshtml")]
    public class Areas_Admin_Views_Order_ViewPdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string, object>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
  
    Order order = Model["orderInfor"] as Order;
    List<OrderDetail> orderDetails = Model["orderDetails"] as List<OrderDetail>;
    List<Product> products = Model["products"] as List<Product>;
    DistrictView districtView = Model["address"] as DistrictView;
    List<MasterDatum> masterDatum = Model["color"] as List<MasterDatum>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""padding:0 24px 24px; color:#663399"">
    <div style=""height:100px;font-family: sans-serif;"">
        <div style=""        width: 50%;
        text-align: center;
        float: left;"">
            <h1 style=""font-size: 60px;margin-top:0px;"">LH</h1>

            <h1 style=""font-size:18px; font-weight:600"">Trung Tâm Điện Thoại Di Động Lan Hằng</h1>
        </div>
        <div style=""float:right; margin-right:100px;"">
            <div style=""padding-top:0px"">
                <label style=""margin-right: 8px;font-weight:bold"">Địa chỉ:</label> <span>Mê Linh, Đông Hưng,Thái Bình</span>
            </div>
            <div style=""padding-top:8px"">
                <label style=""margin-right: 8px;font-weight:bold"">Số điện thoại:</label> <span>0383515382</span>
            </div>
            <div style=""padding-top:8px"">
                <label style=""margin-right: 8px;font-weight:bold"">Email:</label> <span>LanHangMobile@gmail.com</span>
            </div>
            <div style=""padding-top:");
            WriteLiteral(@"8px"">
                <label style=""margin-right: 8px;font-weight:bold"">Facebook:</label> <span>Trung Tâm ĐTDĐ Lan Hằng</span>
            </div>
        </div>
    </div>
    <div style=""padding-top:30px !important;clear:both;font-family: sans-serif;"">
        <h2 style=""text-align:center;margin:0px"">HÓA ĐƠN BÁN HÀNG</h2>
    </div>
    <div style=""padding-top:30px !important;font-family: sans-serif;"">
        <div>
            <label style=""margin-right: 8px;font-weight:bold"">Họ tên khách hàng:</label><span>");
#nullable restore
#line 41 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                                         Write(order.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div style=\"padding-top:8px\">\r\n            <label style=\"margin-right: 8px;font-weight:bold\">Địa chỉ: </label><span>");
#nullable restore
#line 44 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                                Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 44 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                                                Write(districtView.district.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 44 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                                                                             Write(districtView.provinces.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div style=\"padding-top:8px\">\r\n            <label style=\"margin-right: 8px;font-weight:bold\">Email: </label><span>");
#nullable restore
#line 47 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                              Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div style=\"padding-top:8px\">\r\n            <label style=\"margin-right: 8px;font-weight:bold\">Số điện thoại: </label><span>");
#nullable restore
#line 50 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                                      Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
            WriteLiteral(@"    </div>
    <div style=""font-family: sans-serif;padding-top:10px;"">
        <table style=""width:100%;border-collapse:collapse;color:#663399"">
            <thead>
                <tr>
                    <th style=""border:1px solid;padding:5px 5px;text-align:center"">
                        Tên hàng hóa, dịch vụ
                    </th>
                    <th style=""border:1px solid;padding:5px 5px;text-align:center"">
                        Đơn vị tính
                    </th>
                    <th style=""border:1px solid;padding:5px 5px; text-align:center;"">
                        Màu sắc
                    </th>
                    <th style=""border:1px solid;padding:5px 5px;text-align:center"">
                        Số lượng
                    </th>
                    <th style=""border:1px solid;padding:5px 5px;text-align:center"">
                        Đơn giá
                    </th>
                    <th style=""border:1px solid;padding:5px 5px;text-align:center"">
  ");
            WriteLiteral("                      Thành tiền\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 96 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                 foreach (var item in orderDetails)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 100 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                     foreach (var product in products)
                    {
                        if (product.Id == item.ProductId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"border:1px solid;padding:5px 5px;text-align:center\">");
#nullable restore
#line 104 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 105 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                            break;
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"border:1px solid;padding:5px 5px;text-align:center\">Chiếc</td>\r\n");
#nullable restore
#line 109 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                     foreach (var color in masterDatum)
                    {
                        if (color.Id == item.ColorId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"border:1px solid;padding:5px 5px;text-align:center\">");
#nullable restore
#line 113 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                                      Write(color.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 114 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                            break;
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("              \r\n                    <td style=\"border:1px solid;padding:5px 5px;text-align:center\">");
#nullable restore
#line 118 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                              Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td style=\"border:1px solid;padding:5px 5px;text-align:center\">");
#nullable restore
#line 120 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                              Write(item.Price.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</td>\r\n");
#nullable restore
#line 121 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                      
                        var thanhtien = item.Price * item.Quantity;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"border:1px solid;padding:5px 5px;text-align:center\">");
#nullable restore
#line 124 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                              Write(thanhtien.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("đ</td>\r\n                </tr>\r\n");
#nullable restore
#line 126 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <tr>
                <td style=""padding:5px 5px;text-align:center;font-weight:bold"">Tổng cộng</td>
                <td style=""padding:5px 5px;text-align:center""></td>
                <td style=""padding:5px 5px;text-align:center""></td>
                <td style=""padding:5px 5px;text-align:center""></td>
                <td style=""padding:5px 5px;text-align:center""></td>
");
#nullable restore
#line 133 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                  
                    var total = orderDetails.Sum(n => n.Price * n.Quantity);
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"padding:5px 5px;text-align:center;font-weight:bold\">");
#nullable restore
#line 136 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                                          Write(total.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n            </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <div style=\"font-family: sans-serif;padding-top:20px;text-align:right\">\r\n");
#nullable restore
#line 142 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
          
            DateTime dateTime = DateTime.Now;
            var monthEdit = dateTime.Month >= 10 ? dateTime.Month.ToString() : "0" + dateTime.Month.ToString();
            var dayEdit = dateTime.Day >= 10 ? dateTime.Day.ToString() : "0" + dateTime.Day.ToString();
            var year = dateTime.Year;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <i>Thái Bình, ngày ");
#nullable restore
#line 148 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                      Write(dayEdit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tháng ");
#nullable restore
#line 148 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                     Write(monthEdit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" năm ");
#nullable restore
#line 148 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\ViewPdf.cshtml"
                                                    Write(year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</i>
    </div>
    <div style=""font-family: sans-serif;padding-top:10px;display:flex"">
        <div style=""text-align:center;float:left"">
            <h4 style=""margin:0px"">Người bán hàng</h4>
            <i>(Ký & ghi rõ họ tên)</i>
        </div>
        <div style=""text-align:center;float:right"">
            <h4 style=""margin:0px"">Khách hàng</h4>
            <i>(Ký & ghi rõ họ tên)</i>
        </div>

    </div>

</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, object>> Html { get; private set; }
    }
}
#pragma warning restore 1591

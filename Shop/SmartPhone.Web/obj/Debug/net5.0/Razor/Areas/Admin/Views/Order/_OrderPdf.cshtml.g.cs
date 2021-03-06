#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335c6e1bb110652e466f423ad52801589743c1ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order__OrderPdf), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/_OrderPdf.cshtml")]
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
#line 2 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
using SmartPhone.Models.EF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
using SmartPhone.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335c6e1bb110652e466f423ad52801589743c1ab", @"/Areas/Admin/Views/Order/_OrderPdf.cshtml")]
    public class Areas_Admin_Views_Order__OrderPdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartPhone.Models.EF.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/images/avatar/iconlogo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
  
    List<OrderDetail> orderDetails = ViewBag.orderdetial as List<OrderDetail>;
    List<Product> products = ViewBag.products as List<Product>;
 DistrictView districts = ViewBag.dv as DistrictView;
    MasterDatum color = ViewBag.color as MasterDatum;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div style=\"padding: 0 24px 24px;color:#663399\" id=\"pdfContainer\">\r\n    <div style=\"height:100px;font-family: sans-serif;\">\r\n        <div style=\"width: 50%;\r\n        text-align: center;\r\n        float: left;\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "335c6e1bb110652e466f423ad52801589743c1ab4382", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
          

            <h1 style=""font-size:18px; font-weight:600"">Trung T??m ??i???n Tho???i Di ?????ng Lan H???ng</h1>
        </div>
        <div style=""float:right; margin-right:100px;"">
            <div style=""padding-top:0px"">
                <label style=""margin-right: 8px;font-weight:bold"">?????a ch???:</label> <span>M?? Linh, ????ng H??ng,Th??i B??nh</span>
            </div>
            <div style=""padding-top:8px"">
                <label style=""margin-right: 8px;font-weight:bold"">S??? ??i???n tho???i:</label> <span>0383515382</span>
            </div>
            <div style=""padding-top:8px"">
                <label style=""margin-right: 8px;font-weight:bold"">Email:</label> <span>LanHangMobile@gmail.com</span>
            </div>
            <div style=""padding-top:8px"">
                <label style=""margin-right: 8px;font-weight:bold"">Facebook:</label> <span>Trung T??m ??TD?? Lan H???ng</span>
            </div>
        </div>
    </div>
    <div style=""padding-top:30px !important;clear:both;font-family: sans-se");
            WriteLiteral(@"rif;"">
        <h2 style=""text-align:center;margin:0px"">H??A ????N B??N H??NG</h2>
    </div>
    <div style=""padding-top:30px !important;font-family: sans-serif;"">
        <div>
            <label style=""margin-right: 8px;font-weight:bold"">H??? t??n kh??ch h??ng:</label><span>");
#nullable restore
#line 43 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                                         Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div style=\"padding-top:8px\">\r\n            <label style=\"margin-right: 8px;font-weight:bold\">?????a ch???: </label><span>");
#nullable restore
#line 46 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                                Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 46 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                                                Write(districts.district.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 46 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                                                                          Write(districts.provinces.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div style=\"padding-top:8px\">\r\n            <label style=\"margin-right: 8px;font-weight:bold\">Email: </label><span>");
#nullable restore
#line 49 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                              Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div style=\"padding-top:8px\">\r\n            <label style=\"margin-right: 8px;font-weight:bold\">S??? ??i???n tho???i: </label><span>");
#nullable restore
#line 52 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                                      Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
            WriteLiteral(@"    </div>
    <div style=""font-family: sans-serif;padding-top:10px;"">
        <table style=""width:100%;border-collapse:collapse;color:#663399"">
            <thead>
                <tr>
                    <th style=""border:1px solid;padding:5px 5px; text-align:center;"">
                        T??n h??ng h??a, d???ch v???
                    </th>
                    <th style=""border:1px solid;padding:5px 5px; text-align:center;"">
                        ????n v??? t??nh
                    </th>
                    <th style=""border:1px solid;padding:5px 5px; text-align:center;"">
                        M??u s???c
                    </th>
                    <th style=""border:1px solid;padding:5px 5px; text-align:center;"">
                        S??? l?????ng
                    </th>

                    <th style=""border:1px solid;padding:5px 5px; text-align:center;"">
                        ????n gi??
                    </th>
                    <th style=""border:1px solid;padding:5px 5px; text-align:c");
            WriteLiteral("enter\">\r\n                        Th??nh ti???n\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 99 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                 foreach (var item in orderDetails)
                {
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 103 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                     foreach (var product in products)
                    {
                        if (product.Id == item.ProductId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"border:1px solid;padding:5px 5px;text-align:center\">");
#nullable restore
#line 107 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 108 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                            break;
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"border:1px solid;padding:5px 5px;text-align:center\">Chi???c</td>\r\n                    <td style=\"border:1px solid;padding:5px 5px;text-align:center\">");
#nullable restore
#line 112 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                              Write(color.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid;padding:5px 5px;text-align:center\">");
#nullable restore
#line 113 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                              Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"border:1px solid;padding:5px 5px;text-align:center\">");
#nullable restore
#line 114 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                              Write(item.Price.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("??</td>\r\n\r\n");
#nullable restore
#line 116 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                      
                        var thanhtien = item.Price * item.Quantity;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"border:1px solid;padding:5px 5px;text-align:center\">");
#nullable restore
#line 119 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                              Write(thanhtien.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("??</td>\r\n                </tr>\r\n");
#nullable restore
#line 121 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <tr>
                <td style=""padding:5px 5px;text-align:center;font-weight:bold"">T???ng c???ng</td>
                <td style=""padding:5px 5px;text-align:center""></td>
                <td style=""padding:5px 5px;text-align:center""></td>
                <td style=""padding:5px 5px;text-align:center""></td>
                <td style=""padding:5px 5px;text-align:center""></td>
");
#nullable restore
#line 128 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                  
                    var total = orderDetails.Sum(n => n.Price * n.Quantity);
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"padding:5px 5px;text-align:center;font-weight:bold\">");
#nullable restore
#line 131 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                                          Write(total.Value.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VN??</td>\r\n            </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <div style=\"font-family: sans-serif;padding-top:20px;text-align:right\">\r\n");
#nullable restore
#line 137 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
          
            DateTime dateTime = DateTime.Now;
            var monthEdit = dateTime.Month >= 10 ? dateTime.Month.ToString() : "0" + dateTime.Month.ToString();
            var dayEdit = dateTime.Day >= 10 ? dateTime.Day.ToString() : "0" + dateTime.Day.ToString();
            var year = dateTime.Year;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <i>H?? N???i, ng??y ");
#nullable restore
#line 143 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                   Write(dayEdit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" th??ng ");
#nullable restore
#line 143 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                  Write(monthEdit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" n??m ");
#nullable restore
#line 143 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
                                                 Write(year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</i>
    </div>
    <div style=""font-family: sans-serif;padding-top:10px;display:flex;justify-content:space-between;"">
        <div style=""text-align:center;float:left"">
            <h4 style=""margin:0px"">Ng?????i b??n h??ng</h4>
            <i>(K?? & ghi r?? h??? t??n)</i>
        </div>
        <div style=""text-align:center;float:right"">
            <h4 style=""margin:0px"">Kh??ch h??ng</h4>
            <i>(K?? & ghi r?? h??? t??n)</i>
        </div>
    </div>
    <div");
            BeginWriteAttribute("class", " class=\"", 7438, "\"", 7446, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"text-align:center\">\r\n        <button class=\"btn-success btn-event btnPrint\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7530, "\"", 7558, 3);
            WriteAttributeValue("", 7540, "Print(\'", 7540, 7, true);
#nullable restore
#line 156 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Order\_OrderPdf.cshtml"
WriteAttributeValue("", 7547, Model.Id, 7547, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7556, "\')", 7556, 2, true);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"\" title=\"In\" style=\"width: 50px; height: 30px;\"><i class=\"fas fa-print\" style=\"font-size:17px\"></i> In </button>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartPhone.Models.EF.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4bdfca1cfdaa0dc2579e111141d9e688ad0f623"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchByProduct), @"mvc.1.0.view", @"/Views/Search/SearchByProduct.cshtml")]
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
#line 1 "E:\DO_AN\Shop\SmartPhone.Web\Views\_ViewImports.cshtml"
using SmartPhone.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DO_AN\Shop\SmartPhone.Web\Views\_ViewImports.cshtml"
using SmartPhone.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
using SmartPhone.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
using SmartPhone.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
using SmartPhone.Models.EF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4bdfca1cfdaa0dc2579e111141d9e688ad0f623", @"/Views/Search/SearchByProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a6b8d880607284f83745bf078a35e601e1464b", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchByProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartPhone.Models.EF.ResponseDataAdmin<SmartPhone.Models.EF.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
  
    CultureInfo culture = CultureInfo.GetCultureInfo("vi-VN");

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row1 list-category\" id=\"searchProductByCate\" data-pagecount=\"");
#nullable restore
#line 9 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                                                                        Write(Model.pageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-pagenumber=\"");
#nullable restore
#line 9 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                                                                                                           Write(Model.pageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 10 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
         foreach (var item in Model.data)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-3 col-sm-6 mt-40\">\r\n                <!-- single-product-wrap start -->\r\n                <div class=\"single-product-wrap\">\r\n                    <div class=\"product-image\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 736, 4);
            WriteAttributeValue("", 707, "/san-pham/", 707, 10, true);
#nullable restore
#line 16 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
WriteAttributeValue("", 717, item.Slug, 717, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 727, "/", 727, 1, true);
#nullable restore
#line 16 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
WriteAttributeValue("", 728, item.Id, 728, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 772, "\"", 789, 1);
#nullable restore
#line 17 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
WriteAttributeValue("", 778, item.Image, 778, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Li\'s Product Image\">\r\n                        </a>\r\n");
#nullable restore
#line 19 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                         if (item.OldNew == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"sticker\">Mới</span>\r\n");
#nullable restore
#line 22 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                        }
                        else if (item.OldNew == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"sticker\">99%</span>\r\n");
#nullable restore
#line 26 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                        }
                        else if (item.OldNew == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"sticker\">Cũ</span>\r\n");
#nullable restore
#line 30 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <div class=""product_desc"">
                        <div class=""product_desc_info"">
                            <div class=""product-review"">
                                <h5 class=""manufacturer"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1637, "\"", 1673, 4);
            WriteAttributeValue("", 1644, "/san-pham/", 1644, 10, true);
#nullable restore
#line 37 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
WriteAttributeValue("", 1654, item.Slug, 1654, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1664, "/", 1664, 1, true);
#nullable restore
#line 37 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
WriteAttributeValue("", 1665, item.Id, 1665, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Graphic Corner</a>
                                </h5>
                                <div class=""rating-box"">
                                    <ul class=""rating"">
                                        <li><i class=""fa fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                        <li><i class=""fa fa-star-o""></i></li>
                                        <li class=""no-star""><i class=""fa fa-star-o""></i></li>
                                        <li class=""no-star""><i class=""fa fa-star-o""></i></li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""product_name""><a class=""product_name_link""");
            BeginWriteAttribute("href", " href=\"", 2477, "\"", 2513, 4);
            WriteAttributeValue("", 2484, "/san-pham/", 2484, 10, true);
#nullable restore
#line 49 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
WriteAttributeValue("", 2494, item.Slug, 2494, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2504, "/", 2504, 1, true);
#nullable restore
#line 49 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
WriteAttributeValue("", 2505, item.Id, 2505, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                                                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 50 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                             if (item.PriceSale == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"price-box pt-10\">\r\n                                    <span class=\"new-price new-price-2\">\r\n                                        ");
#nullable restore
#line 54 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                                   Write(item.Price.Value.ToString("#,###", culture.NumberFormat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ₫\r\n                                    </span>\r\n                                </div>\r\n");
#nullable restore
#line 58 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"price-box pt-10\">\r\n                                    <span class=\"new-price new-price-2\">\r\n                                        ");
#nullable restore
#line 64 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                                   Write(item.PriceSale.Value.ToString("#,###", culture.NumberFormat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ₫\r\n                                    </span>\r\n                                    <span class=\"old-price\">\r\n                                        ");
#nullable restore
#line 68 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                                   Write(item.Price.Value.ToString("#,###", culture.NumberFormat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ₫\r\n                                    </span>\r\n                                </div>\r\n");
#nullable restore
#line 72 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"add-actions\">\r\n                            <ul class=\"add-actions-link\">\r\n                                <li class=\"add-cart active\"><a href=\"shopping-cart.html\" data-id=\"");
#nullable restore
#line 77 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
                                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Mua Hàng</a></li>\r\n                              \r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <!-- single-product-wrap end -->\r\n            </div>\r\n");
#nullable restore
#line 85 "E:\DO_AN\Shop\SmartPhone.Web\Views\Search\SearchByProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartPhone.Models.EF.ResponseDataAdmin<SmartPhone.Models.EF.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49c9f9e369a9825176913c183da633e00f334a7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Payment), @"mvc.1.0.view", @"/Views/Cart/Payment.cshtml")]
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
#line 1 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c9f9e369a9825176913c183da633e00f334a7d", @"/Views/Cart/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a6b8d880607284f83745bf078a35e601e1464b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SmartPhone.Models.ViewModel.CartViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("section-content form-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Scripts/jquery-3.4.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
  
    decimal total = 0;


#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
  
    CultureInfo culture = CultureInfo.GetCultureInfo("vi-VN");

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    header{\r\n        display:none;\r\n    }\r\n</style>\r\n");
#nullable restore
#line 19 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
 if (Model != null)
{
    foreach (var item in Model)
    {
        if (item.product.PriceSale == null)
        {
            total += (item.product.Price.GetValueOrDefault(0) * item.Quantity);

        }
        else
        {
            total += (item.product.PriceSale.GetValueOrDefault(0) * item.Quantity);
        }

    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content"">
    <div class=""wrap"">
        <main class=""main"">
            <div class=""main-header"">
                <div class=""logo logo-left"">
                    <a href=""/"" class=""logo-link"">
                        Trung Tâm Điện Thọai Di Động Lan Hằng
                    </a>
                </div>
            </div>
            <div class=""breadcrumb-area"" style=""padding:5px 0 12px"">
                <div class=""container"">
                    <div class=""breadcrumb-content"">
                        <ul>
                            <li><a href=""/""><i class=""fa fa-shopping-bag""></i>Giỏ hàng</a></li>
                            <li class=""active""><a");
            BeginWriteAttribute("href", " href=\"", 1374, "\"", 1381, 0);
            EndWriteAttribute();
            WriteLiteral(@">Thông tin giao hàng</a></li>

                        </ul>
                    </div>
                </div>
            </div>
            <div class=""main-content"">
                <div class=""row"">
                    <div class=""col col--two form-input"">
                        <div class=""section"">
                            <div class=""section-header"">
                                <div class=""layout-flex"">
                                    <h2 class=""section-title"">Thông tin nhận hàng</h2>
                                </div>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c9f9e369a9825176913c183da633e00f334a7d7342", async() => {
                WriteLiteral(@"
                                <div class=""fieldset"" id=""form-checkout"">
                                    <div class=""field  field--show-floating-label"">
                                        <div class=""field__input-wrapper"">
                                            <label for=""email"" class=""field__label"">
                                                Email
                                            </label>
                                            <input name=""Email"" id=""email"" type=""email"" class=""field__input"">
                                            <span class=""form-message""></span>
                                        </div>
                                    </div>
                                    <div class=""field"">
                                        <div class=""field__input-wrapper"">
                                            <label for=""billingName"" class=""field__label"">Họ và tên</label>
                                            <input name=""FullName""");
                WriteLiteral(" id=\"Name\" type=\"text\" class=\"field__input\"");
                BeginWriteAttribute("value", " value=\"", 3116, "\"", 3124, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <span class=""form-message""></span>
                                        </div>

                                    </div>
                                    <div class=""field"">
                                        <div class=""field__input-wrapper"">
                                            <label for=""billingPhone"" class=""field__label"">
                                                Số điện thoại
                                            </label>
                                            <input name=""Phone"" id=""billingPhone"" type=""number"" class=""field__input""");
                BeginWriteAttribute("value", " value=\"", 3761, "\"", 3769, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <span class=""form-message""></span>
                                        </div>

                                    </div>
                                    <div class=""field "">
                                        <div class=""field__input-wrapper"">
                                            <label for=""billingAddress"" class=""field__label"">
                                                Địa chỉ
                                            </label>
                                            <input name=""Address"" id=""billingAddress"" type=""text"" class=""field__input""");
                BeginWriteAttribute("value", " value=\"", 4405, "\"", 4413, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <span class=""form-message""></span>
                                        </div>

                                    </div>
                                    <div class=""field field--show-floating-label "">
                                        <div class=""field__input-wrapper field__input-wrapper--select2"">
                                            <label for=""billingProvince"" class=""field__label""></label>
                                            <select id=""billingProvince"" type=""text"" class=""field__input field__input--select select2-hidden-accessible"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c9f9e369a9825176913c183da633e00f334a7d11200", async() => {
                    WriteLiteral("--Chọn tỉnh/ thành phố");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 109 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                                 foreach (var item in ViewBag.province as IEnumerable<SmartPhone.Models.EF.Province>)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c9f9e369a9825176913c183da633e00f334a7d12850", async() => {
#nullable restore
#line 111 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 112 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            </select>

                                        </div>
                                    </div>
                                    <div class=""field field--show-floating-label "">
                                        <div class=""field__input-wrapper field__input-wrapper--select2"">
                                            <label for=""DistrictId"" class=""field__label"">

                                            </label>
                                            <select name=""DistrictId"" id=""billingDistrict"" type=""text"" class=""field__input field__input--select"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c9f9e369a9825176913c183da633e00f334a7d15644", async() => {
                    WriteLiteral("--Chọn Quận/ Huyện ----");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </select>
                                        </div>

                                    </div>
                                    <div class=""field"">
                                        <div class=""field__input-wrapper"">
                                            <label for=""note"" class=""field__label"">
                                                Ghi chú
                                            </label>
                                            <textarea name=""Note"" id=""note"" type=""text"" class=""field__input""></textarea>
                                        </div>

                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>

        </main>
        <aside class=""sidebar"">
            <div class=""sidebar__header"">
                <h2 class=""sidebar__title"">
                    Đơn hàng
                </h2>
            </div>
            <div class=""sidebar__content"">
                <div id=""order-summary"" class=""order-summary order-summary--is-collapsed"">
                    <div class=""order-summary__sections"">
                        <div class=""order-summary__section order-summary__section--product-list order-summary__section--is-scrollable order-summary--collapse-element"">
                            <table class=""product-table"">

                                <tbody>
                                    <!--View thông tin đơn hàng-->

");
#nullable restore
#line 160 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                     if (Model.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 162 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr class=""product"">
                                                <td class=""product__image"">
                                                    <div class=""product-thumbnail"">
                                                        <div class=""product-thumbnail__wrapper"" data-tg-static="""">

                                                            <img");
            BeginWriteAttribute("src", " src=\"", 8454, "\"", 8479, 1);
#nullable restore
#line 169 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
WriteAttributeValue("", 8460, item.product.Image, 8460, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8480, "\"", 8486, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""product-thumbnail__image"">

                                                        </div>
                                                        <span class=""product-thumbnail__quantity"">1</span>
                                                    </div>
                                                </td>
                                                <th class=""product__description"">
                                                    <span class=""product__description__name"">

                                                        ");
#nullable restore
#line 178 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                                   Write(item.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </span>\r\n\r\n\r\n                                                </th>\r\n                                                <!-- <td class=\"product__quantity visually-hidden\"><em>Số lượng:</em> 1</td> -->\r\n");
#nullable restore
#line 184 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                                 if (item.product.PriceSale == null)
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td class=\"product__price\">\r\n                                                        ");
#nullable restore
#line 188 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                                    Write((item.product.Price.GetValueOrDefault(0) * item.Quantity).ToString("#,###", culture.NumberFormat));

#line default
#line hidden
#nullable disable
            WriteLiteral("₫\r\n                                                    </td>\r\n");
#nullable restore
#line 190 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td class=\"product__price\">\r\n                                                        ");
#nullable restore
#line 194 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                                    Write((item.product.PriceSale.GetValueOrDefault(0) * item.Quantity).ToString("#,###", culture.NumberFormat));

#line default
#line hidden
#nullable disable
            WriteLiteral("₫\r\n                                                    </td>\r\n");
#nullable restore
#line 196 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 201 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 201 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>


                        <div class=""order-summary__section order-summary__section--total-lines order-summary--collapse-element"" id=""orderSummary"">
                            <table class=""total-line-table"">

                                <tbody class=""total-line-table__tbody"">
                                    <tr class=""total-line total-line--subtotal"">
                                        <th class=""total-line__name"">
                                            Tạm tính
                                        </th>
                                        <td class=""total-line__price"">");
#nullable restore
#line 216 "E:\DO_AN\Shop\SmartPhone.Web\Views\Cart\Payment.cshtml"
                                                                 Write(total.ToString("#,###", culture.NumberFormat));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"₫</td>
                                    </tr>
                                </tbody>
                                <tfoot class=""total-line-table__footer"">
                                    <tr class=""total-line payment-due"">
                                        <th class=""total-line__name"">
                                            <span class=""payment-due__label-total"">
                                                Tổng cộng
                                            </span>
                                        </th>
                                        <td class=""total-line__price"">
                                            <span class=""payment-due__price""></span>
                                        </td>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
                        <div class=""order-summary__nav field__input-btn-wrapper hide-on-mobile layout-flex--r");
            WriteLiteral(@"ow-reverse"">
                            <button type=""button"" class=""btn btn-checkout spinner"">
                                <span class=""spinner-label"" id=""checkout-payment"">ĐẶT HÀNG</span>
                            </button>


                            <a href=""/dat-hang"" class=""previous-link"">
                                <i class=""fa fa-chevron-left"" aria-hidden=""true""></i>
                                <span class=""previous-link__content"">Quay về giỏ hàng</span>
                            </a>

                        </div>


                    </div>
                </div>
            </div>
        </aside>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c9f9e369a9825176913c183da633e00f334a7d27308", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $(""#billingProvince"").change(function () {
            var getProvinceID = $(this).val();
            console.log(getProvinceID);
            GetListDistrict(getProvinceID);

        })
        function GetListDistrict(id) {
            $.ajax({
                url: ""/Admin/Customer/GetListDistrict"",
                type: ""post"",
                dataType: ""json"",
                data: { id: id },
                beforeSend: function () { },
                success: function (res) {
                    console.log(typeof res);
                    var option = `<option value=""0"">---Chọn Huyện------</option>`;
                    $(res).each(function (index, item) {
                        option += `<option value=""${item.id}"">${item.name}</option>`
                    })
                    $(""#billingDistrict"").html('');
                    $(""#billingDistrict"").append(option);
                },
                error: function () {");
            WriteLiteral(" },\r\n                complete: function () { }\r\n            })\r\n        }\r\n\r\n\r\n\r\n       \r\n    })\r\n\r\n   \r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SmartPhone.Models.ViewModel.CartViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\LoginOrRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ab0f0411e00c0fed3a94ae7bca74fe59c20de5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_LoginOrRegister), @"mvc.1.0.view", @"/Views/Shared/LoginOrRegister.cshtml")]
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
#line 1 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\LoginOrRegister.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\LoginOrRegister.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab0f0411e00c0fed3a94ae7bca74fe59c20de5c", @"/Views/Shared/LoginOrRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a6b8d880607284f83745bf078a35e601e1464b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_LoginOrRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\LoginOrRegister.cshtml"
  
    var session = HttpContextAccessor.HttpContext.Session.GetString("User");
    var user = new SmartPhone.Models.EF.Customer();
    if (session != null)
    {
        user = JsonConvert.DeserializeObject<SmartPhone.Models.EF.Customer>(session);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-9 col-md-8\">\r\n    <div class=\"header-top-right\">\r\n        <ul class=\"ht-menu\">\r\n            <!-- Begin Setting Area -->\r\n\r\n");
#nullable restore
#line 17 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\LoginOrRegister.cshtml"
             if (user.Name == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li>
                    <div class=""ht-setting-list"">
                        <a href=""dang-ky-tai-khoan"">Đăng Ký</a>
                    </div>
                </li>
                <li>
                    <div class=""ht-setting-list"">
                        <a href=""dang-nhap-tai-khoan"">
                            Đăng Nhập

                        </a>
                    </div>
                </li>
");
#nullable restore
#line 32 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\LoginOrRegister.cshtml"
            }
            else

            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"header_username\">\r\n                    <div class=\"ht-setting-list\">\r\n\r\n\r\n                        <div class=\"navbar__username\">");
#nullable restore
#line 40 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\LoginOrRegister.cshtml"
                                                 Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <!--header _user-menu-->\r\n                    <div class=\"username_menu\">\r\n                        <ul class=\"username_menu_list\">\r\n                            <li class=\"username_menu_item\"><a");
            BeginWriteAttribute("href", " href=\"", 1473, "\"", 1480, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"user_menu-link\">Tài khoản của tôi</a></li>\r\n");
            WriteLiteral("                            <li class=\"username_menu_item\"><a href=\"/Author/LogOut\" class=\"user_menu-link\">Đăng xuất</a></li>\r\n                        </ul>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 51 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\LoginOrRegister.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- Language Area End Here -->\r\n        </ul>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

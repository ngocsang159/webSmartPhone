#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6e386abd913945f3b44b0eb8bc357166b4e1865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6e386abd913945f3b44b0eb8bc357166b4e1865", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a6b8d880607284f83745bf078a35e601e1464b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SmartPhone.Models.ViewModel.MenuViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 4 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"dropdown-holder\">\r\n\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 159, "\"", 182, 2);
            WriteAttributeValue("", 166, "/", 166, 1, true);
#nullable restore
#line 8 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 167, item.menu.Slug, 167, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml"
                                  Write(item.menu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 9 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml"
             if (item.subMenu.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"hb-dropdown\">\r\n");
#nullable restore
#line 12 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml"
                     foreach (var sub in item.subMenu)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"sub-dropdown-holder\">\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 475, "\"", 492, 2);
            WriteAttributeValue("", 482, "/", 482, 1, true);
#nullable restore
#line 16 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 483, sub.Slug, 483, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 16 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml"
                                             Write(sub.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                        </li>\r\n");
#nullable restore
#line 18 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 20 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </li>\r\n");
#nullable restore
#line 22 "E:\DO_AN\Shop\SmartPhone.Web\Views\Shared\Components\Menu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Header Bottom Menu Information Area End Here -->\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SmartPhone.Models.ViewModel.MenuViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
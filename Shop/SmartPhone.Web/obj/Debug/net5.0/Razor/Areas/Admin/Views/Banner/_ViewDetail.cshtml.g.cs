#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccaaf0f98b8de88055d6d2d944b543ff287e0a9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Banner__ViewDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/Banner/_ViewDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccaaf0f98b8de88055d6d2d944b543ff287e0a9f", @"/Areas/Admin/Views/Banner/_ViewDetail.cshtml")]
    public class Areas_Admin_Views_Banner__ViewDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartPhone.Models.EF.Banner>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    th:nth-child(1), td:nth-child(1) {\r\n        min-width: 200px;\r\n    }\r\n</style>\r\n<h4>Chi tiết thông tin Banner</h4>\r\n<table>\r\n    <tr>\r\n        <th>Tên Banner : </th>\r\n        <td>");
#nullable restore
#line 11 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Chi tiết ảnh : </th>\r\n        <td><img");
            BeginWriteAttribute("src", " src=\"", 320, "\"", 338, 1);
#nullable restore
#line 16 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
WriteAttributeValue("", 326, Model.Image, 326, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 339, "\"", 356, 1);
#nullable restore
#line 16 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
WriteAttributeValue("", 345, Model.Name, 345, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"120\" height=\"70\" style=\"object-fit:cover\" /></td>\r\n    </tr>\r\n    <tr>\r\n        <th>Tiêu đề : </th>\r\n        <td>");
#nullable restore
#line 20 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Số thứ tự : </th>\r\n        <td>");
#nullable restore
#line 24 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
       Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Ngày tạo : </th>\r\n        <td>");
#nullable restore
#line 29 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
       Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Người tạo : </th>\r\n        <td>");
#nullable restore
#line 34 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
       Write(Model.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Người cập nhật : </th>\r\n        <td>");
#nullable restore
#line 39 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
       Write(Model.UpdatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Ngày cập nhật : </th>\r\n        <td>");
#nullable restore
#line 44 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
       Write(Model.UpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Trạng thái</th>\r\n");
#nullable restore
#line 49 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
         if (Model.Status == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><span class=\"badge badge-success\">Hoạt động</span></td>\r\n");
#nullable restore
#line 52 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><span class=\"badge badge-danger\">Ngừng hoạt động</span></td>\r\n");
#nullable restore
#line 56 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Banner\_ViewDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartPhone.Models.EF.Banner> Html { get; private set; }
    }
}
#pragma warning restore 1591
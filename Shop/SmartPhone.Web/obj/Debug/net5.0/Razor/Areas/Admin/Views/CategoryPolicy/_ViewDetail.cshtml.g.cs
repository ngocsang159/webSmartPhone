#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74b6954b7d1facd1dc2ea659d93f97a1e11ef1d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CategoryPolicy__ViewDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/CategoryPolicy/_ViewDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b6954b7d1facd1dc2ea659d93f97a1e11ef1d3", @"/Areas/Admin/Views/CategoryPolicy/_ViewDetail.cshtml")]
    public class Areas_Admin_Views_CategoryPolicy__ViewDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartPhone.Models.EF.Policy>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    th:nth-child(1), td:nth-child(1) {\r\n        min-width: 200px;\r\n    }\r\n</style>\r\n<h4>Chi tiết thông tin danh mục sản phẩm</h4>\r\n<table>\r\n    <tr>\r\n        <th>Tên danh mục : </th>\r\n        <td>");
#nullable restore
#line 11 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Url:</th>\r\n        <td>");
#nullable restore
#line 15 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
       Write(Model.Slug);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Ảnh : </th>\r\n        <td><img");
            BeginWriteAttribute("src", " src=\"", 396, "\"", 414, 1);
#nullable restore
#line 19 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
WriteAttributeValue("", 402, Model.Image, 402, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 415, "\"", 432, 1);
#nullable restore
#line 19 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
WriteAttributeValue("", 421, Model.Name, 421, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"70\" width=\"70\" style=\"object-fit:cover\" /></td>\r\n    </tr>\r\n\r\n\r\n    <tr>\r\n        <th>Số thứ tự : </th>\r\n        <td>");
#nullable restore
#line 25 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
       Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Ngày tạo : </th>\r\n        <td>");
#nullable restore
#line 30 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
       Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Người tạo : </th>\r\n        <td>");
#nullable restore
#line 35 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
       Write(Model.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Người cập nhật : </th>\r\n        <td>");
#nullable restore
#line 40 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
       Write(Model.UpdatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Ngày cập nhật : </th>\r\n        <td>");
#nullable restore
#line 45 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
       Write(Model.UpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Trạng thái</th>\r\n");
#nullable restore
#line 50 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
         if (Model.Status == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><span class=\"badge badge-success\">Hoạt động</span></td>\r\n");
#nullable restore
#line 53 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><span class=\"badge badge-danger\">Ngừng hoạt động</span></td>\r\n");
#nullable restore
#line 57 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryPolicy\_ViewDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartPhone.Models.EF.Policy> Html { get; private set; }
    }
}
#pragma warning restore 1591

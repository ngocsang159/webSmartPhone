#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryProduct\_AddOrUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49e723ac19aab906876b8b78a4389127dca6d5e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CategoryProduct__AddOrUpdate), @"mvc.1.0.view", @"/Areas/Admin/Views/CategoryProduct/_AddOrUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e723ac19aab906876b8b78a4389127dca6d5e2", @"/Areas/Admin/Views/CategoryProduct/_AddOrUpdate.cshtml")]
    public class Areas_Admin_Views_CategoryProduct__AddOrUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""collapse border show objInfor"">
    <div class=""alert-danger mb-3 admins-h2 btn-red"" style=""background: #f53d2d !important"">
        THÔNG TIN VỀ DANH MỤC SẢN PHẨM
    </div>
    <div class=""form-group mb-3"" hidden>
        <input type=""number"" name=""Id"" class=""form-control"" id=""Id"" value=""0"">
    </div>

    <div class=""form-group mb-3"">
        <label class=""font-weight-bold mb-1"">Mã danh mục</label>
        <input type=""text"" name=""Code"" class=""form-control"" id=""code""");
            BeginWriteAttribute("value", " value=\"", 497, "\"", 505, 0);
            EndWriteAttribute();
            WriteLiteral(" autofocus>\r\n        <div class=\"text-danger\"></div>\r\n    </div>\r\n\r\n    <div class=\"form-group mb-3\">\r\n        <label class=\"font-weight-bold mb-1\">Tiêu đề</label>\r\n        <input type=\"text\" name=\"Name\" class=\"form-control\" id=\"name\"");
            BeginWriteAttribute("value", " value=\"", 740, "\"", 748, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""text-danger""></div>
    </div>

    <div class="" mb-3"">
        <h6 class=""input-group-text"">Ảnh Logo</h6>
        <input type=""hidden"" name=""Image"" value=""/Upload/Image/no-image.jpg"" id=""image"" />
        <img src=""/Upload/Image/no-image.jpg"" alt=""ảnh banner"" class=""img-size img-fluid"" title=""Cập nhật"" id=""show-img"" style=""object-fit:cover"" />
        <div class=""text-danger""></div>
    </div>

    <div class=""form-group mb-3"">
        <label class=""font-weight-bold mb-1"">Thứ tự</label>
        <input type=""number"" name=""Position"" class=""form-control"" id=""Position"" value=""0"">
        <div class=""text-danger""></div>
    </div>

    <div class=""form-group mb-3"">
        <label class=""font-weight-bold mb-1"">Trạng thái</label>
        <input type=""radio"" name=""Status"" id=""s1"" data-value=""1"" value=""1"" class=""ml-4"" checked /> <label for=""s1"" class=""mt-1 ml-2"">Hoạt động</label>
        <input type=""radio"" name=""Status"" id=""s2"" data-value=""0"" value=""0"" class=""ml-4"" /> <label");
            WriteLiteral(@" for=""s2"" class=""mt-1 ml-2"">Khóa</label>
    </div>
    <div class=""row"">
        <div class=""col-md-12 text-right mr-0 pr-0 mt-1 mb-0 modal-footer"">
            <button type=""button"" class=""btn btn btn-red btnCancel""><i class=""fas fa-reply-all""></i> Nhập lại</button>
            <button type=""button"" class=""btn btn-success btnSave"" data-id=""0""> <i class=""far fa-save""></i> Lưu lại</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a37c548636c21d28684ff458ca9d91eb74655fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductSpecification_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductSpecification/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a37c548636c21d28684ff458ca9d91eb74655fc", @"/Areas/Admin/Views/ProductSpecification/Index.cshtml")]
    public class Areas_Admin_Views_ProductSpecification_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartPhone.Models.EF.ProductSpecification>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
  
    ViewData["Title"] = "Thông số kỹ thuật";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .input-group-prepend, .input-group-prepend > span {
        width: 180px !important;
    }

    .form-group label {
        cursor: pointer;
    }

    h6 span {
        color: #495057;
        font-size: 1.1rem;
        font-weight: 400;
        line-height: 1.2;
        padding: 2rem 0rem;
    }
</style>



<div class=""show-table"">
    <div class=""container-fluid objInfor pl-3 pr-3"">
        <div class=""showModal"">
            <!--Xem chi tiết -->
            <div class=""modal fade"" id=""myModal"">
                <div class=""modal-dialog modal-xl modal-dialog-scrollable"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        </div>
                        <div class=""modal-body"">

                        </div>
                        <div class=""modal-footer"">
                            <but");
            WriteLiteral(@"ton type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row mb-1 objnews"">
            
            <input type=""hidden"" name=""ID""");
            BeginWriteAttribute("value", " value=\"", 1496, "\"", 1513, 1);
#nullable restore
#line 50 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 1504, Model.Id, 1504, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""ID"" />
            <div class=""col-md-9 mb-1"">
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Tên bài viết</span>
                        </div>
                        <input type=""text"" name=""Name"" class=""form-control"" id=""Name""");
            BeginWriteAttribute("value", " value=\"", 1899, "\"", 1918, 1);
#nullable restore
#line 57 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 1907, Model.Name, 1907, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""250"">
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Thiết kế</span>
                        </div>
                        <input type=""text"" name=""Design"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2364, "\"", 2385, 1);
#nullable restore
#line 67 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 2372, Model.Design, 2372, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""250"">
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Kích thước</span>
                        </div>
                        <input type=""text"" name=""Size"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2831, "\"", 2850, 1);
#nullable restore
#line 77 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 2839, Model.Size, 2839, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Màn hình</span>
                        </div>
                        <input type=""text"" name=""Screen"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3282, "\"", 3303, 1);
#nullable restore
#line 87 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 3290, Model.Screen, 3290, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Độ phân giải màn hình</span>
                        </div>
                        <input type=""text"" name=""ScreenResolution"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3758, "\"", 3789, 1);
#nullable restore
#line 97 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 3766, Model.ScreenResolution, 3766, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Màn hình rộng</span>
                        </div>
                        <input type=""text"" name=""WideScreen"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4228, "\"", 4253, 1);
#nullable restore
#line 106 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 4236, Model.WideScreen, 4236, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Camera sau</span>
                        </div>
                        <input type=""text"" name=""CameraRear"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4691, "\"", 4716, 1);
#nullable restore
#line 116 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 4699, Model.CameraRear, 4699, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Camera selfie</span>
                        </div>
                        <input type=""text"" name=""CameraSelfie"" id=""CameraSelfie"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5177, "\"", 5204, 1);
#nullable restore
#line 126 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 5185, Model.CameraSelfie, 5185, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">RAM</span>
                        </div>
                        <input type=""text"" name=""Ram"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5628, "\"", 5646, 1);
#nullable restore
#line 136 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 5636, Model.Ram, 5636, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Bộ nhớ trong</span>
                        </div>
                        <input type=""text"" name=""Memory"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 6080, "\"", 6101, 1);
#nullable restore
#line 145 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 6088, Model.Memory, 6088, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Thẻ nhớ SD</span>
                        </div>
                        <input type=""text"" name=""CardMemory"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 6539, "\"", 6564, 1);
#nullable restore
#line 155 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 6547, Model.CardMemory, 6547, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">CPU</span>
                        </div>
                        <input type=""text"" name=""Cpu"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 6988, "\"", 7006, 1);
#nullable restore
#line 165 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 6996, Model.Cpu, 6996, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Tốc độ CPU</span>
                        </div>
                        <input type=""text"" name=""SpeedCpu"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 7442, "\"", 7465, 1);
#nullable restore
#line 175 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 7450, Model.SpeedCpu, 7450, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">GPU</span>
                        </div>
                        <input type=""text"" name=""Gpu"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 7889, "\"", 7907, 1);
#nullable restore
#line 185 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 7897, Model.Gpu, 7897, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Dung lượng pin</span>
                        </div>
                        <input type=""text"" name=""Battery"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 8346, "\"", 8368, 1);
#nullable restore
#line 195 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 8354, Model.Battery, 8354, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Cáp sạc</span>
                        </div>
                        <input type=""text"" name=""ChargingPort"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 8803, "\"", 8830, 1);
#nullable restore
#line 204 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 8811, Model.ChargingPort, 8811, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Thẻ SIM</span>
                        </div>
                        <input type=""text"" name=""Sim"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 9256, "\"", 9274, 1);
#nullable restore
#line 213 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 9264, Model.Sim, 9264, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Mạng kết nối</span>
                        </div>
                        <input type=""text"" name=""Network"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 9709, "\"", 9731, 1);
#nullable restore
#line 222 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 9717, Model.Network, 9717, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Jack cắm tai nghe</span>
                        </div>
                        <input type=""text"" name=""JackHeadphone"" id=""JackHeadphone"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 10196, "\"", 10224, 1);
#nullable restore
#line 231 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 10204, Model.JackHeadphone, 10204, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Hệ điều hành</span>
                        </div>
                        <input type=""text"" name=""Os"" class=""form-control"" id=""Os""");
            BeginWriteAttribute("value", " value=\"", 10662, "\"", 10679, 1);
#nullable restore
#line 240 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 10670, Model.Os, 10670, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Sản xuất tại</span>
                        </div>
                        <input type=""text"" name=""MadeIn"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 11113, "\"", 11134, 1);
#nullable restore
#line 249 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 11121, Model.MadeIn, 11121, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>

                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Thời gian</span>
                        </div>
                        <input type=""date"" name=""LaunchTime"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 11571, "\"", 11596, 1);
#nullable restore
#line 259 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 11579, Model.LaunchTime, 11579, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Trạng thái</span>
                        </div>

                        <input type=""radio"" name=""Status"" id=""s1"" data-value=""1""");
            BeginWriteAttribute("value", " value=\"", 12033, "\"", 12054, 1);
#nullable restore
#line 269 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 12041, Model.Status, 12041, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ml-4\" checked /> <label for=\"s1\" class=\"mt-1 ml-2\">Hoạt động</label>\r\n                        <input type=\"radio\" name=\"Status\" id=\"s2\" data-value=\"0\"");
            BeginWriteAttribute("value", " value=\"", 12213, "\"", 12234, 1);
#nullable restore
#line 270 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\ProductSpecification\Index.cshtml"
WriteAttributeValue("", 12221, Model.Status, 12221, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""ml-4"" /> <label for=""s2"" class=""mt-1 ml-2"">Đang khóa</label>


                    </div>
                    <div class=""text-danger""></div>
                </div>
            </div>

            <div class=""container-fluid"">
                <div class=""row mb-3"">
                    <div class=""col-md-12 text-right mr-0 pr-0 mt-1 mb-5 modal-footer"">
                        <button type=""button"" class=""btn btn btn-red btnRefresh"" ><i class=""fas fa-reply-all""></i>Quay lại</button>
                        <button type=""button"" class=""btn btn-green btnSave""");
            BeginWriteAttribute("onclick", " onclick=\"", 12816, "\"", 12826, 0);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"far fa-save\"></i> Ghi lại</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n            $(document).ready(function () {\r\n                Save();\r\n                RefreshForm();\r\n");
                WriteLiteral(@"                function Save() {
                    $(document).on('click', '.btnSave', function () {
                        let specification = new Object();
                        $('.objnews input[type=""text""],.objnews input[type=""number""], .objnews input[type=""hidden""],.objnews input[type=""date""]').each(function () {
                            specification[$(this).attr('name')] = $(this).val();
                        });
                        specification[""Status""] = $('#s1').is(':checked') == 1 ? 1 : 0;


                            $.ajax({
                                url: '/Admin/ProductSpecification/Edit',
                                type: 'POST',
                                dataType: 'json',
                                data: {
                                    productSpecification: specification
                                },
                                beforeSend: function () {
                                },
                                su");
                WriteLiteral(@"ccess: function (res) {
                                    if (res == true) {
                                        swal({
                                            title: ""Thông báo"",
                                            text: 'Chỉnh sửa dữ liệu thành công.',
                                            icon: ""success"",
                                            dangerMode: true,
                                        }).then(() => {

                                        });
                                    } else {
                                        swal({
                                            title: ""Thông báo"",
                                            text: 'Đã xảy ra lỗi khi sửa đổi dữ liệu',
                                            icon: ""warning"",
                                            dangerMode: true,
                                        });
                                    }
                                },
                         ");
                WriteLiteral(@"       error: function () {

                                },
                                complete: function () {
                               
                                }
                            })

                    });
                }
                function RefreshForm() {
                    $(document).on('click', '.btnRefresh', function () {
                        $('.objInfor input:text').each(function (index, item) {
                            $(this).val('')
                        })
                        $('.objInfor input[type=number]').each(function (index, item) {
                            $(this).val(0)
                        })
                    })
           
                };
            })
    </script>
    ");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartPhone.Models.EF.ProductSpecification> Html { get; private set; }
    }
}
#pragma warning restore 1591

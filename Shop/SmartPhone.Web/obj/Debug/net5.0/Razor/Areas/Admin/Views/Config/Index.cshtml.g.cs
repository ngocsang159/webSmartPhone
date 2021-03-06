#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d9a520cb2db695ff5c8bc39f44a6122372bd46b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Config_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Config/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d9a520cb2db695ff5c8bc39f44a6122372bd46b", @"/Areas/Admin/Views/Config/Index.cshtml")]
    public class Areas_Admin_Views_Config_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartPhone.Models.EF.Config>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
  
    ViewData["Title"] = "Thông tin về Lan Hằng";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .input-group-prepend, .input-group-prepend > span {
        width: 120px !important;
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
                            <button type");
            WriteLiteral(@"=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row mb-1 objnews"">
            <input type=""hidden"" name=""ID""");
            BeginWriteAttribute("value", " value=\"", 1464, "\"", 1481, 1);
#nullable restore
#line 45 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 1472, Model.Id, 1472, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""ID"" />
            <div class=""col-md-9 mb-1"">
                <div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">Tên</span>
                        </div>
                        <input type=""text"" name=""Name"" class=""form-control"" id=""Name""");
            BeginWriteAttribute("value", " value=\"", 1858, "\"", 1877, 1);
#nullable restore
#line 52 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 1866, Model.Name, 1866, 11, false);

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
                            <span class=""input-group-text"">Số điện thoại</span>
                        </div>
                        <input type=""text"" name=""Phone"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2327, "\"", 2347, 1);
#nullable restore
#line 62 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 2335, Model.Phone, 2335, 12, false);

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
                            <span class=""input-group-text"">Email</span>
                        </div>
                        <input type=""text"" name=""Email"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 2789, "\"", 2809, 1);
#nullable restore
#line 72 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 2797, Model.Email, 2797, 12, false);

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
                            <span class=""input-group-text"">Địa chỉ</span>
                        </div>
                        <input type=""text"" name=""Address"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3241, "\"", 3263, 1);
#nullable restore
#line 82 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 3249, Model.Address, 3249, 14, false);

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
                            <span class=""input-group-text"">Hotline</span>
                        </div>
                        <input type=""text"" name=""HotLine"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 3693, "\"", 3715, 1);
#nullable restore
#line 91 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 3701, Model.HotLine, 3701, 14, false);

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
                            <span class=""input-group-text"">Facebook</span>
                        </div>
                        <input type=""text"" name=""FaceBook"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4149, "\"", 4172, 1);
#nullable restore
#line 101 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 4157, Model.Facebook, 4157, 15, false);

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
                            <span class=""input-group-text"">Youtube</span>
                        </div>
                        <input type=""text"" name=""Youtube"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4604, "\"", 4626, 1);
#nullable restore
#line 111 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 4612, Model.Youtube, 4612, 14, false);

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
                            <span class=""input-group-text"">Zalo</span>
                        </div>
                        <input type=""text"" name=""Zalo"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5052, "\"", 5071, 1);
#nullable restore
#line 121 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 5060, Model.Zalo, 5060, 11, false);

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
                            <span class=""input-group-text"">Mô tả</span>
                        </div>
                        <input type=""text"" name=""Description"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5505, "\"", 5531, 1);
#nullable restore
#line 131 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 5513, Model.Description, 5513, 18, false);

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
                            <span class=""input-group-text"">Link bản đồ</span>
                        </div>
                        <input type=""text"" name=""Map"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 5961, "\"", 5979, 1);
#nullable restore
#line 140 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 5969, Model.Map, 5969, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                    </div>
                    <div class=""text-danger""></div>
                </div>
            </div>
            <div class=""col-md-3 mb-1"">
                <h6 class=""input-group-text"">Ảnh Logo</h6>
                <input type=""hidden"" name=""Logo""");
            BeginWriteAttribute("value", " value=\"", 6259, "\"", 6278, 1);
#nullable restore
#line 147 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 6267, Model.Logo, 6267, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"image\" />\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 6315, "\"", 6332, 1);
#nullable restore
#line 148 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Config\Index.cshtml"
WriteAttributeValue("", 6321, Model.Logo, 6321, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-size"" alt=""Cập nhật"" style=""object-fit:contain"" id=""show-img"" />
                <div class=""text-danger""></div>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <div class=""row mb-3"">
            <div class=""col-md-12 text-right mr-0 pr-0 mt-1 mb-5 modal-footer"">
                <button type=""button"" class=""btn btn btn-red btnBack""><i class=""fas fa-reply-all""></i> Bỏ qua</button>
                <button type=""button"" class=""btn btn-success btnSave""");
            BeginWriteAttribute("onclick", " onclick=\"", 6845, "\"", 6855, 0);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"far fa-save\"></i> Lưu lại</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            OpenFolderImage();
            Save();
            $("".btnBack"").click(function() {
                location.href = ""/Admin/"";
            })
            function OpenFolderImage() {
                $('#show-img').click(function () {
                    $.ajax({
                        url: ""/Admin/Home/ReadFileBrower"",
                        data: {},
                        type: ""get"",
                        dataType: 'html',
                        success: function (res) {
                            $('#myModal .modal-body').html('');
                            $('#myModal .modal-body').append(res);
                            if (!$('#myModal').hasClass('show')) {
                                $('#myModal').modal('show')
                                ChooseImage();
                            }
                        }
                    });
                })
            }

            function Choose");
                WriteLiteral(@"Image() {
                $('#fileExploer').on('click', 'img', function () {
                    var fileUrl = '/Upload/Image/' + $(this).attr('title');
                    $('#show-img').attr('src', fileUrl);
                    $('#image').val(fileUrl);
                    // ẩn modal đi
                    $('#myModal').modal('hide');
                }).hover(function () {
                    $(this).css('cursor', 'pointer')
                })
            }

            function Save() {
                $(document).on('click', '.btnSave', function () {
                    let config = new Object();
                    $('.objnews input[type=""text""],.objnews input[type=""number""], .objnews input[type=""hidden""]').each(function () {
                        config[$(this).attr('name')] = $(this).val();
                    });

                    if (CheckValidate()) {
                        debugger
                        $.ajax({
                            url: '/Admin/Config/Edit',
");
                WriteLiteral(@"                            type: 'POST',
                            dataType: 'json',
                            data: {
                                config: config
                            },
                            beforeSend: function () {
                            },
                            success: function (res) {
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
                                        text: 'Đã xảy ra lỗi khi sửa đổi dữ li");
                WriteLiteral(@"ệu',
                                        icon: ""warning"",
                                        dangerMode: true,
                                    });
                                }
                            },
                            error: function () {

                            },
                            complete: function () {

                            }
                        })
                    }

                });
            }
        })


        function CheckValidate() {
            let check = 0;
            $('.text-danger').html('');
            $('.objnews input').each(function () {
                let value = $(this).val();
                if (value == '') {
                    console.log($(this));
                    check++;
                    let title = $(this).siblings().children('span').text();
                    $(this).parent().siblings('.text-danger').append(title + ' không được để trống');
                }
         ");
                WriteLiteral(@"       if ($(this).attr('name') == ""Image"" && $(this).val() == ""/Upload/Image/no-image.jpg"") {
                    let title = $(this).siblings('h6').text();
                    $(this).siblings('.text-danger').append(title + ' không được để trống');
                    check++;
                }
            })
            return check == 0;
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartPhone.Models.EF.Config> Html { get; private set; }
    }
}
#pragma warning restore 1591

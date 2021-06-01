#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7c87c60504edd1e17274241dff0c512e23466c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Menu_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Menu/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c87c60504edd1e17274241dff0c512e23466c1", @"/Areas/Admin/Views/Menu/Index.cshtml")]
    public class Areas_Admin_Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Quản lý danh mục " + ViewBag.Name;
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""show-table"">
    <div class=""container-fluid"">
        <div class=""showModal"">
            <!--Show dialog image server-->
            <div class=""modal fade"" id=""myModal"" role=""dialog"">
                <div class=""modal-dialog modal-xl"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        </div>
                        <div class=""modal-body"">

                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-red"" data-dismiss=""modal"">Đóng</button>
                        </div>
                    </div>
                </div>
            </div>
            <!--Xem chi tiết -->
            <div class=""modal fade"" id=""Detail"" role=""dialog"">
                <div class=""modal-dialog modal-xl"">
                    <div class=""mo");
            WriteLiteral(@"dal-content"">
                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        </div>
                        <div class=""modal-body"">

                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-warning"" data-dismiss=""modal"">Đóng</button>
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""tableView"">
                    <div class=""row p-2"">
                        <div class=""utilities-top col-md-12  p-0 mb-2 justify-content-between d-flex"">
                            <div>
                                <select class=""form-control pageSize"" name=""display"">
                                    <option value=""1"">1</option>
               ");
            WriteLiteral(@"                     <option value=""5"" selected>5</option>
                                    <option value=""15"">15</option>
                                    <option value=""30"">30</option>
                                    <option value=""50"">50</option>
                                    <option value=""100"">100</option>
                                </select>
                            </div>
                            <div class=""search d-flex"">
                                <input type=""text"" placeholder=""Nhập tiêu đề tìm kiếm"" class=""searchInput form-control"" style=""width:250px"" title=""Nhập tiêu đề tìm kiếm -> Nhấn Enter"">
                                <button class=""btn-primary btn-tools text-nowrap btnAdd"">
                                    <i class=""fa fa-plus""></i> Thêm
                                </button>
                            </div>
                        </div>
                        <div class=""col-md-12 p-0"">
                            <div class=""tabl");
            WriteLiteral("e-view\">\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4 p-2\">\r\n                ");
#nullable restore
#line 75 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Menu\Index.cshtml"
           Write(await Html.PartialAsync("_AddOrUpdate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            let pageSize = 5;
            let pageNumber = 1;
            GetDataTable(pageSize,pageNumber, """");
            AddOrUpdate();
            SearchData();
            ChangePageSize();
");
                WriteLiteral(@"            function GetDataTable(pageSize, pageNumber, Search) {
                var getViewData = new Object();
                getViewData[""pageSize""] = pageSize;
                getViewData[""pageNumber""] = pageNumber;
                getViewData[""Search""] = Search;
                console.log(getViewData);
                $.ajax({
                    url: '/Admin/Menu/_TableView',
                    type: ""post"",
                    dataType: 'html',
                    data: {
                        getViewData: getViewData
                    },
                    success: function (res) {
                        console.log(getViewData);
                        $('.table-view').html('');
                        $('.table-view').append(res);
                    },
                    error: function (error) {

                    },
                    complete: function () {
                        RefreshForm();
                        ViewDetail();
                        D");
                WriteLiteral(@"eleteByID();
                        SetObjectToForm();
                        ChangePageNumber();
                        hrefListNew();
                    }
                })

            };
            function hrefListNew() {
                $('.btnHref').click(function () {
                    alert(1);
                    let Id = $(this).attr('data-id');
                    //let row = `<button type=""button"" class=""btn btn-red"">Quay l</button>`;
                    //var a = document.getElementById(""footer-btn"");
                    //$('.modal-footer').append(row);
                    //console.log(a);
                    location.href = ""/Admin/Menu/Index/"" + Id;
                   
                })
            }
            function RefreshForm() {
                $('.objInfor input:text').each(function (index, item) {
                    $(this).val('')
                })
                $('.objInfor input[type=number]').each(function (index, item) {
                  ");
                WriteLiteral(@"  $(this).val(0)
                })
            };

            function ViewDetail() {
                $('.btnDetail').click(function () {
                    let Id = $(this).attr('data-id');
                    $.ajax({
                        url: '/Admin/Menu/_GetViewDetail',
                        type: 'post',
                        dataType: 'html',
                        data: {
                            Id: Id
                        },
                        success: function (res) {
                            $('#Detail  .modal-body').html('');
                            $('#Detail  .modal-body').append(res);
                            $('#Detail').modal('show');
                        },
                        error: function (error) {

                        }
                    })
                })
            }
            function SetObjectToForm() {
                $('.btnEdit').click(function () {
                    let Id = $(this).attr('data-id');");
                WriteLiteral(@"
                    $.ajax({
                        url: '/Admin/Menu/GetMenuByID',
                        type: 'post',
                        dataType: 'json',
                        data: {
                            Id: Id
                        },
                        success: function (res) {
                            console.log(res);
                            $.each(res, function (key, value) {
                                if (key == ""status"") {
                                    if (value == 1) {
                                        $('#s1').prop('checked', 1);
                                    }
                                    else {
                                        $('#s2').prop('checked', 1);
                                    }
                                }
                                else {
                                    key = key.charAt(0).toUpperCase() + key.substring(1);
                                    $('.objInfor input");
                WriteLiteral(@"[name=' + key + ']').val(value);
                                }

                            })
                        },
                        error: function (error) {

                        }
                    })
                })
            }
            function DeleteByID() {
                $('.btnDelete').click(function () {
                    swal({
                        title: ""Xóa dữ liệu này?"",
                        text: ""Dữ liệu xóa sẽ không thể khôi phục!"",
                        icon: ""warning"",
                        buttons: true,
                        dangerMode: true,
                    })
                        .then((willDelete) => {
                            if (willDelete) {
                                let Id = $(this).attr('data-id');
                                let btn = $(this);
                                $.ajax({
                                    url: '/Admin/Menu/DeleteById',
                                    type");
                WriteLiteral(@": 'post',
                                    dataType: 'json',
                                    data: {
                                        Id: Id
                                    },
                                    success: function (res) {
                                        if (res)
                                            btn.parent('div').parent('td').parent('tr').fadeOut();
                                        window.location.reload();
                                    },
                                    error: function (error) {

                                    },
                                    complete: function () {
                                        GetDataTable(pageSize, pageNumber, '');
                                    }
                                })
                            };
                        });
                })
            }
            function AddOrUpdate() {
                $('.btnSave').click(function () {");
                WriteLiteral(@"
                    if (CheckValidate()) {
                        let menu = new Object();
                        $('.objInfor input').each(function (index, item) {
                            menu[$(this).attr('name')] = $(this).val();
                        })
                        menu[""Status""] = $('#s1').is(':checked') == 1 ? 1 : 0;
                        // submit data
                        console.log(menu);
                        $.ajax({
                            url: '/Admin/Menu/AddOrUpdate',
                            type: 'post',
                            dataType: 'json',
                            data: {
                                menu: menu
                            },
                            success: function (res) {
                                let msg = '';
                                let msgf = '';
                                if ($('#Id').val() == 0) {
                                    msg = 'Đã thêm dữ liệu thành công !';
    ");
                WriteLiteral(@"                                msgf = 'Đã thêm dữ liệu thất bại !';

                                }
                                else {
                                    msg = 'Đã sửa dữ liệu thành công !';
                                    msgf = 'Đã sửa dữ liệu thất bại !';
                                }
                                if (res) {
                                    var t = toastr.success(msg);
                                    t.show();
                                }
                                else {
                                    var t = toastr.warning(msgf);
                                    t.show();
                                }
                            },
                            error: function (error) {
                            },

                            complete: function () {
                                GetDataTable(pageSize, pageNumber, '');
                                RefreshForm();
                   ");
                WriteLiteral(@"         }
                        })
                    }
                    // get data
                })
            }

            function CheckValidate() {
                let check = 0;
                $('.text-danger').html('');
                $('.objInfor input').each(function () {
                    let value = $(this).val();
                    if (value == '') {
                        check++;
                        let title = $(this).siblings('label').text();
                        $(this).siblings('.text-danger').append(title + ' không được để trống');
                    }
                    if ($(this).attr('name') == ""Image"" && $(this).val() == ""/Upload/Image/no-image.jpg"") {
                        let title = $(this).siblings('h6').text();
                        $(this).siblings('.text-danger').append(title + ' không được để trống');
                        check++;
                    }
                })
                return check == 0;
            }
");
                WriteLiteral(@"
            // change view data

            function SearchData() {
                $('.searchInput').keyup(function () {
                    let search = $(this).val();
                    search = search.trim();
                    GetDataTable(pageSize, 1, search);
                })
            }

            function ChangePageNumber() {
                $('.pagination li a').click(function () {
                    pageNumber = $(this).attr('data-index');
                    let search = $('.searchInput').val().trim();
                    GetDataTable(pageSize, pageNumber, search);
                })
            }

            function ChangePageSize() {
                $('.pageSize').change(function () {
                    pageSize = $(this).val();
                    let search = $('.searchInput').val().trim();
                    GetDataTable(pageSize,1, search);
                })
            }
        })


    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
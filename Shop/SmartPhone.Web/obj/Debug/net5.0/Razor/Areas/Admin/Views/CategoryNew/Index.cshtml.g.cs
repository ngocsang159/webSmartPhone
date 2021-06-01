#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryNew\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c998cd2ab03b02f7d46c42270e0236d2dc2968d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CategoryNew_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CategoryNew/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c998cd2ab03b02f7d46c42270e0236d2dc2968d", @"/Areas/Admin/Views/CategoryNew/Index.cshtml")]
    public class Areas_Admin_Views_CategoryNew_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryNew\Index.cshtml"
  
    ViewData["Title"] = "Quản lý danh mục tin tức";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""show-table"">
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
                            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
            <!--Xem chi tiết -->
            <div class=""modal fade"" id=""Detail"" role=""dialog"">
                <div class=""modal-dialog modal-xl"">
                    <div cl");
            WriteLiteral(@"ass=""modal-content"">
                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        </div>
                        <div class=""modal-body"">

                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
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
            WriteLiteral(@"                             <option value=""5"" selected>5</option>
                                    <option value=""15"">15</option>
                                    <option value=""30"">30</option>
                                    <option value=""50"">50</option>
                                    <option value=""100"">100</option>
                                </select>
                            </div>
                            <div class=""search d-flex"">
                                <input type=""text"" placeholder=""Nhập tiêu đề tìm kiếm "" class=""searchInput form-control"" style=""width:250px"" title=""Nhập tiêu đề tìm kiếm -> Nhấn Enter"">
                                <button class=""btn-green btn-tools text-nowrap btnAdd"">
                                    <i class=""fa fa-plus""></i> Thêm
                                </button>
                            </div>
                        </div>
                        <div class=""col-md-12 p-0"">
                            <div clas");
            WriteLiteral("s=\"table-view\">\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4 p-2\">\r\n                ");
#nullable restore
#line 75 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\CategoryNew\Index.cshtml"
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
            $('.btnAdd,.btnCancel').click(function () {
                RefreshForm();
                $('.text-danger').html('');
            })
            GetDataTable(pageSize, pageNumber, """");
            AddOrUpdate();
            SearchData();
            ChangePageSize();
            // define function
            function GetDataTable(pageSize, pageNumber, Search) {
                debugger
                let getViewData = new Object();
                getViewData[""pageNumber""] = pageNumber;
                getViewData[""pageSize""] = pageSize;
                getViewData[""Search""] = Search;
                console.log(getViewData);
                $.ajax({
                    url: '/Admin/CategoryNew/_TableView',
                    type: 'post',
                    dataType: 'html',
                    data: {
                        getViewData: getViewData
");
                WriteLiteral(@"                    },
                    success: function (res) {
                        $('.table-view').html('');
                        $('.table-view').append(res);
                    },
                    error: function (error) {
                    },
                    complete: function () {
                        RefreshForm();
                        SetObjectToForm();
                        DeleteById();
                        ChangePageNumber();
                        ViewDetail();
                        hrefListNew();
                    }
                })
            }
            function hrefListNew() {
                $('.btnHref').click(function () {
                    let Id = $(this).attr('data-id');
                    location.href = ""/Admin/New/Index/"" + Id;
                })
            }
            function RefreshForm() {
                $('.objInfor input:text').each(function (index, item) {
                    $(this).val('')
           ");
                WriteLiteral(@"     })
                $('.objInfor input[type=number]').each(function (index, item) {
                    $(this).val(0)
                })
            }
            //action
            function ViewDetail() {
                $('.btnDetail').click(function () {
                    let Id = $(this).attr('data-id');
                    $.ajax({
                        url: '/Admin/CategoryNew/_ViewDetail',
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
            funct");
                WriteLiteral(@"ion SetObjectToForm() {
                $('.btnEdit').click(function () {
                    let Id = $(this).attr('data-id');
                    $.ajax({
                        url: '/Admin/CategoryNew/_GetCategoryNewById',
                        type: 'post',
                        dataType: 'json',
                        data: {
                            Id: Id
                        },
                        success: function (res) {
                            console.log(res);
                            $.each(res, function (key, value) {
          
                                 if (key == ""status"") {
                                    if (value == true) {
                                        $('#s1').prop('checked', 1);
                                    }
                                    else {
                                        $('#s2').prop('checked', 1);
                                    }
                                }
                         ");
                WriteLiteral(@"       else {
                                    key = key.charAt(0).toUpperCase() + key.substring(1);
                                    $('.objInfor input[name=' + key + ']').val(value);
                                }

                            })
                        },
                        error: function (error) {

                        }
                    })
                })
            }

            function DeleteById() {
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
                                let btn ");
                WriteLiteral(@"= $(this);
                                $.ajax({
                                    url: '/Admin/CategoryNew/DeleteById',
                                    type: 'post',
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
              ");
                WriteLiteral(@"              };
                        });
                })
            }
            function AddOrUpdate() {
                $('.btnSave').click(function () {
                    if (CheckValidate()) {
                        let categoryNew = new Object();
                        $('.objInfor input').each(function (index, item) {
                            categoryNew[$(this).attr('name')] = $(this).val();
                        })
                        categoryNew[""Status""] = $('#s1').is(':checked') == 1 ? 1 : 0;
                        // submit data
                        $.ajax({
                            url: '/Admin/CategoryNew/_AddOrUpdate',
                            type: 'post',
                            dataType: 'json',
                            data: {
                                categoryNew: categoryNew
                            },
                            success: function (res) {
                                let msg = '';
                   ");
                WriteLiteral(@"             let msgf = '';
                                if ($('#Id').val() == 0) {
                                    msg = 'Đã thêm dữ liệu thành công !';
                                    msgf = 'Đã thêm dữ liệu thất bại !';
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
                            c");
                WriteLiteral(@"omplete: function () {
                                GetDataTable(pageSize, pageNumber, '');
                                RefreshForm();
                            }
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
                })
                return check == 0;
            }
            // change view data
            function SearchData() {
                $('.searchInput').keyup(function () {
                    let search = $(this).val(");
                WriteLiteral(@");
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
                    GetDataTable(pageSize, 1, search);
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

#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afe57d008256742bc2921686629d286c672ddc70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Customer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Customer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afe57d008256742bc2921686629d286c672ddc70", @"/Areas/Admin/Views/Customer/Index.cshtml")]
    public class Areas_Admin_Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Quản lý khách hàng";
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
                            <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                        </div>
                    </div>
                </div>
            </div>
            <!--Xem chi tiết -->
            <div class=""modal fade"" id=""Detail"" role=""dialog"">
                <div class=""modal-dialog modal-xl"">
                    <div clas");
            WriteLiteral(@"s=""modal-content"">
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
            WriteLiteral(@"                           <option value=""5"" selected>5</option>
                                    <option value=""15"">15</option>
                                    <option value=""30"">30</option>
                                    <option value=""50"">50</option>
                                    <option value=""100"">100</option>
                                </select>
                            </div>
                            <div class=""search d-flex"">
                                <input type=""text"" placeholder=""Nhập tiêu đề tìm kiếm "" class=""searchInput form-control"" style=""width:250px"" title=""Nhập tiêu đề tìm kiếm -> Nhấn Enter"">
                                <button class=""btn-green btn-tools text-nowrap btnAdd"">
                                    <i class=""fa fa-plus""></i> Thêm mới
                                </button>
                            </div>
                        </div>
                        <div class=""col-md-12 p-0"">
                            <div cl");
            WriteLiteral("ass=\"table-view\">\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4 p-2\">\r\n                ");
#nullable restore
#line 74 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Customer\Index.cshtml"
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
            OpenFolderImage();
            SearchData();
            ChangePageSize();
           
            // define function

            //function Link() {
            //    $('.btnHref').click(function () {
            //        location.href = '/Admin/CustomerRequire/Index/' + $(this).attr('data-id');
            //    })
            //}

            function GetDataTable(pageSize, pageNumber, Search) {
                let getViewData = new Object();
                getViewData[""pageNumber""] = pageNumber;
                getViewData[""pageSize""] = pageSize;
                getViewData[""Search""] = Search;
                con");
                WriteLiteral(@"sole.log(getViewData);
                $.ajax({
                    url: '/Admin/Customer/_TableView',
                    type: 'post',
                    dataType: 'html',
                    data: {
                        getViewData: getViewData
                    },
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
                    }
                })
            }

            function RefreshForm() {
                $('.objInfor input').each(function (index, item) {
                    $(this).val('')
                })
               ");
                WriteLiteral(@" $('.objInfor input[type=number]').each(function (index, item) {
                    $(this).val(0)
                })
                $('.objInfor select').each(function (index, item) {
                    $(this).val(0)
                })
                $('#image').val('/Upload/Image/no-image.jpg');
                $('#show-img').attr('src', '/Upload/Image/no-image.jpg');
            }

            //action
            function ViewDetail() {
                $('.btnDetail').click(function () {
                    let Id = $(this).attr('data-id');
                    $.ajax({
                        url: '/Admin/Customer/_ViewDetail',
                        type: 'post',
                        dataType: 'html',
                        data: {
                            Id: Id
                        },
                        success: function (res) {
                            $('#Detail  .modal-body').html('');
                            $('#Detail  .modal-body').append(res);
");
                WriteLiteral(@"                            $('#Detail').modal('show');
                        },
                        error: function (error) {

                        }
                    })
                })
            }
            function SetObjectToForm() {
                $('.btnEdit').click(function () {
                    let Id = $(this).attr('data-id');
                    $.ajax({
                        url: '/Admin/Customer/GetCustomerById',
                        type: 'post',
                        dataType: 'json',
                        data: {
                            Id: Id
                        },
                        success: function (res) {
                            $.each(res, function (key, value) {
                                console.log(res);
                                if (key == ""status"") {
                                    if (value == 1) {
                                        $('#s1').prop('checked', 1);
                              ");
                WriteLiteral(@"      }
                                    else {
                                        $('#s2').prop('checked', 1);
                                    }
                                }
                                else if (key == 'districtId') {
                                    $('select[name= DistrictId]').val(value);
                                    GetDistrict(value);
                                    GetProvince(value);
                                }
                                else {
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
            function GetDistrict(id) {
                $.ajax({
           ");
                WriteLiteral(@"         url: ""/Admin/Customer/GetDistrict"",
                    type: ""post"",
                    dataType: ""json"",
                    data: { id: id },
                    beforeSend: function () { },
                    success: function (res) {
                        console.log(res);
                        $(res).each(function (index, item) {
                            option = `<option value=""${item.id}"">${item.name}</option>`
                        })
                        $(""#DistrictId"").html('');
                        $(""#DistrictId"").append(option);
                    },
                    error: function () { },
                    complete: function () { }
                })
            };

            function GetProvince(districtId) {
                $.ajax({
                    url: ""/Admin/Customer/GetProvince"",
                    type: ""post"",
                    dataType: ""json"",
                    data: { districtId: districtId },
                    be");
                WriteLiteral(@"foreSend: function () { },
                    success: function (res) {
                        console.log(res);

                        $(res.provinces).each(function (index, item) {
                            option = `<option value=""${item.id}"">${item.name}</option>`
                        })
                        $(""#ProvinceId"").html('');
                        $(""#ProvinceId"").append(option);
                         if ($(""#ProvinceId"").click(function () {
                             GetListProvince();
                            

                        }));
                    },
                    error: function () { },
                    complete: function () { }
                })
            }
             function GetListProvince() {
                $.ajax({
                    url: ""/Admin/Customer/GetListProvince"",
                    type: ""post"",
                    dataType: ""json"",
                }).then((res) => {
                    console.log(type");
                WriteLiteral(@"of res);
                    var option = `<option value = ""0"" > --- Chọn Tỉnh------</option >`;
                    $(res).each(function (index, item) {
                        option += `<option value=""${item.id}"">${item.name}</option>`
                    })
                     $(""#ProvinceId"").append(option);
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
                                let btn = $(this);
                                $.ajax({
                     ");
                WriteLiteral(@"               url: '/Admin/Customer/DeleteById',
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
                            };
                        });
                })
           ");
                WriteLiteral(@" }

            function AddOrUpdate() {
                $('.btnSave').click(function () {
                    let customer = new Object();
                    $('.objInfor input[type=text],.objInfor input[type=email], .objInfor input[type=number],.objInfor input[type=hidden] , .objInfor input[type=date]').each(function (index, item) {
                        customer[$(this).attr('name')] = $(this).val();
                    })
                    $('.objInfor select').each(function (index, item) {
                        customer[$(this).attr('name')] = $(this).val();
                    })
                    customer[""Status""] = $('#s1').is(':checked') == 1 ? 1 : 0;
                    console.log(customer);
                    // submit data
                    if (CheckValidate()) {
                        $.ajax({
                            url: '/Admin/Customer/AddOrUpdate',
                            type: 'post',
                            dataType: 'json',
                    ");
                WriteLiteral(@"        data: {
                                customer: customer
                            },
                            success: function (res) {
                                let msg = '';
                                let msgf = '';
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
      ");
                WriteLiteral(@"                              t.show();
                                }
                            },
                            error: function (error) {
                            },

                            complete: function () {
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
                $('.objInfor input[type=text], .objInfor input[type=number], .objInfor input[type=hidden] , .objInfor input[type=date]').each(function () {
                    let value = $(this).val();
                    if (value == '') {
                        check++;
                        let title = $(this).siblings('label').text();
                        $(this).si");
                WriteLiteral(@"blings('.text-danger').append(title + ' không được để trống');
                    }
                    if ($(this).attr('name') == ""Image"" && $(this).val() == ""/Upload/Image/no-image.jpg"") {
                        let title = $(this).siblings('h6').text();
                        $(this).siblings('.text-danger').append(title + ' không được để trống');
                        check++;
                    }
                })
                $('.objInfor input[type=email]').each(function () {
                    let value = $(this).val();
                    if (value == '') {
                        check++;
                        let title = $(this).siblings('label').text();
                        $(this).siblings('.text-danger').append(title + ' không được để trống');
                    }
                    else {
                        let res = new RegExp(/([\w\.\-_]+)?\w+");
                WriteLiteral(@"@[\w-_]+(\.\w+){1,}/, 'igm').test(value);
                        if (!res) {
                            check++;
                            let title = $(this).siblings('label').text();
                            $(this).siblings('.text-danger').append(title + ' sai định dạng email');
                        }
                    }
                })
                return check == 0;
            }

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
                    GetDataTable(pageSize, pageNumber, search)");
                WriteLiteral(@";
                })
            }

            function ChangePageSize() {
                $('.pageSize').change(function () {
                    pageSize = $(this).val();
                    let search = $('.searchInput').val().trim();
                    GetDataTable(pageSize, 1, search);
                })
            }

            // choose image
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
                                $('#myModal').modal('show');
                                ChooseIma");
                WriteLiteral(@"ge();
                            }

                        }
                    });
                })
            }

            function ChooseImage() {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26920f8205b3b7e9b0619c51325889a53e08de5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26920f8205b3b7e9b0619c51325889a53e08de5a", @"/Areas/Admin/Views/Admin/Index.cshtml")]
    public class Areas_Admin_Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Admin\Index.cshtml"
  
    ViewBag.Title = "Quản lý người dùng" + ViewBag.Name;
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
                            <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Đóng</button>
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
            WriteLiteral(@"                          <option value=""5"" selected>5</option>
                                    <option value=""15"">15</option>
                                    <option value=""30"">30</option>
                                    <option value=""50"">50</option>
                                    <option value=""100"">100</option>
                                </select>
                            </div>
                            <div class=""search d-flex"">
                                <input type=""text"" placeholder=""Nhập tiêu đề tìm kiếm "" class=""searchInput form-control"" style=""width:250px"" title=""Nhập tiêu đề tìm kiếm "">
                                <button class=""btn-primary btn-tools text-nowrap btnAdd"">
                                    <i class=""fa fa-plus""></i> Thêm
                                </button>
                            </div>
                        </div>
                        <div class=""col-md-12 p-0"">
                            <div class=""table-view""");
            WriteLiteral(">\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4 p-2\">\r\n                ");
#nullable restore
#line 75 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Admin\Index.cshtml"
           Write(await Html.PartialAsync("_AddOrUpdate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
    $(document).ready(function () {
    var pageSize = 5;
        var pageNumber = 1;

        $('.btnAdd,.btnCancel').click(function () {
            RefreshForm();
            $('.text-danger').html('');
        })
        $('input[type=password]').keyup(function () {
            let val = $(this).val();
            $('input[name=Password]').val(val);
        })
        GetDataTable(pageSize, pageNumber, """");
        //ViewDetail();
        //DeleteByID();
        AddOrUpdate();
        OpenFolderImage();
        SearchData();
        //SetObjectToForm();
        //ChangePageNumber();
        ChangePageSize();

");
                WriteLiteral(@"    function GetDataTable(pageSize, pageNumber, Search) {
        debugger
        var getViewData = new Object();
        getViewData[""pageSize""] = pageSize;
        getViewData[""pageNumber""] = pageNumber;
        getViewData[""Search""] = Search;
        console.log(getViewData);
        $.ajax({
            url: '/Admin/Admin/_TableView',
            type: ""post"",
            dataType:'html',
            data: {
                getViewData : getViewData
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
                DeleteByID();
                SetObjectToForm();
                ChangePageNumber();
            }
        })

        };
        /**
        *
        * Resfresh lạ");
                WriteLiteral(@"i form thêm sửa dữ liệu
        */
        function RefreshForm() {
            $('.objInfor input').each(function (index, item) {
                $(this).val('');
            })
            $('.objInfor input[type=number]').each(function (index, item) {
                $(this).val(0);
            })
            $('#image').val('/Upload/Image/no-image.jpg');
            $('#show-img').attr('src', '/Upload/Image/no-image.jpg');
        }

        /***
         *Xem chi tiết sản phẩm
         * */
        function ViewDetail() {
            $('.btnDetail').click(function () {

                var Id = $(this).attr('data-id');
                console.log(Id);
                $.ajax({
                    url: ""/Admin/Admin/_GetViewDetail"",
                    type: ""post"",
                    dataType: ""html"",
                    data: { Id: Id },
                    success: function (res) {
                        $('#Detail .modal-body').html('');
                        $('#Detail ");
                WriteLiteral(@".modal-body').append(res);
                        $('#Detail').modal('show');
                    },
                    error: function (error) {

                    }
                })
            })
        };
        /**
         * Xóa
         * */
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
                            console.log(Id);
                            console.log(btn);
                            $.ajax({
                                url: '/Admin/Admin/DeleteById',
     ");
                WriteLiteral(@"                           type: 'post',
                                dataType: 'json',
                                data: {
                                    Id: Id
                                },
                                success: function (res) {
                                    if (res)
                                        btn.parent('li').parent('ul').parent('div').parent('div').parent('td').parent('tr').fadeOut();
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
        /**
        * Thêm mới và chỉnh sửa
        */
        function AddOrUpdate() {
");
                WriteLiteral(@"            $('.btnSave').click(function () {
                var admin = new Object();
                $('.objInfor input[type=text],.objInfor input[type=email],.objInfor input[type=number],.objInfor input[type=hidden],.objInfor input[type=date]').each(function (index, item) {
                    admin[$(this).attr('name')] = $(this).val();
                })
                admin[""Password""] = $('input[name=Password]').val();
                admin[""Status""] = $('#s1').is(':checked') == 1 ? 1 : 0;
                admin[""IsAdmin""] = $('#a1').is(':checked') == 1 ? 1 : 0;
                console.log(admin);
                if (CheckValidate()) {
                    $.ajax({
                        url: ""/Admin/Admin/AddOrEdit"",
                        type: ""post"",
                        dataType: ""json"",
                        data: {
                            admin: admin
                        },
                        success: function (res) {
                            var msg = ''");
                WriteLiteral(@";
                            var msgFail = '';
                            if ($('#Id').val() == 0) {
                                msg = ""Dữ liệu thêm thành công!"";
                                msgFail = ""Dữ liệu thêm không thành công!"";
                            }
                            else {
                                msg = ""Dữ liệu sửa thành công!"";
                                msgFail = ""Dữ liệu sửa không thành công!"";
                            }
                            if (res) {
                                var t = toastr.success(msg);
                                t.show();
                            }
                            else {
                                var t = toastr.error(msgFail);
                                t.show();
                            }
                        },
                        error: function (error) { },
                        complete: function () {
                            GetDataTable(pageSize, pa");
                WriteLiteral(@"geNumber, '');
                            RefreshForm();

                        }

                    })
                }
                })

        }
        function SetObjectToForm() {
            $('.btnEdit').click(function () {
                let Id = $(this).attr('data-id');
                $.ajax({
                    url: '/Admin/Admin/GetAdminById',
                    type: 'post',
                    dataType: 'json',
                    data: {
                        Id: Id
                    },
                    success: function (res) {
                        $.each(res, function (key, value) {
                            if (key == ""image"") {
                                $('.objInfor input[name=Image]').val(value);
                                $('#show-img').attr('src', value);
                            }
                            else if (key == ""status"") {
                                if (value == 1) {
                                    $");
                WriteLiteral(@"('#s1').prop('checked', 1);
                                }
                                else {
                                    $('#s2').prop('checked', 1);
                                }
                            }
                            else if (key == ""isAdmin"") {
                                if (value == 1) {
                                    $('#a1').prop('checked', 1);
                                }
                                else {
                                    $('#a2').prop('checked', 1);
                                }
                            }
                            else if (key == 'birthday') {
                                $('input[type=date]').val(value.slice(0, 10))
                            }
                            else if (key == 'password') {
                                $('.objInfor input[type=' + key + ']').val(value);
                                $('.objInfor input[name=Password]').val(value);
             ");
                WriteLiteral(@"               }
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

        /**
         * check validate form
         */
        function CheckValidate() {
            let check = 0;
            $('.text-danger').html('');
            $('.objInfor input[type=text], .objInfor input[type=number], .objInfor input[type=hidden] , .objInfor input[type=date]').each(function () {
                let value = $(this).val();
                if (value == '') {
                    check++;
                    let title = $(this).siblings('label').text();
                    $(this).siblings('.text-danger').append(title + ' không được để trống');
      ");
                WriteLiteral(@"          }
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
            $('.pageSize').change(function () {");
                WriteLiteral(@"
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
                            ChooseImage();
                        }

                    }
                });
            })
        }

        function ChooseImage() {
            $('#fileExploer').on('click', 'img', function () {
    ");
                WriteLiteral(@"            var fileUrl = '/Upload/Image/' + $(this).attr('title');
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
            WriteLiteral("\r\n\r\n\r\n");
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

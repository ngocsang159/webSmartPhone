#pragma checksum "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Shared\_LayoutLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fa6c4c0a4d18886d1ea21fe235040c4729bb289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__LayoutLogin), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_LayoutLogin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa6c4c0a4d18886d1ea21fe235040c4729bb289", @"/Areas/Admin/Views/Shared/_LayoutLogin.cshtml")]
    public class Areas_Admin_Views_Shared__LayoutLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/images/avatar/iconlogo1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image/x-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#eeee!important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fa6c4c0a4d18886d1ea21fe235040c4729bb2894737", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <title> | Đăng nhập </title>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0fa6c4c0a4d18886d1ea21fe235040c4729bb2895329", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" <!-- Favicon-->
    <!-- Bootstrap -->
    <link href=""/Admin/Content/bootstrap.min.css"" rel=""stylesheet"">

    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""/Admin/Content/plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- NProgress -->
    <!-- Animate.css -->
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""/Admin/Content/dist/css/animate.min.css"">
    <link href=""/Admin/Content/pnotify/dist/pnotify.css"" rel=""stylesheet"">
    <link href=""/Admin/Content/pnotify/dist/pnotify.buttons.css"" rel=""stylesheet"">
    <link href=""/Admin/Content/pnotify/dist/pnotify.nonblock.css"" rel=""stylesheet"">

    <!-- Custom Theme Style -->
    <link href=""/Admin/Content/custom.min.css"" rel=""stylesheet"">
    <link href=""/Admin/Content/login-form.css"" rel=""stylesheet"" />
    <link href=""/Admin/Content/dist/css/alerts.less"" rel=""stylesheet/less"" />

    <!-- Latest co");
                WriteLiteral(@"mpiled and minified CSS & JS -->
    <script src=""/Admin/Scripts/jquery-3.4.1.min.js""></script>
    <script src=""/Admin/Content/pnotify/dist/pnotify.js""></script>
    <script src=""/Admin/Content/pnotify/dist/pnotify.buttons.js""></script>
    <script src=""/Admin/Content/pnotify/dist/pnotify.nonblock.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fa6c4c0a4d18886d1ea21fe235040c4729bb2898723", async() => {
                WriteLiteral(@"


    <script>

        /**
         *Xử lý sự kiện đăng nhập
         * CreatedBY:Sanglx 01/04/2021
         */

        $(document).ready(function () {
           
            $(""#formLogin"").submit(function () {
                console.log(""adfdfd"");
                var formData = $(""#formLogin"").serialize();
                debugger
                $.ajax({
                    url: '/Admin/Admin/Login',
                    type: ""POST"",
                    data: formData,
                    beforeSend: function () {
                        //new PNotify({
                        //    title: ""Thông báo"",
                        //    text: 'Bắt đầu đăng nhập',
                        //    type: 'info',
                        //    hide: false,
                        //    styling: 'bootstrap3',
                        //    delay: 500,
                        //});
                    }
                }).done(function (result) {
                    PNotify.removeAll();");
                WriteLiteral(@"
                    if (result == true) {
                        window.location.href = '/Admin/Home/Index';
                    //    new PNotify({
                    //        title: ""Thông báo"",
                    //        text: ""Đăng nhập thành công!"",
                    //        type: 'success',
                    //        hide: false,
                    //        styling: 'bootstrap3'
                    //    });

                    //    new PNotify({
                    //        title: ""Thông báo"",
                    //        text: ""Đang chuyển hướng"",
                    //        type: 'info',
                    //        hide: false,
                    //        styling: 'bootstrap3'
                    //    });
                        //setTimeout(function () {
                        //    window.location.href = '/Admin/Home/Index';
                        //}, 1000);
                    }
                    else {

                        new PNotify({");
                WriteLiteral(@"
                            title: ""Thông báo"",
                            text: ""Đăng nhập không thành công!"",
                            type: 'error',
                            hide: false,
                            delay: 1000,
                            styling: 'bootstrap3',
                            
                        });

                    }
                }).fail(function () {
                    new PNotify({
                        title: ""Thông báo"",
                        text: ""Xảy ra lỗi khi xử lý đăng nhập"",
                        type: 'error',
                        hide: false,
                        styling: 'bootstrap3'
                    });
                }).always(function () {
                    console.log(""thành công"");
                });
                return false;
            });
        });

    </script>
    ");
#nullable restore
#line 120 "E:\DO_AN\Shop\SmartPhone.Web\Areas\Admin\Views\Shared\_LayoutLogin.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script>
        /**
      * Ản hiện mật khẩu
      * CreatedBY:Sanglx 01/04/2021
      * */
        var password = document.querySelector('#password');
        console.log(password);
        var eye = document.querySelector('#eye');
        console.log(eye);

        eye.onclick = function () {
            if (password.type === ""password"") {
                password.setAttribute(""type"", ""text"")
                eye.classList.remove('fa-eye-slash');
                eye.classList.add('fa-eye');
            }
            else {
                password.setAttribute(""type"", ""password"")
                eye.classList.add('fa-eye-slash');
            }
        }
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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

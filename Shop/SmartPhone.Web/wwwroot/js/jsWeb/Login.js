$(document).ready(function () {

    //đăng nhập tài khoản client
    $("#formLoginClient").submit(function () {
        console.log('adfdsf');
        var formData = $("#formLoginClient").serializeArray();
        console.log(formData);
        $.ajax({
            url: '/Author/Login',
            type: "POST",
            data: formData,
            beforeSend: function () {
                //new PNotify({
                //    title: "Thông báo",
                //    text: 'Bắt đầu đăng nhập',
                //    type: 'info',
                //    hide: false,
                //    styling: 'bootstrap3',
                //    delay: 500,
                //});
            }
        }).done(function (result) {
            PNotify.removeAll();
            if (result == true) {
                window.location.href = 'trang-chu';
                //    new PNotify({
                //        title: "Thông báo",
                //        text: "Đăng nhập thành công!",
                //        type: 'success',
                //        hide: false,
                //        styling: 'bootstrap3'
                //    });

                //    new PNotify({
                //        title: "Thông báo",
                //        text: "Đang chuyển hướng",
                //        type: 'info',
                //        hide: false,
                //        styling: 'bootstrap3'
                //    });
                //setTimeout(function () {
                //    window.location.href = '/Admin/Home/Index';
                //}, 1000);
            }
            else {

                new PNotify({
                    title: "Thông báo",
                    text: "Đăng nhập không thành công!",
                    type: 'error',
                    hide: false,
                    delay: 1000,
                    styling: 'bootstrap3',

                });

            }
        }).fail(function () {
            new PNotify({
                title: "Thông báo",
                text: "Xảy ra lỗi khi xử lý đăng nhập",
                type: 'error',
                hide: false,
                styling: 'bootstrap3'
            });
        }).always(function () {
            console.log("thành công");
        });
        return false;
    });
    $("#btnRegister").click(function () {
        var formRegister = $("#form-register-client").serializeArray();
        let objRegister = formRegister.reduce(function (o, val) { o[val.name] = val.value; return o }, {});
        $.ajax({
            url: "/Author/Register",
            data: { customer: objRegister},
            type: "post",
            dataType: 'json',
            success: function (res) {
                console.log(res);
                let msg = '';
                let msgf = '';
                if ($('#Id').val() == 0) {
                    msg = 'Đăng ký thành công !';
                    msgf = 'Email hoặc Số điện thoại đã tồn tại!';

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


        })
    })
});
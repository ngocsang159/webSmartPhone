/**
* sự kiện hiển thị tác vụ
* @param {any} obj
*/
function showBoxFunction(obj) {
    $('.setting-row').siblings().addClass('d-none');
    let data = $(obj);
    let res = data.attr('data-show-box');
    if (res == 0) {
        data.siblings().removeClass('d-none');
        data.attr('data-show-box', '1');
    }
    else {
        data.siblings().addClass('d-none');
        data.attr('data-show-box', '0');
    }
}
$(document).ready(function () {

    /**
     * sự kiện hiển thị tải ảnh lên
     * */
    $("#show_camera").click(function () {
        $(".box-camera").siblings('.display').addClass('d-none');
        var res = $(this).attr('data-show-camera');
        if (res == 0) {
            $(this).siblings('.display').removeClass('d-none');
            $(this).attr('data-show-camera', '1');
        }
        else {
            $('div').siblings('.display').addClass('d-none');
            /*    $(this).siblings('.display').addClass('d-none');*/
            $(this).attr('data-show-camera', '0');
        }
    })
    $("#fileUpload").change(function (event) {
        debugger
        var files = event.target.files;
        var filedata = new FormData();
        for (var i = 0; i < files.length; i++) {
            filedata.append([i].name, files[i]);
        }
        console.log(filedata);
        $.ajax({
            url: "/Admin/Home/ChangeAvatar",
            type: "post",
            contentType: false, // Not to set any content header  
            processData: false,
            data:  filedata,
                dataType:"json",
            success: function (res) {
                console.log(res);
                    $(".upload-img").attr('src', res);
                }, error: function (err) {
                    alert(err.statusText);
                }

            })
        })

})

//Thay đổi ảnh đại diện

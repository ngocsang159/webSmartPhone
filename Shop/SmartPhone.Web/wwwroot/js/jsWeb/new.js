$(document).ready(function () {
    //binding dữ liệu product theo productCategory
    let idNew = $("#listNewFor").attr("data-idnew");
    if (idNew >= 0) {
        $.ajax({
            url: location.origin + "/New/GetListNew",
            dataType: "html",
            data: { Id: idNew, Order: 1, pageNumber: 1 },
            type: "post",
            success: function (data, textStatus, XMLHttpRequest) {
                $('#divListNew').html('');
                $('#divListNew').append(data);

                pagedListNew();


            },

        });
    }
})
    $(function () {
        $("#listNewFor").change(function () {
            debugger
            var order = $("#listNewFor").val();
            console.log(order);
            var idNew = $("#listNewFor").attr("data-idnew");
            $.ajax({
                url: location.origin + "/New/GetListNew",
                dataType: "html",
                data: { Id: idNew, pageNumber: 1, orderBy: order },
                type: "post",
                success: function (data, textStatus, XMLHttpRequest) {
                    $('#divListNew').html('');
                    $('#divListNew').append(data);

                    pagedListNew();
                },
            })
        })
    })
function pagedListNew() {
    var pageCount = $(".list-category-new").attr('data-pagecount');
    console.log(pageCount);
    var displayPage = 5;
    var marginPage = (displayPage - 1) / 2;
    console.log(marginPage);
    var pageNumber = $('.list-category-new').attr('data-pagenumber');
    console.log(pageNumber);
    var startPage = 0;
    var endPage = 0;
    if (pageCount <= displayPage) {
        startPage = 1;
        endPage = pageCount;
    }
    else {
        if (Number(pageNumber) - marginPage <= 0) {
            startPage = 1;
            endPage = displayPage;
        }
        else {
            if (Number(pageCount) - Number(pageNumber) < marginPage) {
                startPage = Number(pageCount) - displayPage + 1;
                endPage = pageCount;
            }
            else {
                startPage = Number(pageNumber) - marginPage;
                endPage = Number(pageNumber) + marginPage;
            }
        }
    }
    var preIndex = Number(pageNumber) - 1;
    var nextIndex = Number(pageNumber) + 1;

    var preDisable = "";
    var nextDisable = "";
    if (pageNumber == 1) {
        if (pageNumber == pageCount) {
            preDisable = 'd-none';
            nextDisable = 'd-none';
        }
        else {
            preDisable = "d-none";
        }
    }
    else if (pageNumber == pageCount) {
        nextDisable = "d-none";
    }

    let row = ` <li> <a href="javascript:void(0)" class="Previous ${preDisable}" onclick ="getPageNewNumber(${preIndex})"><i class="fa fa-chevron-left"></i></a>
                                    </li>`;

    for (var i = startPage; i <= endPage; i++) {
        if (pageNumber == i) {
            row += ` <li class="active"><a  href="javascript:void(0)" onclick="getPageNewNumber(${i})">${i}</a></li>`
        }
        else {
            row += ` <li class=""><a href="javascript:void(0)" onclick="getPageNewNumber(${i})">${i}</a></li>`
        }
    }
    row += `<li> <a href="javascript:void(0)" class="Previous ${nextDisable}" onclick="getPageNewNumber(${nextIndex})"><i class="fa fa-chevron-right"></i></a>
                                    </li>`;
    $(".li-pagination-box").html('');
    $(".li-pagination-box").append(row);
}
function getPageNewNumber(pageNumber) {
    var IdNew = $("#listNewFor").attr("data-idnew");
    console.log(IdNew);
    var order = $("#listNewFor").val();


    $.ajax({
        url: "/New/GetListNew",
        data: { Id: IdNew, Order: order, pageNumber: pageNumber },
        dataType: "html",
        type: "post",
        success: function (data) {
            $("#divListNew").html('');
            $("#divListNew").append(data);
            pagedListNew();
        }
    })

}





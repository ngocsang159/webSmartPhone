var getUrlParameter = function getUrlParameter(sParam) {
    var sPageURL = window.location.search.substring(1),
        sURLVariables = sPageURL.split('&'),
        sParameterName,
        i;
    for (i = 0; i < sURLVariables.length; i++) {
        sParameterName = sURLVariables[i].split('=');
        if (sParameterName[0] === sParam) {
            return typeof sParameterName[1] == undefined ? true : decodeURIComponent(sParameterName[1]);
        }
    }
    return false;

}
$(document).ready(function () {
    //thay đổi select
    $("#selectTitle").change(function () {
        var valTitle = $("#selectTitle").val();
        if (valTitle == 1) {
            $('.newCate').addClass('d-none');
            $('.productCate').removeClass('d-none');
            $('#divProductSearch').removeClass('d-none');
            $('#divNewSearch').addClass('d-none');
            pageProductSearch();
        }
        else if (valTitle == 2) {
            $('.newCate').removeClass('d-none');
            $('.productCate').addClass('d-none');
            $('#divProductSearch').addClass('d-none');
            $('#divNewSearch').removeClass('d-none');
            pageNewSearch();
        }
    });
    //tìm kiếm
    $("#btnSearch").on('click', function () {
        var search = $("#searchProduct").val();
        let url = "/Search/Index?search=" + search;
        $.ajax({
            url: "/Search/Index",
            dataType: "html",
            data: {},
            type: "post",
            success: function (data) {
                window.location.href = url;
            }
        })
    });

    var searchValue = getUrlParameter('search');
    $.ajax({
        url: "/Search/SearchByProduct",
        dataType: "html",
        data: { cate_id: 0, OrderBy: 1, pageNumber: 1, search: searchValue },
        type: "Post",
        success: function (data) {
            $("#divProductSearch").html('');
            $("#divProductSearch").append(data);
            if (searchValue == false) {
                $("#searchProduct").val("");
            }
            else {
                $("#searchProduct").val(searchValue);
            }
            $("#selectTitle").val("1").attr("selected");
            $("#search-value").html(searchValue);
            if ($("#selectTitle").val() == 1) {
                pageProductSearch();
            }
            else if (($("#selectTitle").val() == 2)) {
                pageNewSearch();
            }


        }
    });
    $.ajax({
        url: "/Search/SearchByNew",
        dataType: "html",
        data: { cate_id: 0, OrderBy: 1, pageNumber: 1, search: searchValue },
        type: "post",
        success: function (data) {
            $("#divNewSearch").html('');
            $("#divNewSearch").append(data);
            if (searchValue == false) {
                $("#searchProduct").val("");

            }
            else {
                $("#searchProduct").val(searchValue);
            }
            $("#search-value").html(searchValue);
            if ($("#selectTitle").val() == 1) {
                pageProductSearch();
            } else if (($("#selectTitle").val() == 2)) {
                pageNewSearch();
            }
        }
    });


});

$(function () {

    $("#selectCateProduct").change(function () {
        var cateId = $("#selectCateProduct").val();

        var searchValue = getUrlParameter('search');
        console.log(searchValue);
        var selectTitle = $("#selectTitle").val();
        console.log(selectTitle);

        if (selectTitle == 1) {
            var sortSelect = $("#selectSortProduct").val();
            $.ajax({
                url: "/Search/SearchByProduct",
                data: { cate_id: cateId, OrderBy: sortSelect, pageNumber: 1, search: searchValue },
                type: "post",
                dataType: "html",
                success: function (data) {
                    console.log(data);
                    $("#divProductSearch").html('');
                    $("#divProductSearch").append(data);
                    pageProductSearch();
                }
            })
        }
    });
    $("#selectSortProduct").change(function () {
        var cateId = $("#selectCateProduct").val();
        console.log(cateId);
        var order = $("#selectSortProduct").val();
        console.log(order);
        var searchValue = getUrlParameter('search');
        console.log(searchValue);
        $.ajax({
            url: "/Search/SearchByProduct",
            data: { cate_id: cateId, OrderBy: order, pageNumber: 1, search: searchValue },
            type: "post",
            dataType: "html",
            success: function (data) {
                $("#divProductSearch").html('');
                $("#divProductSearch").html(data);
                pageProductSearch();
            }
        })
    });
    //
    $("#selectCateNew").change(function () {
        var newId = $("#selectCateNew").val();
        var searchValue = getUrlParameter('search');
        var selectTitle = $("#selectTitle").val();
        if (selectTitle == 2) {
            var sortSelect = $("#selectSortProduct").val();
            $.ajax({
                url: "/Search/SearchByNew",
                dataType: "html",
                type: "post",
                data: { cate_id: newId, OrderBy: sortSelect, pageNumber: 1, search: searchValue },
                success: function (data) {
                    $("#divNewSearch").html('');
                    $("#divNewSearch").html(data);
                    pageNewSearch();
                }
            })
        }
    });
    //
    $("#selectSortNew").change(function () {
        var newId = $("#selectCateNew").val();
        var orderBy = $("#selectSortNew").val();
        var searchValue = getUrlParameter('search');
        $.ajax({
            url: "/Search/SearchByNew",
            type: "post",
            data: { cate_id: newId, OrderBy: orderBy, pageNumber: 1, search: searchValue },
            dataType: "html",
            success: function (data) {
                $("#divNewSearch").html('');
                $("#divNewSearch").html(data);
                pageNewSearch();
            }
        })

    });
})
//function searchProd(e) {
//    if (e.keyCode) {
//        var search = $("#searchProduct").val();
//        let url = location.origin + "/Search/Index?search=" + search;
//        $.ajax({
//            url: "/Search/Index",
//            dataType: "html",
//            data: {},
//            type: "post",
//            success: function (data, textStatus, XMLHttpRequest) {
//                window.location.href = url;
//            }
//        });
//    }

//}

/*Phân trang*/
// productSearch
function pageProductSearch() {
    let pageCount = $('#searchProductByCate').attr('data-pagecount');
    let displayPage = 5;
    let marginPage = (displayPage - 1) / 2;
    let pageNumber = $("#searchProductByCate").attr('data-pagenumber');
    let startPage = 0;
    let endPage = 0;

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
    let preIndex = Number(pageNumber) - 1;
    let nextIndex = Number(pageNumber) + 1;

    let preDisable = "";
    let nextDisable = "";
    if (pageNumber == 1) {
        if (pageNumber == pageCount) {
            preDisable = "d-none";
            nextDisable = "d-none";
        }
        else {
            preDisable = "d-none";
        }
    }
    else if (pageNumber == pageCount) {
        nextDisable = "d-none";
    }

    let row = ` <li> <a href="javascript:void(0)" class="Previous ${preDisable}" onclick ="getPageNumberSearchProduct(${preIndex})"><i class="fa fa-chevron-left"></i></a>
                                    </li>`;

    for (var i = startPage; i <= endPage; i++) {
        if (pageNumber == i) {
            row += ` <li class="active"><a  href="javascript:void(0)" onclick="getPageNumberSearchProduct(${i})">${i}</a></li>`
        }
        else {
            row += ` <li class=""><a href="javascript:void(0)" onclick="getPageNumberSearchProduct(${i})">${i}</a></li>`
        }
    }
    row += `<li> <a href="javascript:void(0)" class="Previous ${nextDisable}" onclick="getPageNumberSearchProduct(${nextIndex})"><i class="fa fa-chevron-right"></i></a>
                                    </li>`;
    $(".pagination-box").html('');
    $(".pagination-box").append(row);
}
function getPageNumberSearchProduct(pageNumber) {
    var cateId = $("#selectCateProduct").val();
    var order = $("#selectSortProduct").val();
    var searchValue = getUrlParameter('search');
    $.ajax({
        url: "/Search/SearchByProduct",
        data: { cate_id: cateId, OrderBy: order, pageNumber: pageNumber, search: searchValue },
        type: "post",
        success: function (data) {
            $('#divProductSearch').html('');
            $('#divProductSearch').append(data);

            pageProductSearch();
        }
    })

}

//NewSearch
function pageNewSearch() {
    let pageCount = $('#searchNewByCate').attr('data-pagecount');
    let displayPage = 5;
    let marginPage = (displayPage - 1) / 2;
    let pageNumber = $("#searchNewByCate").attr('data-pagenumber');
    let startPage = 0;
    let endPage = 0;

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
    let preIndex = Number(pageNumber) - 1;
    let nextIndex = Number(pageNumber) + 1;

    let preDisable = "";
    let nextDisable = "";
    if (pageNumber == 1) {
        if (pageNumber == pageCount) {
            preDisable = "d-none";
            nextDisable = "d-none";
        }
        else {
            preDisable = "d-none";
        }
    }
    else if (pageNumber == pageCount) {
        nextDisable = "d-none";
    }

    let row = ` <li> <a href="javascript:void(0)" class="Previous ${preDisable}" onclick ="getPageNumberSearchProduct(${preIndex})"><i class="fa fa-chevron-left"></i></a>
                                    </li>`;

    for (var i = startPage; i <= endPage; i++) {
        if (pageNumber == i) {
            row += ` <li class="active"><a  href="javascript:void(0)" onclick="getPageNumberSearchNew(${i})">${i}</a></li>`
        }
        else {
            row += ` <li class=""><a href="javascript:void(0)" onclick="getPageNumberSearchNew(${i})">${i}</a></li>`
        }
    }
    row += `<li> <a href="javascript:void(0)" class="Previous ${nextDisable}" onclick="getPageNumberSearchNew(${nextIndex})"><i class="fa fa-chevron-right"></i></a>
                                    </li>`;
    $(".pagination-box").html('');
    $(".pagination-box").append(row);
}
function getPageNumberSearchNew(pageNumber) {
    debugger
    var cateId = $("#selectCateNew").val();
    var order = $("#selectSortNew").val();
    console.log(order);
    var searchValue = getUrlParameter('search');
    $.ajax({
        url: "/Search/SearchByNew",
        data: { cate_id: cateId, OrderBy: order, pageNumber: pageNumber, search: searchValue },
        type: "post",
        success: function (data) {
            $('#divNewSearch').html('');
            $('#divNewSearch').append(data);

            pageNewSearch();
        }
    })

}

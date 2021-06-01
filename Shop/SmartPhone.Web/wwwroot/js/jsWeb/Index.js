
$(document).ready(function () {
    //binding dữ liệu product theo productCategory
    let idCategory = $("#listProdFor").attr("data-idcate");
    if (idCategory >= 0) {
        $.ajax({
            url: location.origin + "/Product/GetListProductByCate",
            dataType: "html",
            data: { cate_id: idCategory, pageNumber: 1, orderBy: 1 },
            type: "post",
            success: function (data, textStatus, XMLHttpRequest) {
                $('#productCategory').html('');
                $('#productCategory').append(data);
                pagedList();
            },

        });
    }
    let idCateAcc = $("#listProdAcc").attr("data-idcate");
    if (idCateAcc >= 0) {
        $.ajax({
            url: location.origin + "/Product/GetListProductByCateAcc",
            dataType: "html",
            data: { cate_id: idCategory, pageNumber: 1, orderBy: 1 },
            type: "post",
            success: function (data, textStatus, XMLHttpRequest) {
                $('#productCategory').html('');
                $('#productCategory').append(data);
                pagedListAcc();
            },

        });
    }
    $(".quick-view-btn").click(function (e) {
        e.preventDefault();
        $.ajax({
            url: "/quick-view/" + $(this).data('id'),
            type: 'GET',
        }).then(res => {

            const { detailProduct, Img, color } = res;
            console.log(res);
            $(".product-details-id").html("");
            $(".product-details-id").append(`  <input type="hidden" name="Id" id="Id" value="${detailProduct.Id}" />
                <input type="hidden" name="Image" id="Image" value="${detailProduct.Image}" />`)
            $("#product-image-view").html("");
            Img.forEach(n => {

            })
            $("#thumbs-imgae-view").html("");
            for (var i = 0; i < Img.length; i++) {

                $("#product-image-view").append(`
                                            <div class="lg-image" >
                                        <img src="${Img[i].Image}" alt="${Img[i].Name}" style="width:100%">
                                        </div>`)
                if (i == 1) {
                    break;
                }


            }
            /*Img.forEach(n => {*/

            if (!detailProduct) {
                $('.product-details-view-content').hide();
                return;
            }
            //chèn tên sản phẩm
            $(".product-info-view h2").text(detailProduct.Name);
            //chèn tình trạng sản phẩm
            if (detailProduct.Status == 1) {
                $(".product-details-ref").html('');
                $(".product-details-ref").append(`Tình trạng: <b style="color: #009981; font-size: 16px;">Còn hàng</b>`);
            }
            else {
                $(".product-details-ref").html('');
                $(".product-details-ref").append(`Tình trạng:  <b style="color: #c6011a;font-size: 16px;">Hết hàng</b>`);
            }
           
            //chèn giá sản phẩm
            $('.price-view').html('');
            if (detailProduct.PriceSale == 0) {
                $(".price-view").append(`<span class="new-price new-price-2" data-price="${detailProduct.Price}">
                                ${formatNumber(detailProduct.Price)}₫
                            </span>`)
            }
            else {
                $(".price-view").append(`<span class="new-price new-price-2" id="price"
data-price="${detailProduct.PriceSale}">
                                ${formatNumber(detailProduct.PriceSale)}₫
                            </span>
                            <span class="old-price">
                               ${formatNumber(detailProduct.Price)}₫
                            </span>`)

            }
            //chèn thông tin sản phẩm
            let d = document.createElement('div');
            d.innerHTML = detailProduct.Description;
            $(".product-desc .product-desciption").text(d.innerText);
            $(".produt-variants-color").html('');
            color.forEach(n => {
                $(".produt-variants-color").append(`<div class="color-item color ${n.Name} " data-color="${n.Name}" data-colorId = ${n.Id} style="background-color:${n.Name}"></div>`)
            })

            //chọn màu sắc
            var active = $('.color-item').get();
            console.log(active);
            for (var i = 0; i < active.length; i++) {
                active[i].onclick = function () {
                    if ($(this) == "selectedColor") {
                        $(this).removeClass('selectedColor');
                    }
                    else {
                        for (var j = 0; j < active.length; j++) {
                            active[j].classList.remove('selectedColor');
                        }
                        this.classList.toggle('selectedColor');
                    }
                }
            }
            $("#exampleModalCenter").modal("show");
        })
    })




    //$(".increase_pop").click(function () {
    //    let res = $(this).siblings("#qtyItem7823812").attr('value');
    //    console.log(res);
    //    res++;
    //    $(this).siblings("#qtyItem7823812").attr('value', res);
    //    $(".reduced_pop").removeClass('d-none');

    //});

    //    $(".reduced_pop").click(function () {
    //        let res = $(this).siblings("#qtyItem7823812").attr('value');
    //        console.log(res);
    //        res--;
    //        $(this).siblings("#qtyItem7823812").attr('value', res);
    //        if (res == 0) {
    //            $(".reduced_pop").addClass('d-none');
    //        }
    //    });
    //    $(".items-count").click(function () {
    //        let getElement = $(this).siblings("#qtyItem7823812");
    //        //var a = $(this).siblings("#qtyItem7823812").attr('data-id');
    //        //console.log(a);
    //        //var b = $(this).siblings("#qtyItem7823812").attr('value');
    //        //console.log(b);
    //        $.ajax({
    //            url: "/Cart/UpdateCart",
    //            data: {
    //                product: {
    //                    Id: $(this).siblings("#qtyItem7823812").data('id')
    //                },
    //                Quantity: $(this).siblings("#qtyItem7823812").attr('value')
    //            },
    //            dataType: 'json',
    //            type: 'POST'
    //        }).then(function (res) {
    //            //console.log(JSON.parse(res));
    //            console.log(res);

    //            //cập nhật lại giá


    //            let priceElement = getElement.parents('.a-center').siblings('.a-center').children('.item-price').find('.price');
    //            console.log(priceElement);


    //            let priceUpdate = getElement.parents('.a-center').siblings('.a-center').children('.cart-price').find('.price');
    //            console.log(priceUpdate);


    //            let newPrice = getElement.val() * parseFloat(priceElement.text().replace(/,/g, ''));
    //            priceUpdate.text(formatNumber(newPrice));
    //            let totalorder = 0;

    //            var lstProduct = $(".bg-scroll > .cart-tbody>.item-cart>.a-center>.cart-price>.item-price>.price");
    //            console.log(lstProduct);
    //            $.each(lstProduct, function (i, item) {
    //                totalorder = totalorder + parseFloat(item.innerText.replace(/,/g, ''));
    //                console.log(parseFloat(item.innerText.replace(/,/g, '')));
    //            })
    //            $("#totalPrice").text(formatNumber(totalorder));



    //        })

    //    })
});
$(function () {
    $("#listProdFor").change(function () {
        debugger
        var order = $("#listProdFor").val();
        console.log(order);
        var idCategory = $("#listProdFor").attr("data-idcate");
        $.ajax({
            url: location.origin + "/Product/GetListProductByCate",
            dataType: "html",
            data: { cate_id: idCategory, pageNumber: 1, orderBy: order },
            type: "post",
            success: function (data, textStatus, XMLHttpRequest) {
                $('#productCategory').html('');
                $('#productCategory').append(data);
                pagedList();
            },
        })
    });
    $("#productAll").change(function () {
        var idCategory = $("#productAll").val();
        var order = $("#listProdFor").val();
        $.ajax({
            url: location.origin + "/Product/GetListProductByCate",
            dataType: "html",
            data: { cate_id: idCategory, pageNumber: 1, orderBy: order },
            type: "post",
            success: function (data, textStatus, XMLHttpRequest) {
                $('#productCategory').html('');
                $('#productCategory').append(data);
                pagedList();
            },
        })
    });
})
function formatNumber(num) {
    return num.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,')
}
//$('.quantity').on('change', function () {
//    debugger
//    var getElement = $(this);
//    $.ajax({
//        url: "/Cart/UpdateCart",
//        data: {
//            product: {
//                Id: $(this).data('id')
//            },
//            Quantity: $(this).val()
//        },
//        dataType: 'html',
//        type: 'POST'
//    }).then(function (res) {
//        console.log(res);
//    })
//})






















function pagedList() {
    let pageCount = $('.list-category').attr('data-pagecount');
    let displayPage = 5;
    let marginPage = (displayPage - 1) / 2;
    let pageNumber = $('.list-category').attr('data-pagenumber');
    let startpage = 0;
    let endpage = 0;


    if (pageCount <= displayPage) {
        startpage = 1;
        endpage = pageCount;
    }
    else {
        if (Number(pageNumber) - marginPage <= 0) {
            startpage = 1;
            endpage = displayPage;
        }
        else {
            if (Number(pageCount) - Number(pageNumber) < marginPage) {
                startpage = Number(pageCount) - displayPage + 1;
                endpage = pageCount;
            }
            else {
                startpage = Number(pageNumber) - marginPage;
                endpage = Number(pageNumber) + marginPage;
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

    let row = ` <li> <a href="javascript:void(0)" class="Previous ${preDisable}" onclick ="getPageNumberProduct(${preIndex})"><i class="fa fa-chevron-left"></i></a>
                                    </li>`;

    for (var i = startpage; i <= endpage; i++) {
        if (pageNumber == i) {
            row += ` <li class="active"><a  href="javascript:void(0)" onclick="getPageNumberProduct(${i})">${i}</a></li>`
        }
        else {
            row += ` <li class=""><a href="javascript:void(0)" onclick="getPageNumberProduct(${i})">${i}</a></li>`
        }
    }
    row += `<li> <a href="javascript:void(0)" class="Previous ${nextDisable}" onclick="getPageNumberProduct(${nextIndex})"><i class="fa fa-chevron-right"></i></a>
                                    </li>`;
    $(".pagination-box").html('');
    $(".pagination-box").append(row);
}


function getPageNumberProduct(pageNumber) {
    /*    var cateId = $(".").val();*/
    debugger;
    var order = $("#listProdFor").val();
    console.log(order);
    let idCategory = $("#listProdFor").attr("data-idcate");
    console.log(idCategory);
    $.ajax({
        url: "/Product/GetListProductByCate",
        dataType: "html",
        data: { cate_id: idCategory, orderBy: order, pageNumber: pageNumber },
        type: "post",
        success: function (data, textStatus, XMLHttpRequest) {
            $('#productCategory').html('');
            $('#productCategory').append(data);

            pagedList();


        },

    });

}
function pagedListAcc() {
    debugger
    let pageCount = $('.list-category').attr('data-pagecount');
    let displayPage = 5;
    let marginPage = (displayPage - 1) / 2;
    let pageNumber = $('.list-category').attr('data-pagenumber');
    let startpage = 0;
    let endpage = 0;


    if (pageCount <= displayPage) {
        startpage = 1;
        endpage = pageCount;
    }
    else {
        if (Number(pageNumber) - marginPage <= 0) {
            startpage = 1;
            endpage = displayPage;
        }
        else {
            if (Number(pageCount) - Number(pageNumber) < marginPage) {
                startpage = Number(pageCount) - displayPage + 1;
                endpage = pageCount;
            }
            else {
                startpage = Number(pageNumber) - marginPage;
                endpage = Number(pageNumber) + marginPage;
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

    let row = ` <li> <a href="javascript:void(0)" class="Previous ${preDisable}" onclick ="getPageNumberAccc(${preIndex})"><i class="fa fa-chevron-left"></i></a>
                                    </li>`;

    for (var i = startpage; i <= endpage; i++) {
        if (pageNumber == i) {
            row += ` <li class="active"><a  href="javascript:void(0)" onclick="getPageNumberAccc(${i})">${i}</a></li>`
        }
        else {
            row += ` <li class=""><a href="javascript:void(0)" onclick="getPageNumberAccc(${i})">${i}</a></li>`
        }
    }
    row += `<li> <a href="javascript:void(0)" class="Previous ${nextDisable}" onclick="getPageNumberAccc(${nextIndex})"><i class="fa fa-chevron-right"></i></a>
                                    </li>`;
    $(".pagination-box").html('');
    $(".pagination-box").append(row);
}

function getPageNumberAccc(pageNumber) {
    /*    var cateId = $(".").val();*/
    debugger;
    var order = $("#listProdAcc").val();
    console.log(order);
    let idCategory = $("#listProdAcc").attr("data-idcate");
    console.log(idCategory);
    $.ajax({
        url: "/Product/GetListProductByCateAcc",
        dataType: "html",
        data: { cate_id: idCategory, orderBy: order, pageNumber: pageNumber },
        type: "post",
        success: function (data, textStatus, XMLHttpRequest) {
            $('#productCategory').html('');
            $('#productCategory').append(data);

            pagedListAcc();


        },

    });

}

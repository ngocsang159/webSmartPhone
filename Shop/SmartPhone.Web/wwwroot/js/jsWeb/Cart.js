$(document).ready(function () {
    let cartStr = localStorage.getItem("Cart");
    if (cartStr == null)
        cartStr = JSON.stringify([]);
    let cartJson = JSON.parse(cartStr);

   
});

function AddCart(link) {
    // order detail
    // img, name,price,size,color,

    let cartStr = localStorage.getItem("Cart");
    if (cartStr == null)
        cartStr = JSON.stringify([]);
    let cartJson = JSON.parse(cartStr);

    let productId = $('#Id').val(); // ther input co id = Id
    let img = $('#Image').val(); // ther input co id = Image
    let productName = $('.product-name').text();
    let price = $('.new-price').attr('data-price');
    let color = $('.selectedColor').attr('data-colorid');
    let colorName = $('.selectedColor').attr('data-color');
    let stock = 1;
    let obj = {
        id: cartJson.length,
        img: img,
        productName: productName,
        price: price,
        color: color,
        colorName: colorName,
        productId: productId,
        stock: stock,
    };
    if (color == undefined) {
        toastr.error("Bạn chưa chọn màu sắc!", { positionClass: "toast-top-right" })
        return;
    }
    else {
        let check = cartJson.filter(x => x.productId == obj.productId && x.color == color).length > 0;
        if (!check) {
            cartJson.push(obj);
            localStorage.setItem("Cart", JSON.stringify(cartJson));
            toastr.success("Đã thêm sản phẩm vào giỏ hàng!", { positionClass: "toast-top-right" })
            $('.cart-item-count').text(cartJson.length);
            let total = $('.hm-minicart-trigger .total-price').attr('data-price');
            total = total - (-1 * price);//cộng tổng sổ
            $('.hm-minicart-trigger .total-price').text(formatNumber(total) + ` ₫`)
            $('.hm-minicart-trigger .total-price').attr('data-price', total);
            let part = `<li>
                        <a href="/" class="minicart-product-image">
                            <img src="${img}" alt="cart products">
                        </a>
                        <div class="minicart-product-details">
                            <h6><a href="single-product.html">${productName}</a></h6>
                            <span>${formatNumber(price)} ₫ x 1</span>
                        </div>
                        <button onclick(this,${obj.id}) class="close">
                            <i class="fa fa-close"></i>
                        </button>
                    </li>`;
            $('.minicart-product-list').append(part);
            $('.minicart-total').html('');
            $('.minicart-total').append(`Tổng tiền <span>${formatNumber(total)} ₫</span>`);
            if (link)
                location.href ="/dat-hang"
        }
        else {
            toastr.warning("Sản phẩm đã có trong giỏ hàng!", { positionClass: "toast-top-right" })
        }
    }
}

function ShowCart() {
    let cartStr = localStorage.getItem("Cart");
    if (cartStr == null)
        cartStr = JSON.stringify([]);
    let cartJson = JSON.parse(cartStr);
    if (cartJson.length > 0)
    {
        let totalPrice = 0;
        $('.list-cart').html('');
        let row = `<div class="col-main cart_desktop_page cart-page">
        <div class="cart page_cart hidden-xs">
            <form action="" method="POST">
                <div class="bg-scroll">
                    <div class="cart-thead" id="cart-update">
                        <div style="width: 15%;" class="a-center">Ảnh sản phẩm</div>
                        <div style="width: 28%;" class="a-center">Tên sản phẩm</div>
                        <div style="width:7%" class="a-center">Màu sắc</div>
                        <div style="width: 17%;" class="a-center">Đơn giá</div>
                        <div style="width: 14%;" class="a-center">Số lượng</div>
                        <div style="width: 14%;" class="a-center">Tổng tiền</div>
                        <div style="width: 5%;" class="a-center">Xóa</div>
                    </div>`;
        $(cartJson).each(function (i, e) {
            totalPrice += e.stock * e.price;
            row += ` <div class="cart-tbody" data-id=${e.id}>
                            <div class="item-cart product">
                                <div style="width: 15%;" class="image">
                                    <a href="" class="product-image">
                                        <img src="${e.img}" alt="">
                                    </a>
                                </div>

                                <div style="width: 28%;" class="a-center">
                                    <h3 class="product-name"><a href="">${e.productName}</a></h3>
                                </div>
                                <div style="width: 7%;" class="a-center">
                                    <div class="color-item color " data-color="${e.colorName}" data-colorid="${e.color}" style="background-color:${e.colorName}"></div>
                                </div>
                                <div style="width: 17%;" class="a-center p-def">
                                        <span class="item-price">
                                            <span class="price" data-price-default="${e.price}">${formatNumber(e.price)} đ</span>
                                        </span>
                                </div>
                                <div style="width: 14%;" class="a-center">
                                    <div class="input_qty_pr">
                                        <input type="text" maxlength="12" min="0" class="check_number_here input-text number-sidebar input_pop input_pop qtyItem7823812 quanty" id="qtyItem7823812" name="Stock" size="4" data-id="${e.productId}" value="${e.stock}">
                                        <button onclick="SubStockDetail(this,${e.price})" class="reduced_pop  items-count btn-plus" type="button">-</button>
                                        <button onclick="AddStockDetail(this,${e.price})" class="increase_pop items-count btn-plus" type="button">+</button>
                                    </div>
                                </div>
                                <div style="width: 14%;" class="a-center price-pro">
                                    <span class="cart-price">
                                            <span class="item-price">
                                                <span class="price " data-price="${e.stock * e.price}">${formatNumber(e.stock * e.price)} ₫</span>
                                            </span>
                                    </span>
                                </div>
                                <div style="width: 5%;" class="a-center">
                                    <a onclick="RemoveCart2(this,${e.id})" class="remove" title="Xóa">
                                        <span><i class="fa fa-trash-o" aria-hidden="true"></i></span>
                                    </a>
                                </div>
                            </div>
                        </div>`;
        })
        row += `  </div>
                    </form>
                    <div class="row margin-top-25 margin-bottom-40">
                        <div class="col-lg-7 col-md-7">
                            <div>
                                <a href="/" class="form-cart-continue" title="Tiếp tục mua hàng">Tiếp tục mua hàng </a>
                            </div>
                        </div>
                        <div class="col-lg-5 col-md-5 bg_cart sshopping-cart">
                            <div class="total">
                                <p class="text-total">Tổng số tiền thanh toán :</p>
                                <span class="price" id="totalPrice" data-sum="${totalPrice}">${formatNumber(totalPrice)} ₫</span>
                            </div>
                            <a href="/dat-hang/thanh-toan" class="btn-checkout-cart" title="Tiến hành thanh toán">
                                Tiến hành thanh toán
                            </a>
                        </div>
                    </div>
                </div>
            </div>`;
        $('.list-cart').append(row);
    }
}
function AddCart1() {
    // order detail
    // img, name,price,size,color,
    debugger
    let cartStr = localStorage.getItem("Cart");
    if (cartStr == null)
        cartStr = JSON.stringify([]);
    let cartJson = JSON.parse(cartStr);

    let productId = $('#Id').val(); // ther input co id = Id
    let img = $('#Image').val(); // ther input co id = Image
    let productName = $('.product-name').text();
    let price = $('#price').attr('data-price');
    let color = $('.selectedColor').attr('data-colorid');
    let colorName = $('.selectedColor').attr('data-color');
    let stock = 1;
    let obj = {
        id: cartJson.length,
        img: img,
        productName: productName,
        price: price,
        color: color,
        colorName: colorName,
        productId: productId,
        stock: stock,
    };
    if (color == undefined) {
        toastr.error("Bạn chưa chọn màu sắc!", { positionClass: "toast-top-right" })
        return;
    }
    else {
        let check = cartJson.filter(x => x.productId == obj.productId && x.color == color).length > 0;
        if (!check) {
            cartJson.push(obj);
            localStorage.setItem("Cart", JSON.stringify(cartJson));
            toastr.success("Đã thêm sản phẩm vào giỏ hàng!", { positionClass: "toast-top-right" })
            $('.cart-item-count').text(cartJson.length);
            let total = $('.hm-minicart-trigger .total-price').attr('data-price');
            total = total - (-1 * price);
            $('.hm-minicart-trigger .total-price').text(formatNumber(total) + ` ₫`)
            $('.hm-minicart-trigger .total-price').attr('data-price', total);
            let part = `<li>
                        <a href="/" class="minicart-product-image">
                            <img src="${img}" alt="cart products">
                        </a>
                        <div class="minicart-product-details">
                            <h6><a href="single-product.html">${productName}</a></h6>
                            <span>${formatNumber(price)} ₫ x 1</span>
                        </div>
                        <button onclick(this,${obj.id}) class="close">
                            <i class="fa fa-close"></i>
                        </button>
                    </li>`;
            $('.minicart-product-list').append(part);
            $('.minicart-total').html('');
            $('.minicart-total').append(`Tổng tiền <span>${formatNumber(total)} ₫</span>`);
        }
        else {
            toastr.warning("Sản phẩm đã có trong giỏ hàng!", { positionClass: "toast-top-right" })
        }
    }
}
function SubStockDetail(el, price) {
    let stock = $(el).siblings('input').val();
    if (parseInt(stock) > 1) {
        stock--;
        $(el).siblings('input').val(stock);

        // cập nhật giá
        let elprice = $(el).parent().parent().siblings('.price-pro').children().children().children();
        let productPrice = $(elprice).attr('data-price') - (price);
        $(elprice).html('');
        $(elprice).append(formatNumber(productPrice) + ` ₫`);
        $(elprice).attr('data-price', productPrice);

        let total = $('#totalPrice').attr('data-sum');
        total = parseInt(total) - parseInt(price);
        $('#totalPrice').attr('data-sum', total);
        $('#totalPrice').html('');
        $('#totalPrice').append(formatNumber(total) + ` ₫`);

        // set lại cart
        let cartStr = localStorage.getItem("Cart");
        if (cartStr == null)
            cartStr = JSON.stringify([]);
        let cartJson = JSON.parse(cartStr);

        let id = $(el).parent().parent().parent().parent().attr('data-id');
        let obj = cartJson.filter(x => x.id == id)[0];
        obj.stock = stock;
        localStorage.setItem("Cart", JSON.stringify(cartJson))
        $('.minicart-total').html('');
        $('.minicart-total').append(`Tổng tiền <span>${formatNumber(total)} ₫</span>`);
        $('.cart-item-count').text(cartJson.length);
        $('.hm-minicart-trigger .total-price').text(formatNumber(total) + ` ₫`)
        $('.hm-minicart-trigger .total-price').attr('data-price', total);
        $('.minicart-product-list > li').each(function (i, e) {
            if ($(e).attr('data-id') == id) {
                $(e).children('div.minicart-product-details').children('span').text(`${formatNumber(obj.price)} ₫ x ${stock}`)
            }
        })
    }
    else {
        toastr.error("Bạn cần chọn số lượng sản phẩm lớn hơn 0", { positionClass: "toast-top-right" });
    }
}

function AddStockDetail(el, price) {
    let stock = $(el).siblings('input').val();
    stock++;
    $(el).siblings('input').val(stock);

    // cập nhật giá
    let elprice = $(el).parent().parent().siblings('.price-pro').children().children().children();
    let productPrice = $(elprice).attr('data-price') - (-1 * price);
    $(elprice).html('');
    $(elprice).append(formatNumber(productPrice) + ` ₫`);
    $(elprice).attr('data-price', productPrice);

    let total = $('#totalPrice').attr('data-sum');
    total = parseInt(total) + parseInt(price);
    $('#totalPrice').attr('data-sum', total);
    $('#totalPrice').html('');
    $('#totalPrice').append(formatNumber(total) + ` ₫`);

    // set lại cart
    let cartStr = localStorage.getItem("Cart");
    if (cartStr == null)
        cartStr = JSON.stringify([]);
    let cartJson = JSON.parse(cartStr);

    let id = $(el).parent().parent().parent().parent().attr('data-id');
    let obj = cartJson.filter(x => x.id == id)[0];
    obj.stock = stock;
    localStorage.setItem("Cart", JSON.stringify(cartJson))

    // mini cart
    $('.minicart-total').html('');
    $('.minicart-total').append(`Tổng tiền <span>${formatNumber(total)} ₫</span>`);
    $('.cart-item-count').text(cartJson.length);
    $('.hm-minicart-trigger .total-price').text(formatNumber(total) + ` ₫`)
    $('.hm-minicart-trigger .total-price').attr('data-price', total);

    $('.minicart-product-list > li').each(function (i, e) {
        if ($(e).attr('data-id') == id) {
            $(e).children('div.minicart-product-details').children('span').text(`${formatNumber(obj.price)} ₫ x ${stock}`)
        }
    })
}

function RemoveCart(el, index) {
    let cartStr = localStorage.getItem("Cart");
    if (cartStr == null)
        cartStr = JSON.stringify([]);
    let cartJson = JSON.parse(cartStr);
    $(el).parent().remove();
    let obj = cartJson.filter(x => x.id == index)[0];
    cartJson = cartJson.filter(x => x.id != index);
    localStorage.setItem("Cart", JSON.stringify(cartJson));

    $('.cart-item-count').text(cartJson.length);
    let total = $('.hm-minicart-trigger .total-price').attr('data-price');
    total = total - (obj.price * obj.stock);
    $('.hm-minicart-trigger .total-price').text(formatNumber(total) + ` ₫`)
    $('.hm-minicart-trigger .total-price').attr('data-price', total);
    $('.minicart-total').html('');
    $('.minicart-total').append(`Tổng tiền <span>${formatNumber(total)} ₫</span>`);
    if (cartJson.length == 0) {
        let row = ` <div class="order-wrap">
                            <div class="row">
                                <div class="col-md-8 table-cart-wrapper">
                                    <div class="cart_img">
                                        <img src="/css/images/icon/cart1.png" />
                                    </div>
                                    <div class="cart_infor">
                                        <div class="cart_txt">
                                            <p>
                                                Hiện chưa có sản phẩm nào trong giỏ hàng, mời bạn tiếp tục tham quan và lựa chọn sản phẩm ứng ý.
                                            </p>
                                        </div>
                                        <div class="cart_txt1">
                                            <p>Phần còn lại chúng tôi sẽ giúp bạn!</p>
                                        </div>
                                    </div>
                                </div>
            
                            </div>
                        </div>`;
        $('.list-cart').html('');
        $('.list-cart').append(row);
    }
}

function RemoveCart2(el, index) {
    let cartStr = localStorage.getItem("Cart");
    if (cartStr == null)
        cartStr = JSON.stringify([]);
    let cartJson = JSON.parse(cartStr);
    $(el).parent().parent().parent().remove();
    let obj = cartJson.filter(x => x.id == index)[0];
    cartJson = cartJson.filter(x => x.id != index);
    localStorage.setItem("Cart", JSON.stringify(cartJson));

    //let total = obj.stock * obj.price
    // obj laf dooi tuong can xoa (so luong, gia )
    $('.cart-item-count').text(cartJson.length);
    let total = $('.hm-minicart-trigger .total-price').attr('data-price');
    total = total - (obj.price * obj.stock);
    $('.hm-minicart-trigger .total-price').text(formatNumber(total) + ` ₫`)
    $('.hm-minicart-trigger .total-price').attr('data-price', total);
    $('#totalPrice').html('');
    $('#totalPrice').append(`Tổng tiền <span>${formatNumber(total)} ₫</span>`);

    $('.minicart-total').html('');
    $('.minicart-total').append(`Tổng tiền <span>${formatNumber(total)} ₫</span>`);

    // xoas
    $('.minicart-product-list > li').each(function (i, e) {
        if ($(e).attr('data-id') == index) {
            $(e).remove();
        }
    })
    if (cartJson.length == 0) {
        let row = ` <div class="order-wrap">
                            <div class="row">
                                <div class="col-md-8 table-cart-wrapper">
                                    <div class="cart_img">
                                        <img src="/css/images/icon/cart1.png" />
                                    </div>
                                    <div class="cart_infor">
                                        <div class="cart_txt">
                                            <p>
                                                Hiện chưa có sản phẩm nào trong giỏ hàng, mời bạn tiếp tục tham quan và lựa chọn sản phẩm ứng ý.
                                            </p>
                                        </div>
                                        <div class="cart_txt1">
                                            <p>Phần còn lại chúng tôi sẽ giúp bạn!</p>
                                        </div>
                                    </div>
                                </div>
            
                            </div>
                        </div>`;
        $('.list-cart').html('');
        $('.list-cart').append(row);
    }
}


function formatNumber(num) {
    return num.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,')
}
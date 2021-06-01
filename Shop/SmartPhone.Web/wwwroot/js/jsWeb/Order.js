$(document).ready(function () {
    let cartStr = localStorage.getItem("Cart");
    if (cartStr == null)
        cartStr = JSON.stringify([]);
    let cartJson = JSON.parse(cartStr);
    $('.product-table tbody').html('');
    let total = 0;
    $(cartJson).each(function (i, e) {
        total += e.stock * e.price;
        let row = ` <tr class="product">
                                            <td class="product__image">
                                                <div class="product-thumbnail">
                                                    <div class="product-thumbnail__wrapper" data-tg-static="">

                                                        <img src="${e.img}" alt="" class="product-thumbnail__image">

                                                    </div>
                                                    <span class="product-thumbnail__quantity">${e.stock}</span>
                                                </div>
                                            </td>
                                            <th class="product__description">
                                                <span class="product__description__name">
                                                    ${e.productName}
                                                </span>
                                            </th>
                                            <td class="product__price">
                                                    ${formatNumber(e.price * e.stock)} ₫
                                            </td>
                                        </tr>`;
        $('.product-table tbody').append(row);
    })

    $('.total-line--subtotal .total-line__price').text(formatNumber(total) + ` ₫`);
    $('.payment-due .total-line__price').html('');
    $('.payment-due .total-line__price').append(`<span class="payment-due__price">${formatNumber(total)} ₫</span>`);

 })
$('#checkout-payment').click(function ()  {
    if (CheckValidate()) {
        let formArray = $('form.form-input').serializeArray();
        var order = {};
        jQuery.map(formArray, function (n, i) {
            order[n.name] = n.value;
        });
        order["AdminId"] = 0;
        order["CustomerId"] = 0;
        let orderDetails = [];
        let cartStr = localStorage.getItem("Cart");
        if (cartStr == null)
            cartStr = JSON.stringify([]);
        let cartJson = JSON.parse(cartStr);
        $(cartJson).each(function (i, e) {
            let obj = {
                Id: 0,
                OrderId: 0,
                ProductId: e.productId,
                ColorId: e.color,
                Quantity: e.stock,
                Price: e.price
            };
            orderDetails.push(obj);
        })

        $.ajax({
            url: '/Cart/Order',
            dataType: 'json',
            type: 'post',
            data: {
                order: order,
                orderDetails: orderDetails
            },
            success: function (res) {
                if (res) {
                    toastr.success("Đặt hàng thành công !", { positionClass: "toast-top-right",timeOut:1000 })
                    window.location.href = "/dat-hang-thanh-cong";
                    window.localStorage.clear();
                }
                else
                    toastr.error("Đặt hàng không thành công !", { positionClass: "toast-top-right" })
            }
        })
    }
})
function formatNumber(num) {
    return num.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,')
}
function CheckValidate() {
    let check = 0;
    $('.form-message').html('');
    $('.field__input-wrapper input[type=text],.field__input-wrapper input[type=number]').each(function () {
        let value = $(this).val();
        console.log(value);
        if (value == '') {
            check++;
            var title = $(this).siblings('label').text();
            console.log(title);
            $(this).siblings('.form-message').append(title + ' không được để trống!');
            $(this).addClass('input-danger');
        }
        else {
            $(this).removeClass('input-danger');
        }
    })
    $('.field__input-wrapper input[type=email]').each(function () {
        let value = $(this).val();
        console.log(value);
        if (value == '') {
            check++;
            var title = $(this).siblings('label').text();
            console.log(title);
            $(this).siblings('.form-message').append(title + ' không được để trống!');
            $(this).addClass('input-danger');
        } else if (value != '') {
            let res = new RegExp(/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/).test(value);
            if (!res) {
                check++;
                var title = $(this).siblings('label').text();
                $(this).siblings('.form-message').append(title + ' sai định dạng!');
                $(this).addClass('input-danger');
            }
        }
        else {
            $(this).removeClass('input-danger');
        }


    })
    return check == 0;
}
    //$('#checkout-payment').click(function () {
    //    debugger
    //    if (checkvalidate()) {
    //        let obj = new object();
    //        $('.form-input input,.form-input select').each(function (i, e) {
    //            let name = $(e).attr('name');
    //            let value = $(e).val();
    //            obj[name] = value;
    //        })
    //        console.log(obj);
    //        $.ajax({
    //            url: '/cart/order',
    //            type: 'post',
    //            datatype: 'json',
    //            data: {
    //                obj: obj
    //            },
    //            success: function (res) {
    //                if (res) {
    //                    alert("đặt hàng thành công !!");
    //                    location.href = '/dat-hang-thanh-cong'
    //                }
    //                else {
    //                    location.href = '/dang-nhap-tai-khoan'
    //                }
    //            }
    //        })
    //    }
    //    })
      

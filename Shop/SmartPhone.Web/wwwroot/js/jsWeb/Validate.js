function Validator(options) {

    var selectorRules = {};
    //Hàm thực thi validate

    function validate(inputElement, rule) {
        var errorMessage;
        var errorElement = inputElement.parentElement.querySelector(options.errorSelector);

        //lấy rules của selector
        var rules = selectorRules[rule.selector];

        for (var i = 0; i < rules.length; i++) {
            errorMessage = rules[i](inputElement.value);
            if (errorMessage) {
                break;
            }
        }
        if (errorMessage) {
            errorElement.innerText = errorMessage;
            inputElement.parentElement.classList.add('invalid');
        }
        else {
            errorElement.innerText = '';
            inputElement.parentElement.classList.remove('invalid');
        }

    }
    var form_element = document.querySelector(options.form);
    if (form_element) {
        var btnRegister = document.querySelector("#btnRegister");
        btnRegister.onclick = function (e) {
            e.preventDefault();

            options.rules.forEach(function (rule) {
                var inputElement = form_element.querySelector(rule.selector);
                validate(inputElement, rule);
            });
        }
        options.rules.forEach(function (rule) {

            //lưu lại các rules
            if (Array.isArray(selectorRules[rule.selector])) {
                selectorRules[rule.selector].push(rule.test);
            }
            else {
                selectorRules[rule.selector] = [rule.test];
            }

            var inputElement = form_element.querySelector(rule.selector);
            // console.log(inputElement);

            if (inputElement) {
                //xử lý trường hợp blur khỏi input
                inputElement.onblur = function () {
                    // console.log('blur' + rule.selector);
                    //value:inputElement.value
                    //test func : rule.test;
                    validate(inputElement, rule);

                }
                //xử lý mỗi khi người dùng nhập vào input
                inputElement.oninput = function () {
                    var errorElement = inputElement.parentElement.querySelector(options.errorSelector);
                    errorElement.innerText = '';
                    inputElement.parentElement.classList.remove('invalid');
                }

            }


        });
        //console.log(selectorRules);
    }
}
//định nghĩa các rules
//nguyên tắc của các rules:
//1. khi có lỗi => trả ra message lỗi
//2 . khi hợp lệ => trả về undefined
Validator.isRequired = function (selector, message) {
    return {
        selector: selector,
        test: function (value) {
            return value.trim() ? undefined : message || 'Vui lòng nhập trường này!';
        },
    };
}
Validator.isUser = function (selector, message) {
    return {
        selector: selector,
        test: function (value) {
            var regex = /^(?=[a-zA-Z0-9._]{3,20}$)(?!.*[_.]{2})[^_.].*[^_.]$/;
            return regex.test(value) ? undefined : message || 'Tên đăng nhập từ 3-20 không chứa các ký tự đặc biệt';
        }
    }
}
Validator.isFullName = function (selector, message) {
    return {
        selector: selector,
        test: function (value) {
            var regex = /^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂẾưăạảấầẩẫậắằẳẵặẹẻẽềềểếỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s\W|_]{2,40}$/;
            return regex.test(value) ? undefined : message || 'Họ và tên từ 2-40 ký tự, không chứa các ký tự đặc biệt';
        }
    }
}
Validator.isEmail = function (selector, message) {
    return {
        selector: selector,
        test: function (value) {
            var regex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
            return regex.test(value) ? undefined : message || 'Email không đúng định dạng';

        }
    };
};
Validator.isPhone = function (selector, message) {
    return {
        selector: selector,
        test: function (value) {
            var regex = /^\+?([0-9]{2})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$/;
            return regex.test(value) ? undefined : message || 'Số điện thoại không đúng định dạng';
        }
    }
}
Validator.isPass = function (selector, message) {
    return {
        selector: selector,
        test: function (value) {
            var regex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,16}$/;
            return regex.test(value) ? undefined : message || 'Mật khẩu từ 4-16 ký tự bao gồm chữ hoa, chữ thường và ít nhất 1 chữ số ';
        }
    }
}
Validator.isRe_pass = function (selector, getConfirmPass, message) {
    return {
        selector: selector,
        test: function (value) {
            return value === getConfirmPass() ? undefined : message || 'Giá trị nhập vào không chính xác';
        }
    }

}
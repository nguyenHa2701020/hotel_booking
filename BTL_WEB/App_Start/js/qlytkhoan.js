const email = document.getElementById('dchiemail');
const pass = document.getElementById('mkhau');
const sdt = document.getElementById('sdthoai');
const user = document.getElementById('hten');
email.onblur = function () {
    var aIndex = email.value.indexOf('@');
    if (email.value.trim() == "") {
        document.getElementById('tbaoemail').innerHTML = "Email không được để trống!";
    } else if (aIndex == -1) {
        document.getElementById('tbaoemail').innerHTML = "Email không hợp lệ!";
    } else if (email.value.indexOf('.') < aIndex || email.value.indexOf('.') == -1) {
        document.getElementById('tbaoemail').innerHTML = "Dấu @ phải đứng sau dấu .!";
    } else {
        document.getElementById('tbaoemail').innerHTML = "";
        return true;
    }
    return false;
}

pass.onblur = function () {
    var format = /[ `!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?~]/;
    if (pass.value.trim() == "") {
        document.getElementById('tbaomkhau').innerHTML = "Mật khẩu không được để trống!";
    } else if (pass.value.length < 8) {
        document.getElementById('tbaomkhau').innerHTML = "Mật khẩu tối thiểu 8 ký tự!";
    } else if (format.test(pass.value)) {
        document.getElementById('tbaomkhau').innerHTML = "Mật khẩu không chứa ký tự đặc biệt!";
    } else {
        document.getElementById('tbaomkhau').innerHTML = "";
        return true;
    }
    return false;
}


// funtion bên đăng ký

sdt.onblur = function () {
    if (sdt.value.trim() == "") {
        document.getElementById('tbaosdt').innerHTML = "Số điện thoại không được để trống";
    }
    else if (isNaN(sdt.value)) {
        document.getElementById('tbaosdt').innerHTML = "Số điện thoại phải là số";
    } else if (sdt.value.length < 10 || sdt.value.length > 12) {
        document.getElementById('tbaosdt').innerHTML = "Số điện thoại từ 10 - 12";
    } else if (sdt.value[0] != '0') {
        document.getElementById('tbaosdt').innerHTML = "Phải có số không ở đầu";
    } else {
        document.getElementById('tbaosdt').innerHTML = "";
        return true;
    }
    return false;
}
user.onblur = function () {
    if (user.value.trim() == "") {
        document.getElementById('tbaohten').innerHTML = "Họ và tên không được để trống";
    }
    else if (!isNaN(user.value)) {
        document.getElementById('tbaohten').innerHTML = "Họ và tên không được là số!";
    } else {
        document.getElementById('tbaohten').innerHTML = "";
        return true;
    }
    return false;
}




function checkMail() {
    var aIndex = email.value.indexOf('@');
    if (email.value.trim() == "") {
        document.getElementById('tbaoemail').innerHTML = "Email không được để trống!";
    } else if (aIndex == -1) {
        document.getElementById('tbaoemail').innerHTML = "Email không hợp lệ!";
    } else if (email.value.indexOf('.') < aIndex || email.value.indexOf('.') == -1) {
        document.getElementById('tbaoemail').innerHTML = "Dấu @ phải đứng sau dấu .!";
    } else {
        document.getElementById('tbaoemail').innerHTML = "";
        return true;
    }
    return false;

}

function checkPassword() {
    var format = /[ `!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?~]/;
    if (pass.value.trim() == "") {
        document.getElementById('tbaomkhau').innerHTML = "Mật khẩu không được để trống!";
    } else if (pass.value.length < 8) {
        document.getElementById('tbaomkhau').innerHTML = "Mật khẩu tối thiểu 8 ký tự!";
    } else if (format.test(pass.value)) {
        document.getElementById('tbaomkhau').innerHTML = "Mật khẩu không chứa ký tự đặc biệt!";
    } else {
        document.getElementById('tbaomkhau').innerHTML = "";
        return true;
    }
    return false;
}

function checkSDT() {
    if (sdt.value.trim() == "") {
        document.getElementById('tbaosdt').innerHTML = "Số điện thoại không được để trống";
    }
    else if (isNaN(sdt.value)) {
        document.getElementById('tbaosdt').innerHTML = "Số điện thoại phải là số";
    } else if (sdt.value.length < 10 || sdt.value.length > 12) {
        document.getElementById('tbaosdt').innerHTML = "Số điện thoại từ 10 - 12";
    } else if (sdt.value[0] != '0') {
        document.getElementById('tbaosdt').innerHTML = "Phải có số không ở đầu";
    } else {
        document.getElementById('tbaosdt').innerHTML = "";
        return true;
    }
    return false;
}

function checkTen() {
    if (user.value.trim() == "") {
        document.getElementById('tbaohten').innerHTML = "Họ và tên không được để trống";
    }
    else if (!isNaN(user.value)) {
        document.getElementById('tbaohten').innerHTML = "Họ và tên không được là số!";
    } else {
        document.getElementById('tbaohten').innerHTML = "";
        return true;
    }
    return false;
}

function checkData() {
    checkMail();
    checkPassword();
    checkSDT();
    checkTen();
    return checkMail() && checkPassword() && checkSDT() && checkTen();
}

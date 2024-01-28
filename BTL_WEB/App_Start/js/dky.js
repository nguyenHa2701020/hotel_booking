const email = document.getElementById("email");//tham chiếu tới id bên file html
const pass = document.getElementById("mkhau");
const sdt = document.getElementById("sdthoai");
const user = document.getElementById("hten");
const passcf = document.getElementById("cfmkhau");
window.onload = () => {//khi trang web đc load lên 
    const nonesearch = document.querySelector('.timkiem');//tham chiếu đến div tìm kiếm dể chỉnh css
    const valueheading = document.getElementById("f1");
    if (valueheading.innerHTML.trim() == "Đăng nhập" || valueheading.innerHTML.trim() == "Đăng ký thành viên") {//nếu có đăng nhập và đăng kí thì nút tìm kiếm mất đi
        nonesearch.style.display = "none"
    }
}


function checkMail() {
    var aIndex = email.value.indexOf('@');//kiểm tra kí tự @
    if (email.value.trim() == "") {//hàm trim bỏ dấu cách đầu và dấu cách cuối
        document.getElementById('tbaoemail').innerHTML = "Email không được để trống!";
    } else if (aIndex == -1) {//nếu ko có @
        document.getElementById('tbaoemail').innerHTML = "Email không hợp lệ!";
    } else if (email.value.indexOf('.') < aIndex || email.value.indexOf('.') == -1) {
        document.getElementById('tbaoemail').innerHTML = "Dấu @ phải đứng trước dấu .!";
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
// check trùng mật khẩu
function checkPasswordConfirm() {
    var format = /[ `!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?~]/;
    if (passcf.value.trim() == "") {
        document.getElementById('tbaocfmkhau').innerHTML = "Mật khẩu không được để trống!";
    } else if (passcf.value.length < 8) {
        document.getElementById('tbaocfmkhau').innerHTML = "Mật khẩu tối thiểu 8 ký tự!";
    } else if (format.test(passcf.value)) {
        document.getElementById('tbaocfmkhau').innerHTML = "Mật khẩu không chứa ký tự đặc biệt!";
    } else if (passcf.value.trim() != pass.value.trim()) {
        document.getElementById('tbaocfmkhau').innerHTML = "Mật khẩu nhập lại không trùng khớp!";
    }
    else {
        document.getElementById('tbaocfmkhau').innerHTML = "";
        return true;
    }
    return false;
    
}

//check tổng tất cả
function checkData() {

    if (btnSubmit.value == "Đăng nhập") {
        checkMail();
        checkPassword();
        return checkMail() && checkPassword();
    }
    else {
        checkMail();
        checkPassword();
        checkSDT();
        checkTen();
        checkPasswordConfirm();
        return checkMail() && checkPassword() && checkSDT() && checkTen() && checkPasswordConfirm();
    }
}

// onsubmit
const btnSubmit = document.getElementById("bt");


// blur(khi nhả chuột ra ngoài thì kiểm tra và thông báo)
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
    var filter = /[A-Z]/;
    var dbfilter = /[@\$\&\#\%]/;
    var nb = /[0-9]/;
    if (pass.value.trim() == "") {
        document.getElementById('tbaomkhau').innerHTML = "Mật khẩu không được để trống!";
    } else if (pass.value.length < 8) {
        document.getElementById('tbaomkhau').innerHTML = "Mật khẩu tối thiểu 8 ký tự!";
    }
    else {
        document.getElementById('tbaomkhau').innerHTML = "";
        return true;
    }
    return false;
}

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

passcf.onblur = function () {
    var format = /[ `!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?~]/;
    if (passcf.value.trim() == "") {
        document.getElementById('tbaocfmkhau').innerHTML = "Mật khẩu không được để trống!";
    } else if (passcf.value.length < 8) {
        document.getElementById('tbaocfmkhau').innerHTML = "Mật khẩu tối thiểu 8 ký tự!";
    } else if (format.test(passcf.value)) {
        document.getElementById('tbaocfmkhau').innerHTML = "Mật khẩu không chứa ký tự đặc biệt!";
    } else if (passcf.value.trim() != pass.value.trim()) {
        document.getElementById('tbaocfmkhau').innerHTML = "Mật khẩu nhập lại không trùng khớp!";
    }
    else {
        document.getElementById('tbaocfmkhau').innerHTML = "";
        return true;
    }
    return false;
}

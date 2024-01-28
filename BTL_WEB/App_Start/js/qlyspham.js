const lphong = document.getElementById('lphong');
const ctiet = document.getElementById('ctiet');
const gia = document.getElementById('gia');
const files = document.getElementById('file');

lphong.onblur = function () {
    var format = /[`!@#$%^&*()_+\=\[\]{};':"\\|,.<>\/?~]/;
    if (lphong.value.trim() == "") {
        document.getElementById('tbaop').innerHTML = "Loại phòng không được để trống!";
    } else if (format.test(lphong.value)) {
        document.getElementById('tbaop').innerHTML = "Loại phòng không chứa ký tự đặc biệt!";
    } else {
        document.getElementById('tbaop').innerHTML = "";
        return true;
    }
    return false;
}
ctiet.onblur = function () {
    if (ctiet.value.trim() == "") {
        document.getElementById('tbaoct').innerHTML = "Chi tiết Không được để trống";
    }
    else {
        document.getElementById('tbaoct').innerHTML = "";
        return true;
    }
    return false;
}

gia.onblur = function () {
    var format = /[`!@#$%^&*()_+\=\[\]{};':"\\|,.<>\/?~]/;
    if (gia.value.trim() == "") {
        document.getElementById('tbaogia').innerHTML = "Giá phòng không được để trống";
    }
    else if (isNaN(gia.value)) {
        document.getElementById('tbaogia').innerHTML = "Giá phòng phải là số";
    } else if (format.test(gia.value)) {
        document.getElementById('tbaogia').innerHTML = "Giá phòng không chứ ký tự đặc biệt";
    }
    else {
        document.getElementById('tbaogia').innerHTML = "";
        return true;
    }
    return false;
}


function checkPhong() {

    var format = /[`!@#$%^&*()_+\=\[\]{};':"\\|,.<>\/?~]/;
    if (lphong.value.trim() == "") {
        document.getElementById('tbaop').innerHTML = "Loại phòng không được để trống!";
    } else if (format.test(lphong.value)) {
        document.getElementById('tbaop').innerHTML = "Loại phòng không chứa ký tự đặc biệt!";
    } else {
        document.getElementById('tbaop').innerHTML = "";
        return true;
    }
    return false;

}

function checkChiTiet() {
    if (ctiet.value.trim() == "") {
        document.getElementById('tbaoct').innerHTML = "Chi tiết Không được để trống";
    }
    else {
        document.getElementById('tbaoct').innerHTML = "";
        return true;
    }
    return false;
}

function checkGia() {
    var format = /[`!@#$%^&*()_+\=\[\]{};':"\\|,.<>\/?~]/;
    if (gia.value.trim() == "") {
        document.getElementById('tbaogia').innerHTML = "Giá phòng không được để trống";
    }
    else if (isNaN(gia.value)) {
        document.getElementById('tbaogia').innerHTML = "Giá phòng phải là số";
    } else if (format.test(gia.value)) {
        document.getElementById('tbaogia').innerHTML = "Giá phòng không chứ ký tự đặc biệt";
    }
    else {
        document.getElementById('tbaogia').innerHTML = "";
        return true;
    }
    return false;
}

function checkData() {
    checkPhong();
    checkChiTiet();
    checkGia();
    return checkPhong() && checkChiTiet() && checkGia();
}

function Xoa(id) {
    var result = confirm("Bạn muốn xóa sản phẩm này không");
    if (result) {
        var url = "qlysanpham.aspx?idDelete=" + id;

        window.location = url;
    }
}

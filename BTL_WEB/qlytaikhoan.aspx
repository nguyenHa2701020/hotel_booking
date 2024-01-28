<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qlytaikhoan.aspx.cs" Inherits="BTL_WEB_21.qlytaikhoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản lý tài khoản</title>
<link rel="stylesheet" type="text/css" href="App_Start/css/menu.css"/>
<link rel="stylesheet" type="text/css" href="App_Start/css/qlytkhoan.css"/>
</head>
<body>
   <header id="hd" class="hd1">
        <form  method="post" id="form">
        <div class="chuyen">
          <div class="logo">
            <a href="trangchu.aspx">
                <image class="logo1" src="App_Start/img/logo.png"></image>
            </a>
          </div>
          <div class="timkiem">
            <div class="pchia">
                  <div class="pchia1">
                           <input class="timkiem1" name="timkiem2" type ="text" id="timkiem2" placeholder="Tìm Kiếm "/>
                   </div>
                  <div class="pchia2">
                     <button id="timkiem" type="submit" name="timkiem" value="timkiem" class="">
                      <img class="imgtk" src="App_Start/img/nuttimkiem1.jpg" />
                     </button> 
                   </div>
              </div>
           </div>
        </div>
        </form>
        <div class="thanhchon">
            <ul>
                <li class="menu"><a class="a" href="tintuc.aspx">Tin tức</a></li>
                <li class="menu"><a class="a" href="sanpham.aspx">Hot Room</a></li>
                <li class="menu" id="dky" runat="server"><a class="a" href="dangky.aspx">Đăng ký</a></li>
                <li class="menu" id="dnhap" runat="server"><a class="a" href="dangnhap.aspx">Đăng nhập</a></li>
                <li class="menu" id="tkhoan" runat="server"></li>
            </ul>
        </div>
    </header>

    <div class="contt">
        <center>
            <h3>QUẢN LÝ TÀI KHOẢN</h3>
            <form method="post" runat="server" id="form">
             <div class="ttactkhoan">
                 <div class="a1"><span>Địa chỉ email:</span> <input type="text" class="ipt" id="dchiemail" name="dchiemail" placeholder="  Địa chỉ Email" runat="server"/>
                </div>
                 <span id="tbaoemail">

                </span><br />
                 <div class="a1"><span>Số điện thoại:</span> <input type="text" class="ipt" id="sdthoai" name="sdthoai" placeholder="  Số điện thoại " runat="server"/>
                </div>
                <span id="tbaosdt">

                </span><br />
                <div class="a1"> <span>Họ và tên:</span> <input type="text" class="ipt" id="hten" name="hten" placeholder="  Họ và tên " runat="server"/>
                </div> 
                <span id="tbaohten">

                </span><br />
                 <div class="a1"><span>Mật khẩu:</span> <input type="text" class="ipt" id="mkhau" name="mkhau" placeholder="  Mật khẩu " runat="server"/>
                </div><br />
                <span id="tbaomkhau">

                </span><br />

                <div class="thaotac">
                 <input onclick="return checkData()" type="submit" id="them" value="Thêm" class="nttt" name="them"/>
                 <input type="submit" id="sua" value="Sửa" class="nutt" name="sua"/> 
                <span id="tbaoadmin">

                </span>
                 <div id="tbaotkhoan" runat="server">

                </div>
                 </div>
             </div>
             
            <div class="space-top"></div>
             <div class="dmuctk">
                    <div>
                         <h3>DANH SÁCH TÀI KHOẢN</h3>
                    </div>
                    <div class="tbtkhoan"></div>
                    <div class="dstkhoan" id="lsttkhoan" runat="server" >

                    </div>
                  <div class="bangqlytk" id="tabletkhoan" runat="server"></div>
               </div>
           </form>

        </center>

    </div>


    <footer>
        <div class="thongtin">
           <h3> TOP Hotel được quan tâm</h3>
            <ul>
                <li class="tt">TeamHQH Hà Nội</li>
                <li class="tt">TeamHQH Đà Nẵng </li>
                <li class="tt">TeamHQH Hải Phòng</li>
                <li class="tt">TeamHQH Hồ Chí Minh</li>
                <li class="tt">TeamHQH Vũng Tàu</li>
            </ul>
        </div>
        <div class="thongtin">
            <h3> Không gian yêu thích</h3>
            <ul>
                <li class="tt">Căn hộ</li>
                <li class="tt">Khách sạn</li>
                <li class="tt">Nhà riêng</li>
                <li class="tt">Bể bơi</li>
                <li class="tt">Vườn hoa</li>
            </ul>
        </div>
        <div class="thongtin">
            <h3> Về chúng tôi</h3>
            <ul>
                <li class="tt">facebook</li>
                <li class="tt">0988722463</li>
                <li class="tt">hqhteam@gmail.com</li>
            </ul>
        </div>
        <div class="thongtin">
            <h3>Tải ứng dụng tại HQH-Team</h3>
            <table>
                <tr>
                    <td rowspan="2"><img class="imgcode" src="App_Start/img/macode.png" /></td>
                    <td><img class="ggpl" src="App_Start/img/ggplay.png" /></td>
                </tr>
                <tr>
                    <td><img class="appst" src="App_Start/img/appst.png" /></td>
                </tr>
            </table>
        </div>
        <div class="cuoi"><h4>Design by HQH-Team</h4></div>
    </footer>
    <script src="./App_Start/js/qlytkhoan.js"></script>
</body>
</html>

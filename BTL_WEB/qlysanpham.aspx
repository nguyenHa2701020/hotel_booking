<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qlysanpham.aspx.cs" Inherits="BTL_WEB_21.qlysanpham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản lý sản phẩm</title>
<link rel="stylesheet" type="text/css" href="App_Start/css/menu.css"/>
    <link rel="stylesheet" type="text/css" href="App_Start/css/qlyspham.css"/>
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
            <h3>QUẢN LÝ SẢN PHẨM</h3>
            <form method="post" runat="server" id="form">
             <div class="ttacspham">
                <div class="a1"><span>Loại phòng:</span> <input type="text" class="ipt" id="lphong" name="lphong" placeholder="  Tên phòng" runat="server"/>
                 </div>
                <span id="tbaop">

                </span><br />
                <div class="a1"><span>Chi tiết:</span> <input type="text" class="ipt" id="ctiet" name="ctiet" placeholder="  Chi tiết " runat="server"/><br />
                 </div>
                <span id="tbaoct">

                </span><br />
                <div class="a1"><span>Giá:</span> <input type="text" class="ipt" id="gia" name="gia" placeholder="  Giá" runat="server"/><br />
                 </div>
                <span id="tbaogia">

                </span>
                <div class="a2"><span>Ảnh:</span> <input type="file" class="ipt" id="file" name="flie" runat="server" accept=".jpg , .pmh , .jpeg , .gif"/>
                 </div>
                <span id="tbaoanh">

                </span><br />

                <div class="thaoytac">
                 <input onclick="return checkData()" type="submit" id="them" value="Thêm" class="nttt" name="them"/>
                 <input type="submit" id="sua" value="Sửa" class="nutt" name="sua"/> 
                </div>
             </div>
                <div class="dmucsp">
                    <div>
                         <h3>DANH SÁCH SẢN PHẨM</h3>
                         <p id="checkThemSP" runat="server"> </p>
                    </div>
                    <div class="img_col2" style="display:none">
                         <img src="" alt="" class="img" id="image_sanpham" runat="server"/>
                     </div>
                    <div id="lstspham" runat="server">

                    </div>
                </div>
            </form>

        </center>

    </div>

   <div class="nganchan"></div>

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
    <script type="text/javascript" src="./App_Start/js/qlyspham.js"></script>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="trangchu.aspx.cs" Inherits="BTL_WEB_21.trangchu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang chủ</title>
    <link rel="stylesheet" type="text/css" href="App_Start/css/menu.css"/>
    <link rel="stylesheet" type="text/css" href="App_Start/css/trangchu.css"/>
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


    <div class="content">
    <div>
        <a href="tintuc.aspx"><img class="banner" src="App_Start/img/bannerWeb.png" /></a>
    </div>
    <div class="chao"><h2>Chào mừng bạn đến với HQH-Team</h2></div>
    Đặt phòng, chỗ ở, trải nghiệm tuyệt vời và bạn sẽ cảm nhận nhiều hơn nữa trên HQH-Team
    <div><b><a href="dangnhap.aspx" class="phu">Đăng nhập</a></b> hoặc <b><a href="dangky.aspx" class="phu">Đăng ký</a></b> để nhận các ưu đãi đặc biệt</div>
    <center>
    <hr />
 
       <div>
        <h1>Thời gian là: </h1>
        
        <div id="time" runat="server">

        </div>
            </div>
        
 

    </center>
    <div class="điaiemnoibat">
        <h2>Địa điểm nổi bật</h2>
        <div>Cùng HQH-Team bắt đầu chuyến hành trình chinh phục thế giới của bạn</div>
        <div class="pchiadd">
            <center>
            <div class="xly1"><a><img class="nbat" src="App_Start/img/content5.jfif" /></a><br /><h3>Hà Nội</h3></div>
            <div class="xly1"><a><img class="nbat" src="App_Start/img/content6.jfif" /></a><br /><h3>Thanh Hóa</h3></div>
            <div class="xly1"><a><img class="nbat" src="App_Start/img/anhsapa.jfif" /></a><br /><h3>Sapa</h3></div>
            <div class="xly1"><a><img class="nbat" src="App_Start/img/content2.jpg" /></a><br /><h3>Hạ Long</h3></div>
            <div class="xly1"><a><img class="nbat" src="App_Start/img/anhconten2.jpg"/></a><br /><h3>Đà Nẵng</h3></div>
            </center>
        </div>
    </div>
    <div class="khuyenmai">
        <h2>Khuyến mãi được yêu thích</h2>
        <div class="pchiakmai">
            <center>
            <div class="xly2"><a><img class="kmai" src="App_Start/img/km1.png" /></a></div>
            <div class="xly2"><a><img class="kmai" src="App_Start/img/km2.png" /></a></div>
            <div class="xly2"><a><img class="kmai" src="App_Start/img/km3.png" /></a></div>
            <div class="xly2"><a><img class="kmai" src="App_Start/img/km4.png" /></a></div>
            <div class="xly2"><a><img class="kmai" src="App_Start/img/km5.png"/></a></div>
            <div class="xly2"><a><img class="kmai" src="App_Start/img/km6.png"/></a></div>
            </center>
        </div>
    </div>
        <div class="huongdan"> 
             <div class="hd1">
                <img class="lghd" src="App_Start/img/logo.png" /><br />
                <h2>Tìm kiếm chỗ ở giá tốt nhất</h2><br />
                <span>HQH-STEAM hiện là nền tảng đặt phòng trực tuyến rất có uy tín. 
                    Đồng hành cùng chúng tôi, bạn có những chuyến đi mang đầy trải nghiệm.
                    Với HQH-STEAM, việc đặt chỗ ở, biệt thự nghỉ dưỡng, khách sạn, nhà riêng,
                    chung cư... trở nên nhanh chóng, thuận tiện và dễ dàng.
                </span>
              </div>
              <div class="hd2">
                     <img class="sale"  src="App_Start/img/dki.png" />
                     <img class="sale" src="App_Start/img/dki1.png" />
              </div>  
        </div>
    </div>
    <center>
    <hr />
    </center>


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
    

</body>
</html>

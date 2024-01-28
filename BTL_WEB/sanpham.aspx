<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="BTL_WEB_21.sanpham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sản phẩm</title>
       <link rel="stylesheet" type="text/css" href="App_Start/css/menu.css"/>
    <link rel="stylesheet" type="text/css" href="App_Start/css/spham.css"/>
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

      
        
     
        
    <div class="cont">
    <h1>HQH TEAM-Địa điểm nổi bật</h1>
        <table>
            <tr>
                <td>
                    Trước khi đặt phòng, hãy kiểm tra những địa điểm bị hạn chế du lịch 
                    trong thời gian này. <br />
                    Sức khỏe và sự an toàn của cộng đồng luôn 
                    được đặt hàng đầu. Vì vậy, vui lòng làm theo chỉ thị của chính 
                    phủ bởi điều đó thực sự cần thiết.
                </td>
                <td>
                    <form method="post" id="form1">
                        <div id="fm" runat="server">
                        <span class="spicon">
                           <img class="iconud" src="App_Start/img/iconup.png"/>
                          <input type="submit" name="gtang"  value="Giá tăng dần"  /> 
                         </span>
                        <span class="spicon">
                          <img class="iconud" src="App_Start/img/icondown.png"/>
                        <input type="submit" name="ggiam"  value="Giá giảm dần"  />
                        </span>
                        </div>
                       </form>

                </td>
            </tr>
        </table>
        <div class="spham">
                    <div class="sanpham" id="listSanPham" runat="server">

                    </div>
        </div>
        </div>
       <div class="nchan"></div>


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

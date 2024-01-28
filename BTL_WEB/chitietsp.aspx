<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chitietsp.aspx.cs" Inherits="BTL_WEB_21.chitietsp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chi tiết sản phẩm</title>
<link rel="stylesheet" type="text/css" href="App_Start/css/menu.css"/>
<link rel="stylesheet" type="text/css" href="App_Start/css/chitiet.css"/>
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
        <div id="imgload" runat="server">
            <!--đổi ảnh-->
            <div class="td1"><img src="App_Start/img/anhhay.jpg" id="doianh" runat="server" /></div>
            <div class="td1" id="bde"><img src="App_Start/img/anhhay.jpg" id="doianh2" runat="server" /></div>
        </div>
        <div class="chiase"><img class="pd" src="App_Start/img/share.jpg" /><img class="pd" src="App_Start/img/subcribe.jpg" /></div>
        <div class="col1">
            <br />
            <!--tên phòng-->
            <div id="ten" runat="server">
                Nguyen Thien Quang
            </div>
            <br />
            <h3>Địa chỉ: Tây Hồ-Hà Nội-Việt Nam</h3><br />
            Phòng riêng · 1 Phòng tắm · 1 giường · 1 phòng ngủ · 2 khách (tối đa 2 khách)<br />
            <h2 class="h2">Tiện nghi không gian</h2><br />
            <div class="gk"><img class="kg" src="App_Start/img/kgian.jpg" /></div>
            <h2 class="gk">Tiện nghi phòng bếp</h2><br />
            <div><img class="kg" src="App_Start/img/kgbep.jpg" /></div>
            <h2 class="gk">Tiện nghi ban công</h2><br />
            <div><img class="kg" src="App_Start/img/bcong.jpg" /></div>
            <br />
            <h2>Thời gian nhận trả phòng</h2>
            <div class="xanh">Nhận phòng <span>08:30 AM</span></div>
            <div class="xam">Trả phòng <span>17:00 PM</span></div>
        </div>
        <div class="col2">
        <div class="thanhtoan">
            <form>              
                <center>
                    <!--giá tiền-->
                    <div id="gtien" runat="server">
                        <h1></h1>
                    </div>
                    <div class="daylen">
                <input type="date" /> Đến <input type="date" />
                <input class="sk" type="text" placeholder="  Số khách" />
                <input class="sm" type="submit" value="Đặt ngay"/>
                        </div>
                 </center>
            </form>
         </div>
         <div class="thtin"> 
            <form>
                <center>
                    <br />
                 <div class="tt"><h3 id="h3">Tư vấn tại HQH-TEAM</h3>
                    Vui lòng cung cấp số điện thoại để nhận được tư 
                    vấn từ Luxstay cho chuyến đi của bạn.
                 </div>            
                 <input class="sk" type="text" placeholder="  Tên khách hàng" /> 
                 <input class="sk" type="text" placeholder="  Số điện thoại" />   
                 <input class="sm" type="submit" value="Nhận tư vấn miễn phí"/> 
                <center>
            </form>
       </div> 
    </div>
    </div>
    <br />
    <hr />


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

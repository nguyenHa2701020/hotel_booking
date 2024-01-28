<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tintuc.aspx.cs" Inherits="BTL_WEB_21.tintuc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tin tức</title>
<link rel="stylesheet" type="text/css" href="App_Start/css/menu.css"/>
    <link rel="stylesheet" type="text/css" href="App_Start/css/tintuc.css"/>
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

    <div class="conten">
        <div><img class="anhbn" src="App_Start/img/thuyenhl.jpg" /></div>  
        <div class="bg"><h1>Vịnh hạ Long trong mùa hè hấp dẫn</h1><br />
            Vịnh Hạ Long là một vịnh nhỏ thuộc phần bờ tây vịnh Bắc Bộ tại khu
            vực biển Đông Bắc Việt Nam, bao gồm vùng biển đảo của thành phố Hạ 
            Long thuộc tỉnh Quảng Ninh...
        </div>
    <h1>Tin tức về du lịch</h1>
    <div class="pchiadlich">
        <div class="dlich1">
            <div>
                <img class="btay" src="App_Start/img/anhconten2.jpg" />
            </div>
            <div class="ct"><h2>Đà Nẵng trong mùa hè</h2><br />
                Cầu Vàng còn có tên gọi là Cầu Bàn Tay Ba Na Hills 
                và được báo giới nước <br /> ngoài gọi là Golden Bridge...
            </div>
         </div>
         <div class="dlich2">
            <div>
                <img class="cdong" src="App_Start/img/content6.jfif" />
            </div>
            <div class="ct"><h2>Thái Nguyên trong mùa hè</h2><br />
                Thái Nguyên là trung tâm kinh tế, chính trị - xã hội của
                <br />khu vực đông bắc hay cả vùng Trung du và miền núi phía bắc. 
            </div>
         </div>
         <div class="dlich3">
            <div>
                <img class="con" src="App_Start/img/sapa.jpg" />
            </div>
            <div class="ct"><h3>Sapa trong mùa hè</h3><br />
                Sapa là một địa điểm du lịch nổi<br /> tiếng thuộc tỉnh 
                Lào Cai, nằm tại <br />phía Bắc của nước ta.
            </div>
         </div>  
          <div class="dlich4">
            <div>
                <img class="con" src="App_Start/img/hnoi.jpg" />
            </div>
            <div class="ct"><h3>Hà Nội trong mùa hè </h3><br />
                    Hà Nội là thủ đô, thành phố <br />trực thuộc trung ương 
                    và là một <br />đô thị loại đặc biệt của Việt Nam.
            </div>
          </div> 
   </div>
        <center><hr /></center> 
    <h1>Các bài viết mới nhất</h1>
    <div class="bv"><img class="vb" src="App_Start/img/bviet1.jpg" />
        <div class="kt"><h2>8 địa điểm du lịch từ Hồ Chí Minh</h2></div></div>
    <div class="bv"><img class="vb" src="App_Start/img/bviet2.jpg" />
        <div class="kt"><h2>6 địa điểm du lịch từ Hà Nội</h2></div></div>
    <div class="bv"><img class="vb" src="App_Start/img/bviet5.jpg" />
        <div class="kt"><h2>9 địa điểm du lịch từ Nha Trang</h2></div></div>
    <div class="bv"><img class="vb" src="App_Start/img/bviet4.jpg" />
     <div class="kt"><h2>3 địa điểm du lịch từ Khánh Hòa</h2></div></div>
       <center><hr /></center> 
    <h1>Cẩm nang du lịch</h1>
    <div class="cn">
        <img class="nc" src="App_Start/img/cnang1.jpg" /><br />
        <h3>Review Sapa-</h3><br />
        Trải nghiệm không gian thoáng đãng của SaPa
    </div>
    <div class="cn">
        <img class="nc" src="App_Start/img/cnang2.jpg" />
        <h3>Review Đà Lạt-</h3><br />
        Trải nghiệm không gian thoáng đãng của Đà Lạt
    </div>
    <div class="cn">
        <img class="nc" src="App_Start/img/cnang3.jpg" />
        <h3>Review Phú Quốc-</h3><br />
        Trải nghiệm không gian thoáng đãng của Phú Quốc
    </div>
    </div>
    <center><hr /></center> 

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

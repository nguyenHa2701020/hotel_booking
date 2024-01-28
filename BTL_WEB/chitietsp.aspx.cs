using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_21
{
    public partial class chitietsp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {//thay đổi thanh menu
            if (Convert.ToString(Session["email"]) == "admin@gmail.com")
            {
                string html = $@"                              
                                <a id='load' href='#'><img class='imguser' src='App_Start/img/user.png'/>{Session["name"]}</a>            
                                            <div class='mnsok'>
                                                <a href='giohang.aspx' class='cnang'>                                                
                                                       Giỏ hàng
                                                </a>
                                                <a href='qlytaikhoan.aspx'  class='cnang'>                                                    
                                                        Quản lý tài khoản
                                                </a>
                                                <a href='qlysanpham.aspx' class='cnang'>                                   
                                                        Quản lý sản phẩm
                                                </a>
                                                <a href='dangxuat.aspx' class='cnang'>
                                                        Đăng xuất
                                                </a>
                                             </div>
                                ";

                tkhoan.InnerHtml = html;
                string menuNone = "<script>document.getElementById('dky').style.display = \"none\"; " +
                        "document.getElementById('dnhap').style.display = \"none\";</script>";
                dnhap.InnerHtml = menuNone;

            }
            else if ((bool)Session["login"] == true)
            {
                string html = $@"
                                <a id='load1' href='#'><img class='imguser' src='App_Start/img/user.png'/>{Session["name"]}</a>            
                                            <div class='mnsok1'>
                                                <a href='giohang.aspx' class='chnang'>                                                
                                                       Giỏ hàng
                                                <a href='dangxuat.aspx' class='chnang'>
                                                        Đăng xuất
                                                </a>
                                             </div>
                                ";
                tkhoan.InnerHtml = html;
                string menuNone = "<script>document.getElementById('dky').style.display = \"none\"; " +
                        "document.getElementById('dnhap').style.display = \"none\";</script>";
                dnhap.InnerHtml = menuNone;
            }
            List<spham> listSP = (List<spham>)Application["danhsach_SP"];

            if (Request.QueryString["id"] != null)
            {
                foreach (spham sp in listSP)
                {
                    //id ben file san pham
                    //id trong list sp mà bằng id mk vừa bấm
                    if (sp.id == int.Parse(Request.QueryString["id"]))
                    {
                        doianh.Attributes.Add("src", sp.image);
                        doianh2.Attributes.Add("src", sp.image);
                        //thay đổi tên phòng
                        ten.InnerText = sp.detail;

                        string price = Convert.ToString(sp.price);
                        if (Convert.ToString(sp.price).Length <= 6)
                        {
                            price = price.Insert(3, ".");
                        }
                        else if (Convert.ToString(sp.price).Length <= 7)
                        {
                            price = price.Insert(1, ".").Insert(5, ".");

                        }
                        else
                        {
                            price = price.Insert(2, ".").Insert(6, ".");
                        }
                        //in ra html ở giá tiền
                        gtien.InnerHtml = $@" <h1 class='gt'>{price} đ/đêm</h1>";


                    }
                }
            }
        }
    }
}
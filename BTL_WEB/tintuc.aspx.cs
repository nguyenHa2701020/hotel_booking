using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_21
{
    public partial class tintuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }
    }

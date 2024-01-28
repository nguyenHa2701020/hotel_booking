using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace BTL_WEB_21
{
    public partial class giohang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<the> listCart = (List<the>)Session["listCart"];

            List<spham> listSP = (List<spham>)Application["danhsach_SP"];
            string path = "ListSanPham.xml";

            if (File.Exists(Server.MapPath(path)))
            {
                // Đọc file
                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<spham>));
                StreamReader file = new StreamReader(Server.MapPath(path));

                listSP = (List<spham>)reader.Deserialize(file);
                listSP = listSP.OrderBy(Product => Product.id).ToList();
                file.Close();
            }

            if ((bool)Session["login"] != true)
            {
                Response.Redirect("trangchu.aspx");
            }
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

            // hiện danh sách giỏ hàng của user 
            if (listCart != null)
            {
                int soL = 0;
                double giaP = 0;
                string ConvertPrice = "0";
                string htmls = "";
                foreach (the cart in listCart)
                {
                    if (Convert.ToInt32(Session["id"]) == cart.IdUser)
                    {
                       spham sp = listSP.Find(item => item.id == cart.IdSP && cart.IdUser == Convert.ToInt32(Session["id"]));
                        if (sp != null)
                        {
                            soL++;
                            //soL += cart.ISoLuong;
                            giaP += (double)sp.price * cart.ISoLuong;
                            ConvertPrice = Convert.ToString(giaP);
                            if (ConvertPrice.Length <= 6)
                            {
                                ConvertPrice = ConvertPrice.Insert(3, ".");
                            }
                            else if (ConvertPrice.Length <= 7)
                            {
                                ConvertPrice = ConvertPrice.Insert(1, ".").Insert(5, ".");

                            }
                            else
                            {
                                ConvertPrice = ConvertPrice.Insert(2, ".").Insert(6, ".");
                            }

                        }
                    }
                }



                htmls += $@"
                        <div class='qly'>
                            <h3>YÊU THÍCH CỦA BẠN</h3>
                        </div>
                        <div  class='tongquan'>
                            <h3 class='sop'>Số phòng ở yêu thích:  <span class='sop1'>{soL}</span> </h3>
                            <h3 class='tongt'>Tổng tiền tạm tính: <span class='tongt1'>{ConvertPrice} vnđ</span></h3>
                        </div> 
                        ";
                foreach (the cart in listCart)
                {
                    if (Convert.ToInt32(Session["id"]) == cart.IdUser)
                    {
                       spham sp = listSP.Find(item => item.id == cart.IdSP && cart.IdUser == Convert.ToInt32(Session["id"]));
                        if (sp != null)
                        {
                            string price = Convert.ToString(sp.price);
                            string prices = "";
                            if (Convert.ToString(sp.price).Length <= 6)
                            {
                                prices = price.Insert(3, ".");
                            }
                            else
                            {
                                prices = price.Insert(1, ".").Insert(5, ".");

                            }

                            htmls += $@"
                            <div class='mucythich'>
                                <div class='anhythich'>
                                    <img class='ayt' src='{sp.image}' alt=''>
                                </div>
                                <div class='th'>
                                     <span class='tt1'> <p class='tt2'><b>Số Lượng:</b> {cart.ISoLuong}</p></span> 
                                    <span class='tt1'> <p class='tt2'><b>Loại phòng:</b> {sp.room}</p></span>
                                    <span class='tt1'> <p class='tt2'><b>Chi tiết:</b>  {sp.detail}</p></span>
                                    <span class='tt1'><p class='tt2'><b>Giá:</b> {prices}₫/đêm</p></span>
                                </div>
                                <div class='thaotac'>
                                    <form action='giohang.aspx' runat='server' method='post'> 
                                    <button  class='xoa' type='submit' value='{sp.id}' name='delete'>Xóa</button> </form> 
                                     </br> 
                                    <a class='datngay' href='chitietsp.aspx?id={sp.id}'> Đặt Ngay </a>
                                </div>
                            </div>
                    ";
                        }
                    }

                }
                htmls += $@"
                        </div>
                        ";
                ctenhang.InnerHtml = htmls;
            }

            // xóa sản phẩm trong giỏ hàng
            if (Request.Form["delete"] != null)
            {
                foreach (the cart in listCart)
                {
                    if (cart.IdSP == int.Parse(Request.Form["delete"]))
                    {
                        listCart.Remove(cart);
                        Response.Redirect("giohang.aspx");

                    }
                }
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace BTL_WEB_21
{
    public partial class sanpham : System.Web.UI.Page
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
            // Đọc dữ liệu từ file XML
            string path = "ListSanPham.xml";
            List<spham> list = new List<spham>();


            if (Request.Form["gtang"] == "Giá tăng dần")
            {
                if (File.Exists(Server.MapPath(path)))
                {

                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<spham>));
                    StreamReader file = new StreamReader(Server.MapPath(path));

                    list = (List<spham>)reader.Deserialize(file);
                    //sắp xếp tăng dần theo giá
                    list = list.OrderBy(spham => spham.price).ToList();
                    file.Close();
                }
                listSanPham.InnerHtml = exportSanPham(list);
           
               

            }
            else if (Request.Form["ggiam"] == "Giá giảm dần")
            {
                if (File.Exists(Server.MapPath(path)))
                {

                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<spham>));
                    StreamReader file = new StreamReader(Server.MapPath(path));

                    list = (List<spham>)reader.Deserialize(file);

                    list = list.OrderByDescending(spham => spham.price).ToList();
                    file.Close();
                }
                listSanPham.InnerHtml = exportSanPham(list);
          
            }
            else
            {
                if (File.Exists(Server.MapPath(path)))
                {

                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<spham>));
                    StreamReader file = new StreamReader(Server.MapPath(path));

                    list = (List<spham>)reader.Deserialize(file);
                    list = list.OrderBy(spham => spham.id).ToList();
                    file.Close();
                }
                listSanPham.InnerHtml = exportSanPham(list);
            }

            if (Request.Form["timkiem"] == "timkiem")
            {
                List<spham> listSP = (List<spham>)Application["danhsach_SP"];
                string htmlSP = "";
                string typeRoom = Convert.ToString(Request.Form["timkiem2"]);//lấy text mà mk gõ vào
                foreach (spham itemFinder in listSP)
                {
                    //nếu tên phòng có kí tự đc nhập hoặc phần mô tả có kí tự đc nhập
                    if (itemFinder.room.ToLower().IndexOf(typeRoom.ToLower()) != -1 || itemFinder.detail.ToLower().IndexOf(typeRoom.ToLower()) != -1)
                    {
                        string price = Convert.ToString(itemFinder.price);//chuyển giá của sp về dạng chuỗi
                        string prices = "";
                        
                        if (Convert.ToString(itemFinder.price).Length <= 6)
                        {//insert từ trái qua phải
                            prices = price.Insert(3, ".");
                        }
                        else
                        {
                            prices = price.Insert(1, ".").Insert(5, ".");

                        }// phần trình bày sp khi đọc từ file lên
                        htmlSP += $@"
                        <div class='sphamsx'>
                                        <div><img class='anhtk' src='{itemFinder.image}' alt=''/></div>
                                        <div class='ttspham'>
                                                 <span class='sp'>
                                                            {itemFinder.room}
                                                 </span><br/>
                                                 <span class='sp'>
                                                             {itemFinder.detail} 
                                                   </span><br/>
                                                <span class='sp'>
                                                              {prices} ₫/đêm
                                                     </span><br/>
                                        </div>
                                            <div class='ttac' id='tt1'>
                                                <a href='sanpham.aspx?idSP={itemFinder.id}'> 
                                                <button class='' id='themyt'>Thêm vào yêu thích</button>
                                                </a>
                                            </div>
                                            <div class='ttac' id='tt2'>
                                                    <a href='chitietsp.aspx?id={itemFinder.id}'>
                                                    <button class='' id='ttinctiet'>Thông tin chi tiết</button>
                                                </a>
                                            </div>
                         </div>    
                        ";
                    }
                    
                    listSanPham.InnerHtml = htmlSP;//in ra client mã html dọc từ file
                    //ẩn 2 thanh giá tăng, giá giảm
                    string menu = "<script>document.getElementById('fm').style.display = \"none\";</script>";
                    fm.InnerHtml = menu;
                }
            }


            // Lưu list cart để thêm vào giỏ hàng
            //nếu button thêm vào mục yêu thích đc nhấn
            if (Request.QueryString["idSP"] != "")
            {
                //lấy dữ liệu từ biến session phải xác định kiểu
                List<the> listCart = (List<the>)Session["listCart"];
                if ((bool)Session["login"] == true)
                {
                    bool check = false;
                    int i = 1;
                    //khi ta ấn sp thêm vào yêu thích nhiều lần
                    foreach (the item in listCart)
                    {
                        //chuyển về dạng số để so sánh
                        if (item.IdSP == Convert.ToInt32(Request.QueryString["idSP"]))
                        {
                            item.ISoLuong += i;
                            check = true;
                        }

                    }
                    //khi ta ấn thêm vào yêu thích các sp khác nhau
                    if (check == false)
                    {
                        the cart = new the();
                        cart.IdSP = Convert.ToInt32(Request.QueryString["idSP"]);
                        cart.IdUser = Convert.ToInt32(Session["id"]);
                        cart.ISoLuong = i;
                        listCart.Add(cart);
                        Session["listCart"] = listCart;

                    }

                }

            }

        }
        public string exportSanPham(List<spham> listSP)
        {

            string htmlSP = "";
            foreach (spham sp in listSP)
            {
                // thêm dấu chấm đằng sau float
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
                htmlSP += $@"
                    <div class='sphamsx'>
                                        <div><img src='{sp.image}' alt=''/ class='imga'></div>
                                        <div class='ttspham'>
                                                 <span class='sp'>
                                                            {sp.room}
                                                 </span></br>
                                                 <span class='sp'>
                                                             {sp.detail} 
                                                   </span></br>
                                                <span class='sp'>
                                                              {price} ₫/đêm
                                                     </span></br>
                                        </div>
                                            <div class='ttac'>
                                                <a href='sanpham.aspx?idSP={sp.id}'> 
                                                <button class='' id='themyt'>Thêm vào yêu thích</button>
                                                </a>
                                            </div>
                                            <div class='ttac'>
                                                    <a href='chitietsp.aspx?id={sp.id}'>
                                                    <button class='' id='ttinctiet'>Thông tin chi tiết</button>
                                                    </a>
                                            </div>
                         </div>    
                        ";
            }
            return htmlSP;
        }
    }
    }

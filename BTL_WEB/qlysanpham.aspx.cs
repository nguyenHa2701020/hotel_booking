using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml.Serialization;

namespace BTL_WEB_21
{
    public partial class qlysanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                List<spham> listSP = (List<spham>)Application["danhsach_SP"];
                string path = "ListSanPham.xml";

                if (Convert.ToString(Session["email"]) != "admin@gmail.com")
                {
                    Response.Redirect("trangchu.aspx");
                }
                if (Convert.ToString(Session["email"]) == "admin@gmail.com" || (bool)Session["login"] == true)
                {
                    if (IsPostBack)
                    {
                        if (Request.Form["them"] == "Thêm")
                        {
                        //gọi file

                            HttpPostedFile file = Request.Files["file"];
                        //kiểm tra có file tồn tại
                            if (file.ContentLength > 0)
                            {
                                file.SaveAs(Server.MapPath("~/App_Start/img/file_img/") + file.FileName);
                            }
                            spham sp = new spham();
                            sp.id = listSP.Count + 1;
                            sp.image = "/App_Start/img/file_img/" + file.FileName;
                            sp.room = Request.Form["lphong"];
                            sp.detail = Request.Form["ctiet"];
                            sp.price = double.Parse(Request.Form["gia"]);
                            listSP.Add(sp);
                        }

                        if (Request.Form["sua"] == "Sửa")
                        {

                            foreach (spham sp in listSP)
                            {
                                if (sp.id == int.Parse(Request.QueryString["id"]))
                                {
                                    HttpPostedFile file = Request.Files["file"];
                                    if (file.ContentLength > 0)
                                    {
                                        file.SaveAs(Server.MapPath("~/App_Start/img/file_img/") + file.FileName);
                                    }
                                    sp.id = listSP.Count;
                                    sp.image = "/App_Start/img/file_img/" + file.FileName;
                                    sp.room = Request.Form["lphong"];
                                    sp.detail = Request.Form["ctiet"];
                                    sp.price = double.Parse(Request.Form["gia"]);
                                }
                            }
                        }

                        if (Request.Form["xoa"] != null)
                        {
                            // dùng js bỏ loại ảnh
                            foreach (spham sp in listSP)
                            {
                                if (int.Parse(Request.Form["xoa"]) == sp.id)
                                {
                                    listSP.Remove(sp);
                                    break;
                                }
                            }
                        }

                        XmlSerializer xml = new XmlSerializer(typeof(List<spham>));
                        FileStream wfile = File.Create(Server.MapPath(path));
                        xml.Serialize(wfile, listSP);
                        wfile.Close();
                    }
                    lstspham.InnerHtml = exportSanPham(listSP);



                    if (Request.QueryString["id"] != "")
                    {
                        lphong.Value = Request.QueryString["loaiphong"];
                        ctiet.Value = Request.QueryString["chitiet"];
                        gia.Value = Request.QueryString["gia"];
                        string fileImage = Request.QueryString["image"];
                        image_sanpham.Attributes.Add("src", fileImage);
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
                    else if (Convert.ToString(sp.price).Length <= 7)
                    {
                        prices = price.Insert(1, ".").Insert(5, ".");

                    }
                    else
                    {
                        prices = price.Insert(2, ".").Insert(6, ".");
                    }
                    htmlSP += $@"
                    <div class='bangqly'>
                    <div class='imgsp'>
                        <img src='{sp.image}' alt='' class='imgadd'>
                    </div>
                    <div class='ttspham'>
                        <span class='tt1'><p class='id'><b>ID:</b> {sp.id} </p></span>
                        <span class='tt1'> <p class='lphong'><b>Loại phòng:</b> {sp.room} </p></span>
                        <span class='tt1'><p class='ctiet'><b>Chi tiết:</b>  {sp.detail}</p></span>
                        <span class='tt1'><p class='gphong'><b>Giá:</b> {prices} VNĐ</p></span>
                    </div>
                    <div class='thtac'>
                        <a class='suasp' href='qlysanpham.aspx?id={sp.id}&image={sp.image}&loaiphong={sp.room}&chitiet={sp.detail}&gia={sp.price}' class='tt'> Sửa </a> 
                        </br>
                        <button class='tt' type='submit' value='{sp.id}' name='xoa'>Xóa</button>
                    </div>
                </div>
                            ";
                }
                return htmlSP;
            }
        }
    }

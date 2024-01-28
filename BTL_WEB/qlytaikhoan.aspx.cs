using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_21
{
    public partial class qlytaikhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["email"]) == "admin@gmail.com")
            {
                List<User> lstuser = (List<User>)Application["danhsach_user"];
                if (IsPostBack)
                {

                    if (Request.Form["them"] == "Thêm")
                    {
                        //khi thêm mà bị trùng ttin
                        bool check = false;
                        foreach (User us in lstuser)
                        {
                            if (us.Email == Request.Form["dchiemail"] && us.SDT == Request.Form["sdthoai"])
                            {
                                check = true;
                                string js = "<script>document.getElementById('tbaoadmin').innerHTML = \"Tài khoản đã tồn tại\";</script>  ";
                                tbaotkhoan.InnerHtml = js;
                            }
                            else if (us.Email == Request.Form["dchiemail"])
                            {
                                check = true;
                                string js = "<script>document.getElementById('tbaoadmin').innerHTML = \"Email đã tồn tại\";</script>  ";
                                tbaotkhoan.InnerHtml = js;
                            }
                            else if (us.SDT == Request.Form["sdthoai"])
                            {
                                check = true;
                                string js = "<script>document.getElementById('tbaoadmin').innerHTML = \"SĐT đã tồn tại\";</script>  ";
                                tbaotkhoan.InnerHtml = js;
                            }
                            else
                            {
                                check = false;
                            }

                        }
                        if (check == false)
                        {
                            //khi ko bị trùng ttin
                            User user = new User();
                            user.Email = Request.Form["dchiemail"];
                            user.MatKhau = Request.Form["mkhau"];
                            user.SDT = Request.Form["sdthoai"];
                            user.HoTen = Request.Form["hten"];
                            lstuser.Add(user);
                            Application["danhsach_user"] = lstuser;

                            string js = "<script>document.getElementById('tbaoadmin').innerHTML = \"\";</script>  ";
                            tbaotkhoan.InnerHtml = js;

                        }
                    }
                    if (Request.Form["sua"] == "Sửa")
                    {
                        foreach (User us in lstuser)
                        {
                            //khi bấm sửa thì id kèm theo nó giống vs id đã có trong ds thì thực hiện đổi
                            if (us.ID == int.Parse(Request.QueryString["id"]))
                            {
                                us.Email = Request.Form["dchiemail"];
                                us.HoTen = Request.Form["hten"];
                                us.MatKhau = Request.Form["mkhau"];
                                us.SDT = Request.Form["sdthoai"];
                            }
                        }
                    }
                    if (Request.Form["xoa"] != null)
                    {
                        foreach (User us in lstuser)
                        {

                            if (us.ID == 1)
                            {
                                string js = "<script>document.getElementById('tbaoadmin').innerHTML = \"Không thể xóa tài khoản ADMIN\";</script>  ";
                                tbaotkhoan.InnerHtml = js;
                            }
                            else
                            {
                                lstuser.Remove(us);
                                string js = "<script>document.getElementById('tbaoadmin').innerHTML = \"\";</script>  ";
                                tbaotkhoan.InnerHtml = js;
                                break;

                            }
                        }
                    }
                }
                string renderAccount = $@"
                                 <table border='1' cellspacing='1' cellpadding='10'>  
                                    <tr>
                                        <td> ID </td>
                                        <td> EMAIL </td>
                                        <td> HỌ VÀ TÊN </td>
                                        <td> SĐT </td>
                                        <td> MẬT KHẨU </td>
                                        <td> SỬA </td> 
                                        <td> XÓA </td>
                                    </tr>
                                ";
                int i = 1;
                foreach (User us in lstuser)
                {
                    us.ID = i++;
                    renderAccount += $@"
                                <tr>
                                    <td> {us.ID} </td>
                                    <td>{us.Email}</td>
                                    <td>{us.HoTen}</td>
                                    <td>{us.SDT}</td>
                                    <td>{us.MatKhau}</td>
                                    <td> <a class='suatkhoan' href='qlytaikhoan.aspx?id={us.ID}&email={us.Email}&hoten={us.HoTen}&sdt={us.SDT}&matkhau={us.MatKhau}'> Sửa </td>
                                    <td>  <button class='ttxoa' type='submit' name='xoa' value='{us.ID}'>Xóa </button> </td>
                                </ tr >
                              ";
                }
                renderAccount += "</table>";

                // Lấy giá trị từ QueryString dựa vào nút sửa
                if (Request.QueryString["id"] != "")
                {
                    dchiemail.Value = Request.QueryString["dchiemail"];
                    hten.Value = Request.QueryString["hten"];
                    sdthoai.Value = Request.QueryString["sdthoai"];
                    mkhau.Value = Request.QueryString["mkhau"];

                }


                tabletkhoan.InnerHtml = renderAccount;


                // hiện ra menu trong admin
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
            else
            {
                Response.Redirect("trangchu.aspx");
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_21
{
    public partial class dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<User> lstuser = (List<User>)Application["danhsach_user"];
            if (IsPostBack)
            {
                    if (Request.Form["dnhap"] == "Đăng nhập")
                    {
                        
                        string user = Request.Form["email"];
                        string pass = Request.Form["mkhau"];
                        bool checkAccount = false;
                        foreach (User us in lstuser)
                        {
                            if (us.Email == user)
                            {
                                checkAccount = true;
                                if (us.MatKhau == pass)
                                {
                                    Session["email"] = user;
                                    Session["matkhau"] = pass;
                                    Session["login"] = true;
                                    Session["name"] = us.HoTen;
                                    Session["id"] = us.ID;
                               Session["time"] = DateTime.Now;
                                  
                                   Application["dem"] = 0;
                                    Response.Redirect("trangchu.aspx");
                                }
                            }
                        }
                        if (checkAccount == true)
                        {
                            string js = "<p>Mật khẩu không đúng</p>";
                            tbaosubmit.InnerHtml = js;
                        }
                        else
                        { 
                            string js = "<p style='text-alight:center'>Tài khoản không tồn tài</p>";
                            tbaosubmit.InnerHtml = js;
                        }
                    }

                }



            }
        }
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using System.Xml.Serialization;

namespace BTL_WEB_21
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {// app chay cho toan trang web
            Application["danhsach_user"] = new List<User>();
            User admin = new User();
            admin.ID = 1;
            admin.Email = "admin@gmail.com";
            admin.MatKhau = "123456789";
            admin.SDT = "0123456789";
            admin.HoTen = "Admin";
            List<User> ds;
            ds = (List<User>)Application["danhsach_user"];
            ds.Add(admin);
            Application["danhsach_user"] = ds;


            // danh sách sản phẩm
            Application["danhsach_SP"] = getDsSP();
            //Application["ha"] = 0;
            
        }
        protected List<spham> getDsSP()
        {// path luu cac san pham
            string path = "ListSanPham.xml";
            List<spham> listSP = new List<spham>();
            // kiem tra file có ton tai trong thu muc ko
            if (File.Exists(Server.MapPath(path)))//mac dinh la true
            {
                // Đọc file
                XmlSerializer xml = new XmlSerializer(typeof(List<spham>));
                StreamReader file = new StreamReader(Server.MapPath(path));

                listSP = (List<spham>)xml.Deserialize(file);
                //sap xep tang dan theo id
                listSP = listSP.OrderBy(spham => spham.id).ToList();
                file.Close();
            }
            return listSP;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = false;//chua ai dang nhap
            Session["name"] = "";//ten nguoi dung khi dang nhap
            Session["listCart"] = new List<the>();//list gio hag cua nguoi dung
            //Session["time"] = "";
           /* Application.Lock();
            Session.Timeout = 2;
            Application["ha"] = Convert.ToInt32(Application["ha"]) + 1;
            Application.UnLock();*/
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
          /*  Application.Lock();
            Session.Timeout = 2;
            Application["ha"] = Convert.ToInt32(Application["ha"]) - 1;
            Application.UnLock();
          */
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
    
}
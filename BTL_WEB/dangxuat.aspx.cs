using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB_21
{
    public partial class dangxuat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("email");
            Session.Abandon();//xoá tất cả
            // quay về trang đăng nhập
            Response.Redirect("trangchu.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("xin chao: " + Session["tendangnhap"]);
            //Response.Write("xin chao: " + Request.Cookies["tendangnhap"].Value);
          
                Application["demluot"] = (int)Application["demluot"] + Session.Count;
                Response.Write("Da xem: " + Application["demluot"]);
                //kiem tra du lieuj dau vao, tai khoan vaf mk khac rong, thi kiem tra tk laf admin, mk la 123456
                //neu đúng, gán dữ liệu tên đăng nhập vào sessison
                //nếu sai, báo ra bạn đã nhập sai tài khoản mk, lần thứ
                //*đối với trường hợp đăng nhập thành công, hiển thị hiện nay có bao nhiều người đang đăng nhập
        }
    }
}
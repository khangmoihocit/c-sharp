using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TH_04.Models;

namespace TH_04
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            List<User> listUsers = (List<User>)Application["UserAccounts"];
            
            foreach(User user in listUsers)
            {
                if (user.username == txtUsername.Text && user.password == txtPassword.Text)
                {
                    Session["LoginUser"] = user;
                    Response.Redirect("~/Index.aspx");
                    return;
                }
            }
            lblError.Text = "Tài khoản hoặc mật khẩu không đúng.";

        }
    }
}
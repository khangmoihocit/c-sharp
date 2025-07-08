using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using TH_04.Models;

namespace TH_04
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var userAccounts = new List<User>
            {
                new User { username = "user1", password = "123", fullName = "Nguyễn Văn A" },
                new User { username = "user2", password = "123", fullName = "Trần Thị B" }
            };

            // Lưu danh sách này vào Application State để dùng chung cho mọi người dùng
            Application["UserAccounts"] = userAccounts;
        }
    }
}
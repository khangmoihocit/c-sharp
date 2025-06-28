using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (IsPostBack)
            {
                string tendangnhap = Request.Form.Get("tendangnhap");
                string matkhau = Request.Form.Get("matkhau");

                if(tendangnhap == "admin" && matkhau == "admin")
                {
                    Session["tendangnhap"] = tendangnhap;
                    Response.Redirect("home.aspx");
                }
                else
                {
                    if (Session["dem"] == null)
                    {
                        Session["dem"] = 1;
                    }
                    else {
                        Session["dem"] = (int)Session["dem"] + 1;
                    }
                }

                if ((int)Session["dem"] >= 10)
                {
                    Response.Redirect("home.aspx");
                }
            }

            //cookies
            if (IsPostBack)
            {
                Response.Cookies["tendangnhap"].Value = Request.Form.Get("tendangnhap");
                Response.Cookies["tendangnhap"].Expires = DateTime.Now.AddDays(5);
                Response.Redirect("home.aspx");
            }

            //application
            //b1: tao file global
            Application["demluot"] = (int)Application["demluot"] + 1;
            Response.Write("Da xem" + Application["demluot"]);
            */

            if (IsPostBack)
            {
                string tendangnhap = Request.Form.Get("tendangnhap");
                string matkhau = Request.Form.Get("matkhau");
                
                if(tendangnhap != "" && matkhau != "")
                {
                    if(tendangnhap == "admin" && matkhau == "123456")
                    {
                        Session["tendangnhap"] = tendangnhap;
                        Response.Redirect("home.aspx");
                    }
                    
                }
                else
                {
                    if (Session["solansai"] == null)
                    {
                        Session["solansai"] = 1;
                        Response.Write("ban da sai tai khoan va mat khau lan thu: " + Session["solansai"]);
                    }
                    else
                    {
                        Session["solansai"] = (int)Session["solansai"] + 1;
                        Response.Write("ban da sai tai khoan va mat khau lan thu: " + Session["solansai"]);
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
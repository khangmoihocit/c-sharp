using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database;

namespace test_generatelistproduct
{
    public partial class Home : System.Web.UI.Page
    {
        private KhachHangDAO khachHangDAO;

        public Home()
        {
            khachHangDAO = new KhachHangDAO();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var list = khachHangDAO.getKhachHangs();

                rptKhachHang.DataSource = list;

                rptKhachHang.DataBind();
            }
        }
    }
}
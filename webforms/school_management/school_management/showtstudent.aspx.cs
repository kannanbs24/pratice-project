using bal;
using dataaccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace school_management
{
    public partial class showteacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            schooldetails b = new schooldetails();
            List<student> products = new List<student>();
            products = b.GetProducts2();

            GridView1.DataSource = products;
            GridView1.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac9_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Fetch_Data_Click(object sender, EventArgs e)
        {
            WebService1 db = new WebService1();
            GridView1.DataSource = db.Get();
            GridView1.DataBind();

        }
    }
}
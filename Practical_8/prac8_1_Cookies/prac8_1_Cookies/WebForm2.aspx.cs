using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac8_1_Cookies
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie1 = Request.Cookies["userinformation"];
            Label2.Text = cookie1["Name"];
            Label4.Text = cookie1["Roll_No"];
            Label6.Text = cookie1["Program"];

        }
    }
}
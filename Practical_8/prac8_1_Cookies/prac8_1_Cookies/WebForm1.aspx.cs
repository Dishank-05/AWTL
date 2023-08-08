using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac8_1_Cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userinformation");
            cookie["Name"] = TextBox1.Text;
            cookie["Roll_No"] = TextBox2.Text;
            cookie["Program"] = TextBox3.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("WebForm2.aspx");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac8_4_Query_String
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx?Name=" + TextBox1.Text + "&Roll_No=" +
TextBox2.Text + "&Program=" + TextBox3.Text);

        }
    }
}
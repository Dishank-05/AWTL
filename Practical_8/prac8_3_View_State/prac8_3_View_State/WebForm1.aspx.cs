using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac8_3_View_State
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            ViewState["TextBox1"] = TextBox1.Text;
            TextBox1.Text = "";
            ViewState["TextBox2"] = TextBox2.Text;
            TextBox2.Text = "";
            ViewState["TextBox3"] = TextBox3.Text;
            TextBox3.Text = "";

        }

        protected void Restore_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["TextBox1"].ToString();
            TextBox2.Text = ViewState["TextBox2"].ToString();
            TextBox3.Text = ViewState["TextBox3"].ToString();

        }
    }
}
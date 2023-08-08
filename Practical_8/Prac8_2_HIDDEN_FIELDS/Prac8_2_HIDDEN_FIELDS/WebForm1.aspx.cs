using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac8_2_HIDDEN_FIELDS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = TextBox1.Text;
            HiddenField2.Value = TextBox2.Text;
            HiddenField3.Value = TextBox3.Text;
            Label7.Text = HiddenField1.Value.ToString();
            Label8.Text = HiddenField2.Value.ToString();
            Label9.Text = HiddenField3.Value.ToString();

        }

       
    }
}
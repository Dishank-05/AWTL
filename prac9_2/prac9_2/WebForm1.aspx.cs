using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac9_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebService1 obj1 = new WebService1();
            GridView1.DataSource = obj1.DisplayData();
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String Name, Email;
            int Id;
            Id = Int32.Parse(TextBox1.Text);
            Name = TextBox2.Text;
            Email = TextBox3.Text;

            WebService1 obj1 = new WebService1();
            obj1.AddData(Id, Name, Email);
            Label1.Text = "Success";
            GridView1.DataSource = obj1.DisplayData();
            GridView1.DataBind();


        }
    }
}
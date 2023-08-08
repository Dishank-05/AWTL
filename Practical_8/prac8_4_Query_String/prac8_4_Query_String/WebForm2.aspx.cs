using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prac8_4_Query_String
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String Name = Request.QueryString["Name"];
            int Age = int.Parse(Request.QueryString["Age"]);
            String Program = Request.QueryString["Program"];
            Response.Write("Name: " + Name + "</br> Age " + Age + "</br> Program: " +Program);

        }
    }
}
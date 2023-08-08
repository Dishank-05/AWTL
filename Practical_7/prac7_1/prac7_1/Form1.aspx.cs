using System;
using System.Linq;
using System.Web.UI;

namespace prac7_1
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var selectQuery = from a in dc.GetTable<student_21>() select a;
            GridView1.DataSource = selectQuery;
            GridView1.DataBind();
        }
    }
}

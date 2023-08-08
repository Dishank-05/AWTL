using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Prac5_2_Disconnected_Architecture
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "Data Source=RUSHIKESH;Database=rushikesh_21;integrated security=True";
                SqlConnection conn = new SqlConnection(connectionstring);
                SqlDataAdapter dr = new SqlDataAdapter("Select * from student_21", conn);
                DataSet ds = new DataSet();
                dr.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
            catch (Exception error)
            {
                Label1.Text = error.ToString();
                Label1.Visible = true;

            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

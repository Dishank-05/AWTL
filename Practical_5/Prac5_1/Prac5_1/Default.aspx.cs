using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Prac5_1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           try
            {
                string connectionstring = "Data Source=RUSHIKESH;Database=rushikesh_21;integrated security=True";
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM student_21;", conn);
                SqlDataReader dr = cm.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                conn.Close();
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

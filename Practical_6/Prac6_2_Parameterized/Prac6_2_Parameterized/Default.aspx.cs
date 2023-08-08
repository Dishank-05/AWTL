using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace Prac6_2_Parameterized
{
    public partial class _Default : Page
    {
        DataSet ds = new DataSet();
        SqlConnection con;
        //Here we declare the parameter which we have to use in our application
        SqlCommand cmd = new SqlCommand();
        SqlParameter sp1 = new SqlParameter();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source = RUSHIKESH; database=rushikesh_21; integrated security=true";
            con = new SqlConnection(ConString);
            cmd = new SqlCommand("parameter_student_new", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@p1", SqlDbType.Int).Value = int.Parse(TextBox1.Text);
            cmd.Parameters.Add("@p2", SqlDbType.Int).Value = int.Parse(TextBox2.Text);
            Response.Write(TextBox1.Text);

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
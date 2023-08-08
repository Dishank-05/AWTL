using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace prac9_2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable DisplayData()
        {
            SqlConnection con = new SqlConnection("Data Source=RUSHIKESH;Database=rushikesh_21;integrated security=True ");
            SqlDataAdapter a = new SqlDataAdapter("select * from student_21", con);
            con.Open();
            DataSet ds = new DataSet();
            a.Fill(ds, "student_21");
            return ds.Tables[0];
        }
        /*[WebMethod]
        public void AddData(int id, String name, String course, String email)
        {   
        }*/
        internal void AddData(int Id, string Name, string Email)
        {
            SqlConnection con = new SqlConnection("Data Source=RUSHIKESH;Database=rushikesh_21;integrated security=True");
            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT student_21 ON;INSERT INTO student_21(Id, Name, Email) VALUES(@Id, @Name, @Email)");
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);

            cmd.Connection = con;
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace prac7_web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var students = from s in context.student_21s
                                   select new
                                   {
                                       s.Id,
                                       s.Name,
                                       s.Email,
                                       s.Roll_No,
                                       s.Program
                                   };


                    GridView1.DataSource = students;
                    GridView1.DataBind();
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridView1.SelectedIndex;

            if (selectedIndex >= 0)
            {
                GridViewRow selectedRow = GridView1.Rows[selectedIndex];
                txtName.Text = selectedRow.Cells[1].Text; // Assuming the Name column is at index 1
                txtEmail.Text = selectedRow.Cells[2].Text; // Assuming the Email column is at index 2
                // Populate other TextBoxes accordingly
            }
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            int selectedIndex = GridView1.SelectedIndex;

            if (selectedIndex > 0)
            {
                GridView1.SelectedIndex = selectedIndex - 1;
                DisplaySelectedStudent();
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            int selectedIndex = GridView1.SelectedIndex;
            int maxIndex = GridView1.Rows.Count - 1;

            if (selectedIndex < maxIndex)
            {
                GridView1.SelectedIndex = selectedIndex + 1;
                DisplaySelectedStudent();
            }
        }
        private void DisplaySelectedStudent()
        {
            if (GridView1.SelectedIndex >= 0)
            {
                GridViewRow selectedRow = GridView1.SelectedRow;
                txtName.Text = selectedRow.Cells[1].Text;     // Assuming the Name column is at index 1
                txtEmail.Text = selectedRow.Cells[2].Text;    // Assuming the Email column is at index 2
                txtRollNo.Text = selectedRow.Cells[3].Text;   // Assuming the Roll_No column is at index 3
                txtProgram.Text = selectedRow.Cells[4].Text;  // Assuming the Program column is at index 4
            }
        }

    }
}
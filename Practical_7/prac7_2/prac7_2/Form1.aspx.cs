using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace prac7_2
{
    public partial class Form1 : System.Web.UI.Page
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        List<student_21> s = new List<student_21>();
        private int current = 0, length;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                s = (from a in dc.student_21s select a).ToList();
                length = s.Count();

                if (length > 0)
                {
                    id_txt.Text = s[current].Id.ToString();
                    name_txt.Text = s[current].Name.ToString();
                    email_txt.Text = s[current].Email.ToString();
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (current < length - 1)
            {
                current++;
                id_txt.Text = s[current].Id.ToString();
                name_txt.Text = s[current].Name.ToString();
                email_txt.Text = s[current].Email.ToString();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('There is no next record.');", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                current--;
                id_txt.Text = s[current].Id.ToString();
                name_txt.Text = s[current].Name.ToString();
                email_txt.Text = s[current].Email.ToString();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('There is no previous record.');", true);
            }
        }
    }
}

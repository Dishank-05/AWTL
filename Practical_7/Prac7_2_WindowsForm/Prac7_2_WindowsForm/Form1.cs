using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac7_2_WindowsForm
{
    public partial class Form1 : Form
    {
     DataClasses1DataContext dc = new DataClasses1DataContext();
        List<student_21> s = new List<student_21>();
        private int current=0,length;
       
        public Form1()
        {
            InitializeComponent();
            s = (from a in dc.student_21s select a).ToList();
            length = s.Count();

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (current < length - 1)
            {
                id_txt.Text = (s[current].Id).ToString();
                name_txt.Text = (s[current].Name).ToString();
                email_txt.Text = (s[current].Email).ToString();
                current++;
            }
            else
            {
                id_txt.Text = (s[current].Id).ToString();
                name_txt.Text = (s[current].Name).ToString();
                email_txt.Text = (s[current].Email).ToString();
                MessageBox.Show("There Is No Next Record");
            
            }

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                id_txt.Text = (s[current].Id).ToString();
                name_txt.Text = (s[current].Name).ToString();
                email_txt.Text = (s[current].Email).ToString();
                current--;
            }
            else
               
            {
                id_txt.Text = (s[current].Id).ToString();
                name_txt.Text = (s[current].Name).ToString();
                email_txt.Text = (s[current].Email).ToString();
                MessageBox.Show("There Is No Previous Record");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            id_txt.Text = (s[current].Id).ToString();
            name_txt.Text = (s[current].Name).ToString();
            email_txt.Text = (s[current].Email).ToString();

        }

    }
}

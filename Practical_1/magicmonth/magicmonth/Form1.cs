using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace magicmonth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox1.Text);
            int d = Convert.ToInt32(textBox2.Text);
            int y = Convert.ToInt32(textBox3.Text);

            if (d * m == y)
            {
                MessageBox.Show("Month is Magic");

            }
            else
            {
                MessageBox.Show("Month is Not Magic");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MessageBox.Show("Form has been Reset");

        }
    }
}
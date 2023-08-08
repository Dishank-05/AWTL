using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;


namespace Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime selected = dateTimePicker1.Value;
            int age = (int)((today - selected).TotalDays / 365.242199);
            MessageBox.Show("Your present age is " + age+" Years");
        }
    }
}
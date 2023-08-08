using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;



namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox1.Text);
            double convert = 0;

            if (comboBox1.Text == "Fahrenheit")
            {
                convert = (temp * 9 / 5) + 32;
                MessageBox.Show(convert.ToString(), "Celsius to Fahrenheit");
            }

            if (comboBox1.Text == "Celsius")
            {
                convert = (temp - 32) * 5 / 9;
                MessageBox.Show(convert.ToString(), "Fahrenheit to Celsius");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            MessageBox.Show("Form has been Reset");
        }
    }
}
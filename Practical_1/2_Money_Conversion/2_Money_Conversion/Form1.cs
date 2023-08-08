using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;


namespace _2_Money_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amt = Convert.ToInt32(textBox1.Text);
            double converted = 0;
            if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Conversion Formats should be different", "Money Conversion");

            }
            else if (comboBox1.Text == "INR" && comboBox2.Text == "USD")
            {
                converted = amt * 0.012;
            }
            else if (comboBox1.Text == "INR" && comboBox2.Text == "EUR")
            {
                converted = amt * 0.011;
            }
            else if (comboBox1.Text == "USD" && comboBox2.Text == "INR")
            {
                converted = amt * 82.33;
            }
            else if (comboBox1.Text == "USD" && comboBox2.Text == "EUR")

            {
                converted = amt * 0.93;
            }
            else if (comboBox1.Text == "EUR" && comboBox2.Text == "INR")
            {
                converted = amt * 88.69;
            }
            else if (comboBox1.Text == "EUR" && comboBox2.Text == "USD")
            {
                converted = amt * 1.08;
            }
            MessageBox.Show(amt + comboBox1.Text + "=" + converted.ToString() +
                comboBox2.Text, "Money Conversion");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            MessageBox.Show("Form has been Reset");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

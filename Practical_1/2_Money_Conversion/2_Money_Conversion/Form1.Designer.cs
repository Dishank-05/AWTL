namespace _2_Money_Conversion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 26);
            label1.Name = "label1";
            label1.Size = new Size(482, 25);
            label1.TabIndex = 0;
            label1.Text = "Money Conversion Program Implemented by Rushikesh_21";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 76);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 127);
            label3.Name = "label3";
            label3.Size = new Size(187, 25);
            label3.TabIndex = 2;
            label3.Text = "Select FROM Currency";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 186);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 3;
            label4.Text = "Select TO Currency";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(376, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 31);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(225, 265);
            button1.Name = "button1";
            button1.Size = new Size(84, 35);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(376, 265);
            button2.Name = "button2";
            button2.Size = new Size(82, 35);
            button2.TabIndex = 8;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "INR", "USD", "EUR" });
            comboBox1.Location = new Point(376, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 31);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "INR", "USD", "EUR" });
            comboBox2.Location = new Point(376, 180);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 31);
            comboBox2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 690);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(16, 39);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
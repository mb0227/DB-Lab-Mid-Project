namespace Front_end
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 106);
            label1.Name = "label1";
            label1.Size = new Size(118, 27);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(281, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 35);
            textBox1.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(851, 106);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(211, 35);
            textBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(681, 109);
            label7.Name = "label7";
            label7.Size = new Size(118, 27);
            label7.TabIndex = 12;
            label7.Text = "First Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(281, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 35);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 177);
            label2.Name = "label2";
            label2.Size = new Size(117, 27);
            label2.TabIndex = 14;
            label2.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(851, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 35);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(681, 180);
            label3.Name = "label3";
            label3.Size = new Size(118, 27);
            label3.TabIndex = 16;
            label3.Text = "First Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(281, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 35);
            textBox4.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 259);
            label4.Name = "label4";
            label4.Size = new Size(163, 27);
            label4.TabIndex = 18;
            label4.Text = "Registration No";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(851, 251);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(211, 35);
            textBox5.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(681, 254);
            label5.Name = "label5";
            label5.Size = new Size(118, 27);
            label5.TabIndex = 20;
            label5.Text = "First Name";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1146, 642);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Student";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
    }
}
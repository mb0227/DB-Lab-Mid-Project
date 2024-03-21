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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            label5 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label4 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            comboBox1 = new ComboBox();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(842, 111);
            label5.Name = "label5";
            label5.Size = new Size(70, 27);
            label5.TabIndex = 20;
            label5.Text = "Status";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(583, 111);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "yourEmail@gmail.com";
            textBox4.Size = new Size(211, 35);
            textBox4.TabIndex = 19;
            textBox4.Validating += textBox4_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 114);
            label3.Name = "label3";
            label3.Size = new Size(88, 27);
            label3.TabIndex = 16;
            label3.Text = "Contact";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(923, 65);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 35);
            textBox3.TabIndex = 17;
            textBox3.Validating += textBox3_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(800, 68);
            label2.Name = "label2";
            label2.Size = new Size(117, 27);
            label2.TabIndex = 14;
            label2.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 111);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "3341234567";
            textBox2.Size = new Size(211, 35);
            textBox2.TabIndex = 15;
            textBox2.Validating += textBox2_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(455, 60);
            label7.Name = "label7";
            label7.Size = new Size(118, 27);
            label7.TabIndex = 12;
            label7.Text = "First Name";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(583, 60);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(211, 35);
            textBox7.TabIndex = 13;
            textBox7.Validating += textBox7_Validating_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 111);
            label4.Name = "label4";
            label4.Size = new Size(68, 27);
            label4.TabIndex = 18;
            label4.Text = "Email";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(189, 52);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(211, 35);
            textBox6.TabIndex = 22;
            textBox6.Validating += textBox6_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 60);
            label6.Name = "label6";
            label6.Size = new Size(91, 27);
            label6.TabIndex = 23;
            label6.Text = "Reg No.";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Highlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1110, 225);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(189, 165);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 25;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(583, 165);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 26;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(923, 165);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 27;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Active", "Inactive" });
            comboBox1.Location = new Point(923, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 35);
            comboBox1.TabIndex = 28;
            // 
            // button4
            // 
            button4.Location = new Point(72, 446);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 29;
            button4.Text = "Go Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(906, 446);
            button5.Name = "button5";
            button5.Size = new Size(216, 34);
            button5.TabIndex = 30;
            button5.Text = "Mark Attendance";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1146, 642);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Student";
            Text = "Form2";
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox7;
        private TextBox textBox6;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ComboBox comboBox1;
        private Button button5;
        private Button button4;
    }
}
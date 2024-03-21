namespace Front_end
{
    partial class Attendance
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 81);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Registration Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 188);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 135);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // button1
            // 
            button1.Location = new Point(556, 338);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Homepage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(195, 338);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(377, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 33);
            comboBox1.TabIndex = 6;
            comboBox1.DropDown += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Present", "Absent" });
            comboBox2.Location = new Point(377, 180);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(143, 33);
            comboBox2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(377, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(143, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // Attendance
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Attendance";
            Text = "Attendance";
            Load += Attendance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
    }
}
namespace Front_end
{
    partial class AssesmentComponent
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 72);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 72);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 1;
            label2.Text = "Total Marks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 134);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 2;
            label3.Text = "Assesment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 134);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Rubric";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(574, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            textBox2.Validating += textBox2_Validating;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(207, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 33);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(574, 126);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 33);
            comboBox2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(82, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(559, 194);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(559, 255);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(559, 310);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(559, 366);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 12;
            button4.Text = "HomePage";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // AssesmentComponent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AssesmentComponent";
            Text = "AssesmentComponent";
            Load += AssesmentComponent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}
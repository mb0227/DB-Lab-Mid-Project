namespace Front_end
{
    partial class Rubric
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 66);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Details";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 31);
            textBox1.TabIndex = 3;
            textBox1.Validating += textBox1_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 69);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 4;
            label2.Text = "CLO";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(546, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(385, 158);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Add Rubric";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(647, 373);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "HomePage";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(244, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Rubric
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Rubric";
            Text = "Rubric";
            Load += Rubric_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
    }
}
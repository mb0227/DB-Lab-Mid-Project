using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_end
{
    public partial class Assesment : Form
    {
        public Assesment()
        {
            InitializeComponent();
        }

        private void Assesment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

                string cmd = "INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES (@Title, @DateCreated, @TotalMarks, @TotalWeightage)";

                SqlConnection con = new SqlConnection(conURL);
                con.Open();

                SqlCommand command = new SqlCommand(cmd, con);
                DateTime currentDateTime = DateTime.Now;

                command.Parameters.AddWithValue("@Title", textBox1.Text);
                command.Parameters.AddWithValue("@DateCreated", currentDateTime);
                command.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
                command.Parameters.AddWithValue("@TotalWeightage", textBox3.Text);
                command.ExecuteNonQuery();
                con.Close();

                ClearText();
                MessageBox.Show("Data Inserted Successfully!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Assessment", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearText()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "Title cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int value;
            if (!int.TryParse(textBox2.Text, out value) || value <= 0 || value >= 100)
            {
                errorProvider2.SetError(textBox, "Please enter a positive integer greater than 0 and less than 100.");
                textBox2.Focus();
                e.Cancel = true;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int value;
            if (!int.TryParse(textBox3.Text, out value) || value <= 0 || value >= 40)
            {
                errorProvider3.SetError(textBox, "Please enter a positive integer greater than 0 and less than 40.");
                e.Cancel = true;
            }
            else
            {
                errorProvider3.SetError(textBox, "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AssesmentComponent a = new AssesmentComponent();
            a.Show();
            this.Hide();
        }
    }
}

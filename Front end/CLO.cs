using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_end
{
    public partial class CLO : Form
    {
        public CLO()
        {
            InitializeComponent();
        }

        private void CLO_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

                string cmd = "INSERT INTO CLO (Name, DateCreated, DateUpdated) VALUES (@Name, @DateCreated, @DateUpdated)";

                SqlConnection con = new SqlConnection(conURL);
                con.Open();

                SqlCommand command = new SqlCommand(cmd, con);
                DateTime currentDateTime = DateTime.Now;

                command.Parameters.AddWithValue("@Name", textBox1.Text);
                command.Parameters.AddWithValue("@DateCreated", currentDateTime);
                command.Parameters.AddWithValue("@DateUpdated", currentDateTime);
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

        private void ClearText()
        {
            textBox1.Text = "";
        }

        private void LoadData()
        {
            string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM CLO", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                DateTime currentDateTime = DateTime.Now;

                string cmd = string.Format($"UPDATE CLO SET Name = @Name, DateUpdated=@DateUpdated WHERE Id = {id}");

                using (SqlConnection con = new SqlConnection(conURL))
                {
                    con.Open();

                    SqlCommand command = new SqlCommand(cmd, con);
                    command.Parameters.AddWithValue("@Name", textBox1.Text);
                    command.Parameters.AddWithValue("@DateUpdated", currentDateTime);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully!");
                }
                ClearText();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }
    }
}

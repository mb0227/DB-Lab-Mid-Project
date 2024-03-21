using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Front_end
{
    public partial class RubricLevel : Form
    {
        public RubricLevel()
        {
            InitializeComponent();
            fillComboBoxData();
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

        private void fillComboBoxData()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID FROM Rubric";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["ID"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadData()
        {
            string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM RubricLevel", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearText()
        {
            textBox1.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
                string cmd = "INSERT INTO RubricLevel (RubricID, Details, MeasurementLevel) VALUES (@RubricID, @Details, @MeasurementLevel)";

                SqlConnection con = new SqlConnection(conURL);
                con.Open();

                SqlCommand command = new SqlCommand(cmd, con);
                DateTime currentDateTime = DateTime.Now;


                command.Parameters.AddWithValue("@RubricID", comboBox1.Text);
                command.Parameters.AddWithValue("@Details", textBox1.Text);
                command.Parameters.AddWithValue("@MeasurementLevel", comboBox2.Text);
                command.ExecuteNonQuery();
                ClearText();
                MessageBox.Show("Data Inserted Successfully!");
                LoadData();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                DateTime currentDateTime = DateTime.Now;

                string cmd = string.Format($"UPDATE RubricLevel SET RubricID=@RubricID, Details=@Details, MeasurementLevel=@MeasurementLevel WHERE Id = {id}");

                using (SqlConnection con = new SqlConnection(conURL))
                {
                    con.Open();


                    SqlCommand command = new SqlCommand(cmd, con);
                    command.Parameters.AddWithValue("@RubricID", comboBox1.Text);
                    command.Parameters.AddWithValue("@Details", textBox1.Text);
                    command.Parameters.AddWithValue("@MeasurementLevel", comboBox2.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
                string cmd = "DELETE FROM RubricLevel WHERE Id = @Id";

                using (SqlConnection con = new SqlConnection(conURL))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(cmd, con);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfully!");
                }

                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

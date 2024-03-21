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
    public partial class AssesmentComponent : Form
    {
        public AssesmentComponent()
        {
            InitializeComponent();
            fillCBData();
            fillCB2Data();
            LoadData();
        }

        private void AssesmentComponent_Load(object sender, EventArgs e)
        {
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
            if (!int.TryParse(textBox2.Text, out value) || value <= 0 || value >= 40)
            {
                errorProvider2.SetError(textBox, "Please enter a positive integer greater than 0 and less than 40.");
                e.Cancel = true;
            }
            else
            {
                errorProvider2.SetError(textBox, "");
            }
        }

        private void fillCBData()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Title FROM Assessment";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Title"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void fillCB2Data()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Details FROM Rubric";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    comboBox2.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["Details"].ToString());
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
            SqlCommand command = new SqlCommand("SELECT * FROM AssessmentComponent", con);
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
        }

        public int GetAssessmentID()
        {
            int id = -1;
            if (comboBox1.SelectedItem != null)
            {
                string name = comboBox1.SelectedItem.ToString();

                SqlConnection con = new SqlConnection("Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True");
                con.Open();

                string query = string.Format("SELECT Id FROM Assessment WHERE (Title = '{0}')", name);
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                }
                con.Close();
                return id;
            }
            return id;
        }

        public int GetRubricID()
        {
            int id = -1;
            if (comboBox1.SelectedItem != null)
            {
                string name = comboBox2.SelectedItem.ToString();

                SqlConnection con = new SqlConnection("Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True");
                con.Open();

                string query = string.Format("SELECT Id FROM Rubric WHERE (Details = '{0}')", name);
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                }
                con.Close();
                return id;
            }
            return id;//rubric doesnt exist
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
                string cmd = "INSERT INTO AssessmentComponent (Name, RubricID, TotalMarks, DateCreated,DateUpdated, AssessmentID) VALUES (@Name, @RubricID, @TotalMarks, @DateCreated,@DateUpdated, @AssessmentID)";

                SqlConnection con = new SqlConnection(conURL);
                con.Open();

                SqlCommand command = new SqlCommand(cmd, con);
                DateTime currentDateTime = DateTime.Now;

                int rubricId = GetRubricID();
                int assessmentId = GetAssessmentID();

                if (rubricId != -1 && assessmentId != -1)
                {
                    command.Parameters.AddWithValue("@Name", textBox1.Text);
                    command.Parameters.AddWithValue("@RubricID", rubricId);
                    command.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
                    command.Parameters.AddWithValue("@DateCreated", currentDateTime);
                    command.Parameters.AddWithValue("@DateUpdated", currentDateTime);
                    command.Parameters.AddWithValue("@AssessmentID", assessmentId);
                    command.ExecuteNonQuery();
                    ClearText();
                    MessageBox.Show("Data Inserted Successfully!");
                    LoadData();
                }
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

                string cmd = string.Format($"UPDATE AssessmentComponent SET Name = @Name,RubricID=@RubricID,TotalMarks=@TotalMarks, DateUpdated=@DateUpdated,AssessmentID=@AssessmentID WHERE Id = {id}");

                using (SqlConnection con = new SqlConnection(conURL))
                {
                    con.Open();

                    int rubricId = GetRubricID();
                    int assessmentId = GetAssessmentID();

                    SqlCommand command = new SqlCommand(cmd, con);
                    command.Parameters.AddWithValue("@Name", textBox1.Text);
                    command.Parameters.AddWithValue("@RubricID", rubricId);
                    command.Parameters.AddWithValue("@TotalMarks", textBox2.Text);
                    command.Parameters.AddWithValue("@DateUpdated", currentDateTime);
                    command.Parameters.AddWithValue("@AssessmentID", assessmentId);
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
                string cmd = "DELETE FROM AssessmentComponent WHERE Id = @Id";

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


        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
 
    }
}

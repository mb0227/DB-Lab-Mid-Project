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
    public partial class StudentResult : Form
    {
        public StudentResult()
        {
            InitializeComponent();
            fillComboBox1Data();
            fillComboBox2Data();
            fillComboBox3Data();
            LoadData();
        }

        private void fillComboBox1Data()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, FirstName + ' ' + LastName AS StudentName FROM Student";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["StudentName"].ToString()); // Changed to StudentName
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void fillComboBox3Data()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name FROM AssessmentComponent";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    comboBox3.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox3.Items.Add(reader["Name"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void fillComboBox2Data()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Details FROM RubricLevel";
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


        private void StudentResult_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private int GetMaxMarks()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
            int marks = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string comboBoxText = comboBox3.Text;
                string query = $"SELECT TotalMarks FROM AssessmentComponent WHERE Name='{comboBoxText}'";

                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        marks = Convert.ToInt32(reader["TotalMarks"]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HERE: ");
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return marks;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int value;

            if (!int.TryParse(textBox1.Text, out value) || value <= 0 || value >= GetMaxMarks())
            {
                errorProvider1.SetError(textBox, "Please enter a positive integer greater than 0 and less than ." + GetMaxMarks());
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }

        private void LoadData()
        {
            string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM StudentResult", con);
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

        public int GetAssessmentID()
        {
            int id = -1;
            if (comboBox3.SelectedItem != null)
            {
                string name = comboBox3.SelectedItem.ToString();

                SqlConnection con = new SqlConnection("Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True");
                con.Open();

                string query = string.Format("SELECT Id FROM AssessmentComponent WHERE (Name = '{0}')", name);
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

        public int GetStudentID()
        {
            int id = -1;
            if (comboBox1.SelectedItem != null)
            {
                string name = comboBox1.SelectedItem.ToString();

                SqlConnection con = new SqlConnection("Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True");
                con.Open();

                string query = string.Format("SELECT Id FROM Student WHERE (FirstName+' '+LastName = '{0}')", name);
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
            int id = 0;
            if (comboBox2.SelectedItem != null)
            {
                string name = comboBox2.SelectedItem.ToString();

                SqlConnection con = new SqlConnection("Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True");
                con.Open();

                string query = string.Format("SELECT Id FROM RubricLevel WHERE (Details = '{0}')", name);
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                }
                con.Close();
            }
            return id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
                string cmd = "INSERT INTO StudentResult (StudentID, AssessmentComponentId, RubricMeasurementId,EvaluationDate,ObtainedMarks) VALUES (@StudentID, @AssessmentComponentId, @RubricMeasurementId,@EvaluationDate,@ObtainedMarks)";

                SqlConnection con = new SqlConnection(conURL);
                con.Open();

                SqlCommand command = new SqlCommand(cmd, con);

                DateTime selectedDate = dateTimePicker1.Value.Date;

                int id1 = GetStudentID();
                int id2 = GetRubricID();
                int id3 = GetAssessmentID();

                command.Parameters.AddWithValue("@StudentID", id1);
                command.Parameters.AddWithValue("@RubricMeasurementId", id2);
                command.Parameters.AddWithValue("@AssessmentComponentId", id3);
                command.Parameters.AddWithValue("@EvaluationDate", selectedDate);
                command.Parameters.AddWithValue("@ObtainedMarks", textBox1.Text);
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
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}

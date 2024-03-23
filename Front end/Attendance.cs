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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Front_end
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            fillcombobox();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
        }

        private void fillcombobox()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT RegistrationNumber FROM Student";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();

                    reader = command.ExecuteReader();

                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["RegistrationNumber"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Mark Attendance
        {
            string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
            string cmd2 = "INSERT INTO ClassAttendance (AttendanceDate) VALUES (@AttendanceDate)";

            string cmd = "INSERT INTO StudentAttendance (StudentID, AttendanceStatus) VALUES (@StudentID, @AttendanceStatus)";

            SqlConnection con = new SqlConnection(conURL);

            con.Open();

            SqlCommand command2 = new SqlCommand(cmd2, con);
            SqlCommand command = new SqlCommand(cmd, con);

            int valueToInsert = 0;
            if (comboBox2.SelectedItem.ToString() == "Present")
            {
                valueToInsert = 1;
            }
            else if (comboBox2.SelectedItem.ToString() == "Absent")
            {
                valueToInsert = 2;
            }
            else if (comboBox2.SelectedItem.ToString() == "Leave")
            {
                valueToInsert = 3;
            }
            else if (comboBox2.SelectedItem.ToString() == "Late")
            {
                valueToInsert = 4;
            }
            DateTime selectedDate = dateTimePicker1.Value;

            try
            {
                command2.Parameters.AddWithValue("@AttendanceDate", selectedDate);
                command2.ExecuteNonQuery();

                command.Parameters.AddWithValue("@StudentID", GetStudentID());
                command.Parameters.AddWithValue("@AttendanceStatus", valueToInsert);
                command.ExecuteNonQuery();

                MessageBox.Show("Data Inserted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public int GetStudentID()
        {
            int id = -1;
            if (comboBox1.SelectedItem != null)
            {
                string selectedRegistrationNumber = comboBox1.SelectedItem.ToString();
                SqlConnection con = new SqlConnection("Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True");
                con.Open();

                string query = string.Format("SELECT Id FROM Student WHERE (RegistrationNumber = '{0}')", selectedRegistrationNumber);
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                }
                con.Close();
                return id;
            }
            return id;//student doesnt exist
        }

        private void button1_Click(object sender, EventArgs e)
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

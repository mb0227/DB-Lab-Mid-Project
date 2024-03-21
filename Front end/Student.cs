using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_end
{
    public partial class Student : Form
    {

        public Student()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
            errorProvider2 = new ErrorProvider();
            errorProvider3 = new ErrorProvider();
            errorProvider4 = new ErrorProvider();
            errorProvider5 = new ErrorProvider();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Student", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) //Insert
        {
            string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

            string cmd = "INSERT INTO STUDENT (FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, @Status)";
            string cmd2 = "INSERT INTO LOOKUP(Name,Category) VALUES (@Name,@Category)";

            SqlConnection con = new SqlConnection(conURL);

            con.Open();

            SqlCommand command = new SqlCommand(cmd, con);
            SqlCommand command2 = new SqlCommand(cmd2, con);

            int valueToInsert = comboBox1.SelectedItem.ToString() == "Active" ? 5 : 6;

            //command2.Parameters.Add("@Category", "")

            command.Parameters.AddWithValue("@FirstName", textBox7.Text);
            command.Parameters.AddWithValue("@LastName", textBox3.Text);
            command.Parameters.AddWithValue("@Contact", textBox2.Text);
            command.Parameters.AddWithValue("@Email", textBox4.Text);
            command.Parameters.AddWithValue("@RegistrationNumber", textBox6.Text);
            command.Parameters.AddWithValue("@Status", valueToInsert);

            command.ExecuteNonQuery();
            con.Close();

            ClearText();
            MessageBox.Show("Data Inserted Successfully!");
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e) //Update
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
                string cmd = "UPDATE STUDENT SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, RegistrationNumber = @RegistrationNumber, Status = @Status WHERE Id = @Id";

                using (SqlConnection con = new SqlConnection(conURL))
                {
                    con.Open();

                    int valueToInsert = comboBox1.SelectedItem.ToString() == "Active" ? 5 : 0;

                    SqlCommand command = new SqlCommand(cmd, con);
                    command.Parameters.AddWithValue("@Id", studentID);
                    command.Parameters.AddWithValue("@FirstName", textBox7.Text);
                    command.Parameters.AddWithValue("@LastName", textBox3.Text);
                    command.Parameters.AddWithValue("@Contact", textBox2.Text);
                    command.Parameters.AddWithValue("@Email", textBox4.Text);
                    command.Parameters.AddWithValue("@RegistrationNumber", textBox6.Text);
                    command.Parameters.AddWithValue("@Status", valueToInsert);
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


        private void button3_Click(object sender, EventArgs e) //Delete
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int studentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
                string cmd = "DELETE FROM STUDENT WHERE Id = @Id";

                using (SqlConnection con = new SqlConnection(conURL))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand(cmd, con);
                    command.Parameters.AddWithValue("@Id", studentID);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfully!");
                }

                // Reload data after delete
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void ClearText()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox7_Validating_1(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "First name cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string pattern = @"^(201[3-9]|202[0-3])-(CS|CE|PET|ME|EE|AE|CH)-([1-9][0-9]?[0-9]?|600)$";

            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                e.Cancel = true;
                errorProvider2.SetError(textBox, "Please enter a valid registration number in the form 2023-CS-111.");
            }
            else
            {
                errorProvider2.SetError(textBox, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider3.SetError(textBox, "Last name cannot be empty.");
            }
            else
            {
                errorProvider3.SetError(textBox, "");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string email = textBox.Text;

            // Construct the pattern string for email validation
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                e.Cancel = true;
                errorProvider4.SetError(textBox, "Please enter a valid email address.");
            }
            else
            {
                errorProvider4.SetError(textBox, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string contact = textBox.Text;

            // Construct the pattern string for contact validation
            string contactPattern = @"^3\d{9}$";

            if (!Regex.IsMatch(contact, contactPattern))
            {
                e.Cancel = true;
                errorProvider5.SetError(textBox, "Please enter a valid contact number.");
            }
            else
            {
                errorProvider5.SetError(textBox, "");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentResult s = new StudentResult();
            s.Show();
            this.Hide();
        }
    }
}

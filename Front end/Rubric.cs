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
    public partial class Rubric : Form
    {
        public Rubric()
        {
            InitializeComponent();
            LoadData();
            fillcombobox();
        }

        private void Rubric_Load(object sender, EventArgs e)
        {

        }

        private void fillcombobox()
        {
            string connectionString = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name FROM CLO";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["Name"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";

            string cmd = "INSERT INTO Rubric (Details, CloId) VALUES (@Details, @CloId)";

            SqlConnection con = new SqlConnection(conURL);

            con.Open();

            SqlCommand command = new SqlCommand(cmd, con);

            try
            {
                command.Parameters.AddWithValue("@Details", textBox1.Text);
                command.Parameters.AddWithValue("@CloId", GetCloID());
                command.ExecuteNonQuery();

                MessageBox.Show("Data Inserted Successfully!");
                ClearText();
                LoadData();
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

        private void LoadData()
        {
            string conURL = "Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True";
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Rubric", con);
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

        public int GetCloID()
        {
            int id = -1;
            if (comboBox1.SelectedItem != null)
            {
                string name = comboBox1.SelectedItem.ToString();
                SqlConnection con = new SqlConnection("Data Source=BILAL\\MSSQLSERVER01;Initial Catalog=ProjectB;Integrated Security=True");
                con.Open();

                string query = string.Format("SELECT Id FROM CLO WHERE (Name = '{0}')", name);
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

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "Details cannot be empty.");
            }
            else
            {
                errorProvider1.SetError(textBox, "");
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

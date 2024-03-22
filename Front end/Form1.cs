namespace Front_end
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student studentForm = new Student();
            studentForm.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Assesment assesmentForm = new Assesment();
            assesmentForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLO clo = new CLO();
            clo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rubric r = new Rubric();
            r.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RubricLevel r = new RubricLevel();
            r.Show();
            this.Hide();
        }
    }
}

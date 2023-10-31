namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            label1.Text = "current highscore \n " + 0;
            label2.Text = "score \n" + 0;
            button1.Text = "start game";
            button2.Text = "rules";
            pictureBox1.Image = Image.FromFile("pictures/a.jpg");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(); // Replace Form2 with the name of your new form.
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(); // Replace Form2 with the name of your new form.
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
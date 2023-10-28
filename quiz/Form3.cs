using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button1.Text = "Answer 1";
            button2.Text = "Answer 2";
            button3.Text = "Answer 3";
            button4.Text = "Answer 3";

            string a = "blobb blobb? answer1 = blob blob, answer 2 = blobby blobby, answer 3 = blobby blob, answer4 = blobby blob blob";
            TextBox textBox1 = new TextBox();
            textBox1.Text = a;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

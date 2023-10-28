using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form3 : Form
    {
        private string answer = " ";
        private string rightanswer = "answer1";

        public Form3()
        {

            InitializeComponent();
            button1.Text = "Answer 1";
            button2.Text = "Answer 2";
            button3.Text = "Answer 3";
            button4.Text = "Answer 3";

            string a = "blobb blobb? answer1 = blob blob, answer 2 = blobby blobby, answer 3 = blobby blob, answer4 = blobby blob blob";
            textBox1.Text = a;
        }

        private void AnswerChecker()
        {
            if (answer == rightanswer) 
            {
                pictureBox1.Image = Image.FromFile("pictures/a.jpg");
            }
            else 
            {
                pictureBox1.Image = Image.FromFile("pictures/b.jpg");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            answer = "answer1";
            AnswerChecker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answer = "answer2";
            AnswerChecker();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            answer = "answer4";
            AnswerChecker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            answer = "answer3";
            AnswerChecker();
        }
    }
}

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
        private Random rnd = new Random();
        private int rightanswer = 0;
        private int answer = 0;

        public Form3()
        {
            InitializeComponent();
            int a = rnd.Next(0,20);
            int b = rnd.Next(0, 20);
            rightanswer = a + b;
            button1.Text = "Answer 1";
            button2.Text = "Answer 2";
            button3.Text = "Answer 3";
            button4.Text = "Answer 3";
            textBox1.Text = "what is " + a + "plus " + b;

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
            answer = 1;
            AnswerChecker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answer = 2;
            AnswerChecker();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            answer = 3;
            AnswerChecker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            answer = 4;
            AnswerChecker();
        }
    }
}

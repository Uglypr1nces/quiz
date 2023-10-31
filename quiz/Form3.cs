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
        public int points = 0;

        public Form3()
        {
            InitializeComponent();

            int a = rnd.Next(-50,50);
            int b = rnd.Next(-50, 50);
            int c = rnd.Next(-25, 25);
            int d = rnd.Next(-25, 25);
            int e = rnd.Next(-25, 25);

            List<string> operators = new List<string>();
            List<int> numbers = new List<int>();

            numbers.Add(rightanswer);
            numbers.Add(rightanswer + c + 1);
            numbers.Add(rightanswer + d + 3);
            numbers.Add(rightanswer + e -1);

            operators.Add("+");
            operators.Add("-");
            operators.Add("*");
            operators.Add("/");

            int r = rnd.Next(operators.Count);

            string s = operators[r];
            
            if (s == "+")
            {
                rightanswer = a + b;
            }
            else if (s == "-")
            {
                rightanswer = a - b;
            }
            else if (s == "*")
            {
                rightanswer = a * b;
            }
            else if (s == "/")
            {
                rightanswer = a / b;
            }

            button1.Text = "1) " + ;
            button2.Text = "Answer 2";
            button3.Text = "Answer 3";
            button4.Text = "Answer 4";
            textBox1.Text = "what is " + a + s + b;
        }
        private void AnswerChecker()
        {
            if (answer == rightanswer) 
            {
                if (answer < -50 & answer > 50)
                {
                    points = points + 75;
                }
                else if (answer < -25 & answer > 25)
                {
                    points = points + 50;
                }
                else
                {
                    points = points + 25;
                }

                    pictureBox1.Image = Image.FromFile("pictures/a.jpg");
            }
            else 
            {
                pictureBox1.Image = Image.FromFile("pictures/b.jpg");
                points = points - 25;
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

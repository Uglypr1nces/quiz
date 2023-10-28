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
    public partial class Form2 : Form
    {
        private int num1 = 3;
        public Form2()
        {
            InitializeComponent();
            button1.Text = "OK";
            button2.Text = "Understand";
            pictureBox1.Image = Image.FromFile("pictures/b.jpg");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                num1 = num1--;
                if (num1 == 2)
                {
                    num1--;
                    pictureBox1.Image = Image.FromFile("pictures/c.jpg");
                    progressBar1.Value = 30;
                }
                else if (num1 == 1)
                {
                    pictureBox1.Image = Image.FromFile("pictures/a.jpg");
                    progressBar1.Value = 75;
                }
                else if (num1 == 0)
                {
                    pictureBox1.Image = Image.FromFile("pictures/d.jpg");
                    progressBar1.Value = 100;
                }
            
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2.
        }
    }
}

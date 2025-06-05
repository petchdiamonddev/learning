using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(textBox2.Text);
            if (score <= 49)
            {
                label5.Text = "F";
            }
            else if (score <= 54) {
                label5.Text = "D";
            }
            else if (score <= 59)
            {
                label5.Text = "D+";
            }
            else if (score <= 64)
            {
                label5.Text = "C";
            }
            else if (score <= 69)
            {
                label5.Text = "c+";
            }
            else if (score <= 74)
            {
                label5.Text = "B";
            }
            else if (score <= 79)
            {
                label5.Text = "B+";
            }
            else if (score <= 100)
            {
                label5.Text = "A";
            } 
            else {
                label5.Text = "ระดับคะแนนไม่ถูกต้อง";
            }
        }
    }
}

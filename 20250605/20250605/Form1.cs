using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _20250605
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int n = int.Parse(textBox1.Text);
            //int i = 1;
            //int sum = 0;
     


            //while (i<= n)
            //{
            //    label2.Text += i+Environment.NewLine;
            //    sum = sum + i;
            //    i++;
            //}

            //label1.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            int ye = int.Parse(textBox2.Text); // ปีดิบ
            int money = int.Parse(textBox3.Text); // เงิน
            int year = (ye * 12); //ปี 


            int i = 1;
            int sum = 0;

            while ( i <= year)
            {
                sum = sum + money;
                i++;
            }

            label7.Text = sum.ToString();
        }
    }
}

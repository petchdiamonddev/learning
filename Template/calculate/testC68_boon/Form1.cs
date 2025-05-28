using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testC68_boon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // รับค่าจากกล่องข้อความ input1 แล้วเก็บไว้ในตัวแปร payin (เป็น string)
            string payin = input1.Text;

            // รับค่าจากกล่องข้อความ input2 แล้วเก็บไว้ในตัวแปร bonusin (เป็น string)
            string bonusin = input2.Text;

            // แปลงค่าจาก string (payin) ให้เป็นจำนวนเต็ม (int) แล้วเก็บไว้ในตัวแปร pay
            int pay = Int32.Parse(payin);

            // แปลงค่าจาก string (bonusin) ให้เป็นจำนวนเต็ม (int) แล้วเก็บไว้ในตัวแปร bonus
            int bonus = Int32.Parse(bonusin);

            // คำนวณเงินรวมที่ได้ = เงินเดือน + โบนัส
            // โดยคำนวณโบนัสจากเปอร์เซ็นต์: (เงินเดือน * เปอร์เซ็นต์โบนัส / 100) แล้วบวกกับเงินเดือน
            // ใช้ชนิด double เพื่อให้ได้ค่าทศนิยม
            double sumpay = (pay * bonus / 100.0) + pay;

            // คำนวณเฉพาะส่วนของโบนัส (เงินเดือน * เปอร์เซ็นต์โบนัส / 100)
            double sumbonus = (pay * bonus / 100.0);

            // แสดงผลรวมเงินทั้งหมด (เงินเดือน + โบนัส) ใน label1
            // ใช้ ToString("F2") เพื่อให้แสดงทศนิยม 2 ตำแหน่ง (เช่น 1234.50)
            label1.Text = sumpay.ToString("F2");

            // แสดงเฉพาะโบนัสใน label2 โดยแปลงจาก double เป็น string
            label2.Text = sumbonus.ToString();


        }

        private void input1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

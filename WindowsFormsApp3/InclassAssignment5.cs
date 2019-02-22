using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Calculate_Click(object sender, EventArgs e)
        {
            double num = 4.0, denom = 1.0, sum = 0.0;
            string userNum = textBox1.Text;
            int userNum1 = int.Parse(userNum);
            label1_userNum.Text ="" + userNum.ToString() + "  term(s).";

            for (int i = 1; i <= userNum1; i++)
            {
                if (i % 2 == 1)
                {
                    sum += num / denom;
                }

                else
                {
                    sum -= num / denom;
                }

                denom += 2.0;
            }

            label1_answer.Text = " =    " + sum.ToString();


        }
    }
}

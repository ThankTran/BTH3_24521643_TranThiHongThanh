using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double getNum(TextBox tb)
        {
            double num;
            if (double.TryParse(tb.Text, out num))
                return num;
            else
            {
                MessageBox.Show("Invalid number: " + tb.Text);
                throw new Exception("Invalid number");
            }
        }
        private void b_Add_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = getNum(tb_Num1);
                double num2 = getNum(tb_Num2);  
                double ans = num1 + num2;
                tb_Ans.Text = ans.ToString();
            }
            catch (Exception)
            {
                tb_Ans.Text = "Error";
            }
        }

        private void b_Sub_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = getNum(tb_Num1);
                double num2 = getNum(tb_Num2);
                double ans = num1 - num2;
                tb_Ans.Text = ans.ToString();
            }
            catch (Exception)
            {
                tb_Ans.Text = "Error";
            }
        }

        private void b_Mul_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = getNum(tb_Num1);
                double num2 = getNum(tb_Num2);
                double ans = num1 * num2;
                tb_Ans.Text = ans.ToString();
            }
            catch (Exception)
            {
                tb_Ans.Text = "Error";
            }
        }

        private void b_Div_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = getNum(tb_Num1);
                double num2 = getNum(tb_Num2);
                double ans = num1 / num2;
                if (num2 == 0)
                    throw new DivideByZeroException
                        ("Cannot divide by zero");
                tb_Ans.Text = ans.ToString();
            }
            catch (Exception)
            {
                tb_Ans.Text = "Error";
            }
        }
    }
}

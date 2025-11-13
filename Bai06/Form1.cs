using System;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        private double memory = 0;
        private double firstNumber = 0;
        private string operation = "";
        private bool isNewNumber = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string number = btn.Text;

            if (isNewNumber)
            {
                textBox1.Text = number;
                isNewNumber = false;
            }
            else
            {
                if (textBox1.Text == "0" && number == "0")
                    return;

                if (textBox1.Text == "0" && number != ".")
                {
                    textBox1.Text = number;
                }
                else
                {
                    textBox1.Text += number;
                }
            }
        }

        private void bt_Backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void bt_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstNumber = 0;
            operation = "";
            isNewNumber = false;
        }

        private void bt_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            isNewNumber = true;
        }

        private void bt_Dot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0.";
                return;
            }

            if (textBox1.Text.Contains("."))
                return;

            textBox1.Text += ".";
        }

        private void bt_Add_Sub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            if (double.TryParse(textBox1.Text, out double number))
            {
                number = -number;
                textBox1.Text = number.ToString();
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            ExecuteOperation("+");
        }

        private void bt_Sub_Click(object sender, EventArgs e)
        {
            ExecuteOperation("-");
        }

        private void bt_Mul_Click(object sender, EventArgs e)
        {
            ExecuteOperation("*");
        }

        private void bt_Div_Click(object sender, EventArgs e)
        {
            ExecuteOperation("/");
        }

        private void bt_Per_Click(object sender, EventArgs e)
        {
            ExecuteOperation("%");
        }
        private void ExecuteOperation(string op)
        {
            if (textBox1.Text == "ERROR")
                return;

            if (!double.TryParse(textBox1.Text, out double currentNumber))
                return;

            if (operation != "" && !isNewNumber)
            {
                Calculate(currentNumber);
            }
            else
            {
                firstNumber = currentNumber;
            }

            operation = op;
            isNewNumber = true;
        }
        private void Calculate(double secondNumber)
        {
            double result = 0;

            try
            {
                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            textBox1.Text = "ERROR";
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                    case "%":
                        if (secondNumber == 0)
                        {
                            textBox1.Text = "ERROR";
                            return;
                        }
                        result = firstNumber % secondNumber;
                        break;
                }

                textBox1.Text = result.ToString();
                firstNumber = result;
            }
            catch
            {
                textBox1.Text = "ERROR";
            }
        }

        private void bt_Equal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ERROR")
                return;

            if (!double.TryParse(textBox1.Text, out double currentNumber))
                return;

            if (operation != "")
            {
                Calculate(currentNumber);
                operation = "";
                isNewNumber = true;
            }
        }

        private void bt_Sqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                if (number < 0)
                {
                    textBox1.Text = "ERROR";
                    return;
                }
                textBox1.Text = Math.Sqrt(number).ToString();
                isNewNumber = true;
            }
        }

        private void bt_1Div_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                if (number == 0)
                {
                    textBox1.Text = "ERROR";
                    return;
                }
                textBox1.Text = (1 / number).ToString();
                isNewNumber = true;
            }
        }

        private void bt_MC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void bt_MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
            isNewNumber = true;
        }

        private void bt_MS_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                memory = number;
                isNewNumber = true;
            }
        }

        private void bt_MP_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                memory += number;
                isNewNumber = true;
            }
        }
    }
}
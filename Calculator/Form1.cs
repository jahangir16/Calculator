using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;

        double result;
        string Operator = null;

        private void button1_Click(object sender, EventArgs e)
        {
            Operator = "sin";
            if (richTextBox1.Text == "")
            {

                richTextBox1.Text = "sin";

            }
            else
            {
                double number = int.Parse(richTextBox1.Text);
                result = Math.Sin(number);
                richTextBox1.Text = result.ToString();
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {

            num1 = 0;
            num2 = 0;
            result = 0;
            richTextBox1.Text = "";
        }

        private void NumericButtonClick(int number)
        {
            if (result == 0)
            {
                richTextBox1.Text += number.ToString();
            }
            else
            {
                num1 = 0;
                num2 = 0;
                result = 0;
                richTextBox1.Text = "";
                richTextBox1.Text += number.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            NumericButtonClick(1);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            NumericButtonClick(2);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            NumericButtonClick(3);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            NumericButtonClick(4);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            NumericButtonClick(5);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            NumericButtonClick(6);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            NumericButtonClick(7);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            NumericButtonClick(8);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            NumericButtonClick(9);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumericButtonClick(0);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("."))
            {
                richTextBox1.Text += ".";
            }
            else if (richTextBox1.Text.Contains(Operator))
            {
                richTextBox1.Text += ".";
            }

        }

        public void splitString(string Operator)
        {
            // Get the text from the richTextBox1 control
            string inputText = richTextBox1.Text;

            // Split the text based on the operator
            string[] parts = inputText.Split(Operator);

            if (parts.Length > 1)
            {
                string lastPart = parts[parts.Length - 1];
                num2 = double.Parse(lastPart);
            }
            else
            {
                num1 = 0;
                num2 = 0;
                result = 0;
                richTextBox1.Text = "invalid input";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (Operator)
            {
                case "+":

                    splitString(Operator);

                    result = num1 + num2;
                    richTextBox1.Text = result.ToString();

                    break;

                case "-":

                    splitString(Operator);

                    result = num1 - num2;
                    richTextBox1.Text = result.ToString();
                    break;

                case "*":

                    splitString(Operator);

                    result = num1 * num2;
                    richTextBox1.Text = result.ToString();
                    break;

                case "/":
                    splitString(Operator);

                    if (num2 == 0)
                    {
                        num1 = 0;
                        num2 = 0;
                        result = 0;
                        richTextBox1.Text = "Denominator Zero";
                    }
                    else
                    {
                        result = num1 / num2;
                        richTextBox1.Text = result.ToString();
                    }
                    break;

                case "log(":
                    splitString(Operator);

                    if (num2 <= 0)
                    {
                        num1 = 0;
                        num2 = 0;
                        result = 0;
                        richTextBox1.Text = "Invalid input for log10";
                    }
                    else
                    {
                        result = Math.Log10(num2);
                        richTextBox1.Text = result.ToString();
                    }
                    break;


                case "ln":
                    splitString(Operator);
                    result = Math.Log(num2);
                    richTextBox1.Text = result.ToString();
                    break;

                case "√":
                    splitString(Operator);
                    result = Math.Sqrt(num2);
                    richTextBox1.Text = result.ToString();
                    break;

                case "^":
                    splitString(Operator);
                    result = Math.Pow(num2, num1);
                    richTextBox1.Text = result.ToString();
                    break;

                case "1/":
                    splitString(Operator);

                    result = 1 / num2;
                    richTextBox1.Text = result.ToString();
                    break;
                case "sin":
                    splitString(Operator);
                    result = Math.Sin(num2);
                    richTextBox1.Text = result.ToString();
                    break;

                case "cos":
                    splitString(Operator);
                    result = Math.Cos(num2);
                    richTextBox1.Text = result.ToString();
                    break;

                case "tan":
                    splitString(Operator);
                    result = Math.Tan(num2);
                    richTextBox1.Text = result.ToString();
                    break;

            }

        }


        private void button24_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                num1 = result;
                num2 = 0;
                result = 0;
                richTextBox1.Text += "+";
                Operator = "+";

            }
            else
            {
                /* if (!richTextBox1.Text.Contains("."))
                 {
                     num1 = int.Parse(richTextBox1.Text);
                     decimal decVal = Convert.ToDecimal(num1);
                     num1 = decVal;

                 }*/

                num1 = double.Parse(richTextBox1.Text);
                richTextBox1.Text += "+";
                Operator = "+";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                num1 = result;
                num2 = 0;
                result = 0;
                richTextBox1.Text += "-";
                Operator = "-";

            }
            else
            {
                num1 = double.Parse(richTextBox1.Text);
                richTextBox1.Text += "-";
                Operator = "-";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                num1 = result;
                num2 = 0;
                result = 0;
                richTextBox1.Text += "*";
                Operator = "*";

            }
            else
            {
                num1 = double.Parse(richTextBox1.Text);
                richTextBox1.Text += "*";
                Operator = "*";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                num1 = result;
                num2 = 0;
                result = 0;
                richTextBox1.Text += "/";
                Operator = "/";

            }
            else
            {
                num1 = double.Parse(richTextBox1.Text);
                richTextBox1.Text += "/";
                Operator = "/";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal plusmins = decimal.Parse(richTextBox1.Text);
            plusmins = plusmins * -1;
            richTextBox1.Text = plusmins.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            decimal number = decimal.Parse(richTextBox1.Text);
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
                richTextBox1.Text = factorial.ToString();

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Operator = "log(";
            richTextBox1.Text = "log(";
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            Operator = "ln";
            richTextBox1.Text = "ln ";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double Pi = Math.PI;
            if (richTextBox1.Text == null)
            {
                int number = int.Parse(richTextBox1.Text);
                Pi = number * Pi;
                richTextBox1.Text += Pi.ToString();
            }
            else
            {
                richTextBox1.Text += Pi.ToString();
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            Operator = "√";
            richTextBox1.Text = "√";
        }

        private void button11_Click(object sender, EventArgs e)
        {
           /* Operator = "^";
            richTextBox1.Text = "^";*/

            if (result != 0)
            {
                num1 = result;
                num2 = 0;
                result = 0;
                Operator = "^";
                richTextBox1.Text += "^";

            }
            else
            {
                num1 = double.Parse(richTextBox1.Text);
                richTextBox1.Text += "^";
                Operator = "^";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Operator = "1/";
            if (richTextBox1.Text == "")
            {

                richTextBox1.Text = "1/";

            }
            else
            {
                double number = int.Parse(richTextBox1.Text);
                num1 = 1 / number;
                richTextBox1.Text = num1.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Operator = "cos";
            if (richTextBox1.Text == "")
            {

                richTextBox1.Text = "cos";

            }
            else
            {
                double number = int.Parse(richTextBox1.Text);
                result = Math.Cos(number);
                richTextBox1.Text = result.ToString();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Operator = "tan";
            if (richTextBox1.Text == "")
            {

                richTextBox1.Text = "tan";

            }
            else
            {
                double number = int.Parse(richTextBox1.Text);
                result = Math.Tan(number);
                richTextBox1.Text = result.ToString();
            }
        }
    }
}
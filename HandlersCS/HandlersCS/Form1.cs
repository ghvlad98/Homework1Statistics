using System.ComponentModel.Design;

namespace HandlersCS
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculationResultText_Click(object sender, EventArgs e)
        {

        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {   
            if (this.input.Length <= 0)
            {
                return;
            } else
            {
                int l = this.UserInputText.Text.Length;
                this.UserInputText.Text = this.UserInputText.Text.Remove(l - 1);
                this.input = this.input.Remove(l - 1);
            }
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += "7";
            this.UserInputText.Text += input;
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += "8";
            this.UserInputText.Text += input;
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += "9";
            this.UserInputText.Text += input;
        }

        private void ButtonX_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += "4";
            this.UserInputText.Text += input;
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += "5";
            this.UserInputText.Text += input;
        }

        private void ButtonSIx_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += "6";
            this.UserInputText.Text += input;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += "1";
            this.UserInputText.Text += input;
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += "2";
            this.UserInputText.Text += input;
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += "3";
            this.UserInputText.Text += input;
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += "0";
            this.UserInputText.Text += input;
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "";
            input += ".";
            this.UserInputText.Text += input;
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                this.UserInputText.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                this.UserInputText.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                this.UserInputText.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    this.UserInputText.Text = result.ToString();
                    input = result.ToString();
                }
                else
                {
                    this.UserInputText.Text = "Division by zero!";
                }
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void UserInputText_MouseEnter(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.input;
            this.UserInputText.Text = "";
        }

        private void UserInputText_MouseLeave(object sender, EventArgs e)
        {
            this.UserInputText.Text = this.input;
        }
    }
}
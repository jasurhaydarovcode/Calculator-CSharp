using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCSharp
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();

            // Icon file ni build qilish uchun
            this.Icon = new Icon("Calculator.ico");
        }

        // Button Click hodisasi
        private void button_click(object sender, EventArgs e)
        {
            // TextBox da 0 ni olib tashlash
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            // Button'bosilganda TextBox ga jo'natish (NUMBER)
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;

            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        // Operator Button click
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                //button4.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        // CE Button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        // C Button
        private void button3_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            labelCurrentOperation.Text = "";
        }

        // = (equal) Button
        private void button4_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "%":
                    textBox_Result.Text = (resultValue % Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}

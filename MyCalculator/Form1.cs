using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        Double resultValue=0;
        String performedOperation = "";
        bool operationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" || operationPerformed == true)
            { textBoxResult.Clear(); }
            operationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!textBoxResult.Text.Contains("."))
                {
                    textBoxResult.Text = textBoxResult.Text + button.Text;
                }
            }
            else
                textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                Submit.PerformClick();
                performedOperation = button.Text;
                currentOperation.Text = resultValue + " " + performedOperation;
                textBoxResult.Text = "0";
                operationPerformed = true;
            }
            else
            {
                performedOperation = button.Text;
                resultValue = Double.Parse(textBoxResult.Text);
                currentOperation.Text = resultValue + " " + performedOperation;
                textBoxResult.Text = "0";
                operationPerformed = true;
            }

        }
        private void ClearEvent_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void Submit_click(object sender, EventArgs e)
        {
            if (operationPerformed != true)
            {
                switch (performedOperation)
                {
                    case "+":
                        textBoxResult.Text = (resultValue + Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "-":
                        textBoxResult.Text = (resultValue - Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "*":
                        textBoxResult.Text = (resultValue * Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "/":
                        textBoxResult.Text = (resultValue / Double.Parse(textBoxResult.Text)).ToString();
                        break;
                    case "circumference":
                        textBoxResult.Text = (Double.Parse(textBoxResult.Text) * 2 * 3.14).ToString();
                        break;
                    default:
                        break;
                }
                resultValue = Double.Parse(textBoxResult.Text);
                currentOperation.Text = " ";
                operationPerformed = true;
            }
        }

        private void findCircumference_Click(object sender, EventArgs e)
        {
            currentOperation.Text = "Input the radius of the circle";
            performedOperation = "circumference";
        }
    }
}

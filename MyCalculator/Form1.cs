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
    }
}

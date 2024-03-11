using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
            operation = "";
            a = 0;
            b = 0;
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }

        private void One_Click(object sender, EventArgs e)
        {
            if(operation != "^")
                Screen.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (operation != "^")
                Screen.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (operation != "^")
                Screen.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (operation != "^")
                Screen.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (operation != "^")
                Screen.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (operation != "^")
                Screen.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (operation != "^")
                Screen.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (operation != "^")
                Screen.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (operation != "^")
                Screen.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (operation != "^")
                Screen.Text += "0";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (operation != "^")
                Screen.Text += ",";
        }

        string operation = "";
        float a = 0;
        float b = 0;
        float result = 0;

        private void Sum_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                operation = "+";
                a = float.Parse(Screen.Text);
                Screen.Text = "";
            }
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                operation = "-";
                a = float.Parse(Screen.Text);
                Screen.Text = "";
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                operation = "*";
                a = float.Parse(Screen.Text);
                Screen.Text = "";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                operation = "/";
                a = float.Parse(Screen.Text);
                Screen.Text = "";
            }
        }

        private void XtoPower_Click(object sender, EventArgs e)
        {
            if (operation == "")
            {
                operation = "^";
                a = float.Parse(Screen.Text);
                Screen.Text = a + "²";
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if(operation != "")
            {
                b = int.Parse(Screen.Text);
                switch(operation) 
                {
                    case "+":
                        result = a + b;
                        Screen.Text = result.ToString();
                        break;
                    case "-":
                        result = a - b;
                        Screen.Text = result.ToString();
                        break;
                    case "*":
                        result = a * b;
                        Screen.Text = result.ToString();
                        break;
                    case "/":
                        if (a != 0)
                        {
                            result = a / b;
                            Screen.Text = result.ToString();
                        }
                        else
                        {
                            Screen.Text = "Error";
                        }
                        break;
                    case "^":
                        result = a * a;
                        Screen.Text = result.ToString();
                        break;
                }
            }
            operation = "";
            a = 0;
            b = 0;
        }
    }
}

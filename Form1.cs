using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool firstInput = true;

        private void Button1(object sender, EventArgs e)
        {
            if (firstInput)
            {
                Display.Text = "1";
                firstInput = false;
            }
            else
                Display.Text += "1";
        }

        private void Button2(object sender, EventArgs e)
        {
            if (firstInput)
            {
                Display.Text = "2";
                firstInput = false;
            }
            else
                Display.Text += "2";
        }

        private void Button3(object sender, EventArgs e)
        {
            if(firstInput)
            {
                Display.Text += "3";
                firstInput = false;
            }
            else
            Display.Text += "3";
        }

        private void Button4(object sender, EventArgs e)
        {
            Display.Text += "4";
        }

        private void Button5(object sender, EventArgs e)
        {
            Display.Text += "5";
        }

        private void Button6(object sender, EventArgs e)
        {
            Display.Text += "6";
        }

        private void Button7(object sender, EventArgs e)
        {
            Display.Text += "7";
        }

        private void Button8(object sender, EventArgs e)
        {
            Display.Text += "8";
        }

        private void Button9(object sender, EventArgs e)
        {
            Display.Text += "9";
        }

        private void Button0(object sender, EventArgs e)
        {
            Display.Text += "0";
        }

        private void ButtonAddition(object sender, EventArgs e)
        {
            Display.Text += "+";
        }

        private void ButtonSubtraction(object sender, EventArgs e)
        {
            Display.Text += "-";
        }

        private void ButtonMultiplication(object sender, EventArgs e)
        {
            Display.Text += "*";
        }

        private void ButtonDivision(object sender, EventArgs e)
        {
            Display.Text += "/";
        }

        private void ButtonClear(object sender, EventArgs e)
        {
            Display.Clear();
            Display.Text = "0";
            firstInput = true;
        }

        private void ButtonResult(object sender, EventArgs e)
        {

        }
    }
}

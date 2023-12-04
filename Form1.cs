using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void Button1(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "1";
            else
                Input.Text += "1";
        }

        private void Button2(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "2";
            else
                Input.Text += "2";
        }

        private void Button3(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "3";
            else
                Input.Text += "3";
        }

        private void Button4(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "4";
            else
                Input.Text += "4";
        }

        private void Button5(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "5";
            else
                Input.Text += "5";
        }

        private void Button6(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "6";
            else
                Input.Text += "6";

        }

        private void Button7(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "7";
            else
                Input.Text += "7";
        }

        private void Button8(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "8";
            else
                Input.Text += "8";
        }

        private void Button9(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "9";
            else
                Input.Text += "9";
        }

        private void Button0(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "0";
            else
                Input.Text += "0";
        }

        private void ButtonAddition(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "+";
            else
                Input.Text += "+";
        }

        private void ButtonSubtraction(object sender, EventArgs e)
        {
            if (Output.Check())
                Input.Text = "1";
            else
                Input.Text += "-";
        }

        private void ButtonMultiplication(object sender, EventArgs e)
        {
            Input.Text += "*";
        }

        private void ButtonDivision(object sender, EventArgs e)
        {
            Input.Text += "/";
        }

        private void ButtonClear(object sender, EventArgs e)
        {
            Input.Clear();
            Input.Text = "0";
            Output.FirstInput = true;
        }

        private void ButtonResult(object sender, EventArgs e)
        {

        }

    }
}

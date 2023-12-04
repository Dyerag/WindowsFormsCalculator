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
                Current.Text = "1";
            else
                Current.Text += "1";
        }

        private void Button2(object sender, EventArgs e)
        {
            if (Output.Check())
                Current.Text = "2";
            else
                Current.Text += "2";
        }

        private void Button3(object sender, EventArgs e)
        {
            if (Output.Check())
                Current.Text = "3";
            else
                Current.Text += "3";
        }

        private void Button4(object sender, EventArgs e)
        {
            if (Output.Check())
                Current.Text = "4";
            else
                Current.Text += "4";
        }

        private void Button5(object sender, EventArgs e)
        {
            if (Output.Check())
                Current.Text = "5";
            else
                Current.Text += "5";
        }

        private void Button6(object sender, EventArgs e)
        {
            if (Output.Check())
                Current.Text = "6";
            else
                Current.Text += "6";

        }

        private void Button7(object sender, EventArgs e)
        {
            if (Output.Check())
                Current.Text = "7";
            else
                Current.Text += "7";
        }

        private void Button8(object sender, EventArgs e)
        {
            if (Output.Check())
                Current.Text = "8";
            else
                Current.Text += "8";
        }

        private void Button9(object sender, EventArgs e)
        {
            if (Output.Check())
                Current.Text = "9";
            else
                Current.Text += "9";
        }

        private void Button0(object sender, EventArgs e)
        {
            if (Output.Check())
                Current.Text = "0";
            else
                Current.Text += "0";
        }

        private void ButtonAddition(object sender, EventArgs e)
        {
            Input.Addnumbers(Current.Text,Operators.Addition);

            if (Output.Check())
                Current.Text = "+";
            else
                Current.Text += "+";
        }

        private void ButtonSubtraction(object sender, EventArgs e)
        {
            Input.Addnumbers(Current.Text, Operators.Subtraction);
            if (Output.Check())
                Current.Text = "-";
            else
                Current.Text += "-";
        }

        private void ButtonMultiplication(object sender, EventArgs e)
        {
            Input.Addnumbers(Current.Text, Operators.Multiplication);
            Current.Text += "*";
        }

        private void ButtonDivision(object sender, EventArgs e)
        {
            Input.Addnumbers(Current.Text, Operators.Division);
            Current.Text += "/";
        }

        private void ButtonClear(object sender, EventArgs e)
        {
            Current.Clear();
            Current.Text = "0";
            Output.FirstInput = true;
        }

        private void ButtonResult(object sender, EventArgs e)
        {
            Input.Clear();
            Current.Clear();
            Current.Text = "0";
            Output.FirstInput = true;
        }

        private void CurrentBox(object sender, EventArgs e)
        {
            Current.Multiline = true;
            
        }

        private void RecentBox(object sender, EventArgs e)
        {
            Recent.Multiline = true;
            Recent.Clear();
            for (int i = 0; i <= Output.RecentList.Count; i++)
            {
                
            }
        }
    }
}

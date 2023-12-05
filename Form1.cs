using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Came with the WindowsForms template. i believe it sets up the window
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #region Numbers
        // Runs the method when the corresponding button is pressed. This is done via Events.
        // Adds, or replaces the default with, the corresponding number to the textbox.
        // This applies to all the numbered methods below

        private void Button1(object sender, EventArgs e)
        {
            if (Output.Check())
                CurrentDisplay.Text = "1";
            else
                CurrentDisplay.Text += "1";
        }

        private void Button2(object sender, EventArgs e)
        {
            if (Output.Check())
                CurrentDisplay.Text = "2";
            else
                CurrentDisplay.Text += "2";
        }

        private void Button3(object sender, EventArgs e)
        {
            if (Output.Check())
                CurrentDisplay.Text = "3";
            else
                CurrentDisplay.Text += "3";
        }

        private void Button4(object sender, EventArgs e)
        {
            if (Output.Check())
                CurrentDisplay.Text = "4";
            else
                CurrentDisplay.Text += "4";
        }

        private void Button5(object sender, EventArgs e)
        {
            if (Output.Check())
                CurrentDisplay.Text = "5";
            else
                CurrentDisplay.Text += "5";
        }

        private void Button6(object sender, EventArgs e)
        {
            if (Output.Check())
                CurrentDisplay.Text = "6";
            else
                CurrentDisplay.Text += "6";

        }

        private void Button7(object sender, EventArgs e)
        {
            if (Output.Check())
                CurrentDisplay.Text = "7";
            else
                CurrentDisplay.Text += "7";
        }

        private void Button8(object sender, EventArgs e)
        {
            if (Output.Check())
                CurrentDisplay.Text = "8";
            else
                CurrentDisplay.Text += "8";
        }

        private void Button9(object sender, EventArgs e)
        {
            if (Output.Check())
                CurrentDisplay.Text = "9";
            else
                CurrentDisplay.Text += "9";
        }

        private void Button0(object sender, EventArgs e)
        {
            if (Output.Check())
                CurrentDisplay.Text = "0";
            else
                CurrentDisplay.Text += "0";
        }
        #endregion


        #region Operators
        // These methods Corresponds to the operator buttons
        // Once an operator is chosen, another one 

        /// <summary>
        /// Writes the "+" operator to the CurrentDisplay, and indicates that, that is the formula to use.
        /// While redundant, it can be the first input.
        /// Cannot be used, when an operator has already been input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddition(object sender, EventArgs e)
        {
            // When it's the first input
            if (Output.Check())
                CurrentDisplay.Text = "+";
            //when it isn't the first input
            else if (Input.Operator == null)
            {

                CurrentDisplay.Text += " + ";
                Input.AddOperator(Operators.Addition);
            }
        }

        /// <summary>
        /// Writes the "-" operator to the CurrentDisplay, and indicates that, that is the formula to use.
        /// Can be the first input.
        /// Cannot be used, when an operator has already been input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubtraction(object sender, EventArgs e)
        {
            // When it's the first input
            if (Output.Check())
            {
                CurrentDisplay.Text = "-";
            }
            //when it isn't the first input
            else if (Input.Operator == null)
            {
                Input.AddOperator(Operators.Subtraction);
                CurrentDisplay.Text += " - ";
            }
        }

        /// <summary>
        /// Writes the "*" operator to the CurrentDisplay, and indicates that, that is the formula to use.
        /// Cannot be used as the first input.
        /// Cannot be used, when an operator has already been input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMultiplication(object sender, EventArgs e)
        {
            //when an operator hasn't been picked
            if (Input.Operator == null)
            {
                Input.AddOperator(Operators.Multiplication);
                CurrentDisplay.Text += " * ";
            }

        }

        /// <summary>
        /// Writes the "*" operator to the CurrentDisplay, and indicates that, that is the formula to use.
        /// Cannot be used as the first input.
        /// Cannot be used, when an operator has already been input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDivision(object sender, EventArgs e)
        {
            //when an operator hasn't been picked
            if (Input.Operator == null)
            {
                Input.AddOperator(Operators.Division);
                CurrentDisplay.Text += " / ";
            }
        }
        #endregion

        #region Clear and Equal

        /// <summary>
        /// The clear button. Used to empty The CurrentDisplay, input variables and RecentDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear(object sender, EventArgs e)
        {
            RecentDisplay.Clear();
            CurrentDisplay.Clear();
            CurrentDisplay.Text = "0";
            Output.FirstInput = true;
            Input.Clear();
        }

        private void ButtonResult(object sender, EventArgs e)
        {
            char? separator = Formulas.SplitSeparator();
            if (separator != null)
            {
                Input.AddNumbers(CurrentDisplay.Text.Split((char)separator)[0].Trim());
                Input.AddNumbers(CurrentDisplay.Text.Split((char)separator)[1].Trim());
            }

            CurrentDisplay.Text += " = " + Formulas.Formula();

            if (Input.Operator != null && Input.Input1 != 0 && Input.Input2 != null)
            {
                Output.RecentList = Convert.ChangeType(CurrentDisplay.Text, Queue<string>);
                //string intermediate = Current.Text;
                //Output.RecentList = intermediate;
                //Output.AddToRecentList(Current.Text);
                
            }
        }
        #endregion

        private void RecentDisplay_TextChanged(object sender, EventArgs e)
        {
            foreach (string item in Output.RecentList)
                RecentDisplay.Text += item;
        }
    }
}

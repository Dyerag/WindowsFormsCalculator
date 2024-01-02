using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Concurrent;
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
        private void AdditionButton(object sender, EventArgs e)
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
        private void SubtractionButton(object sender, EventArgs e)
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
        private void MultiplicationButton(object sender, EventArgs e)
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
        private void DivisionButton(object sender, EventArgs e)
        {
            //when an operator hasn't been picked
            if (Input.Operator == null)
            {
                Input.AddOperator(Operators.Division);
                CurrentDisplay.Text += " / ";
            }
        }
        #endregion

        #region Clear, Equal, and comma

        /// <summary>
        /// The clear button. Used to empty The CurrentDisplay, input variables and RecentDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton(object sender, EventArgs e)
        {
            RecentDisplayUpdate();
            CurrentDisplay.Clear();
            CurrentDisplay.Text = "0";
            Output.FirstInput = true;
            Input.Clear();
        }

        /// <summary>
        /// Adds the Values to the variables used in the formula, and adds all of it to the list of recently made math
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultButton(object sender, EventArgs e)
        {
            #region Formula
            char? separator = Formulas.SplitSeparator();
            if (separator != null)
            {
                Input.AddNumbers(CurrentDisplay.Text.Split((char)separator)[0].Trim());
                Input.AddNumbers(CurrentDisplay.Text.Split((char)separator)[1].Trim());
            }
            #endregion

            CurrentDisplay.Text += " = " + Formulas.Formula();

            // After the result is written and displayed, everything in the CurrentDisplay is put in the list of prior made equations using this if.
            // This is an if statement, to prevent an adding incomplete equations to the list.
            if (Input.Operator != null && Input.Input1 != null && Input.Input2 != null)
            {
                // CurrentDisplay content must be put in a queue, lest it not be allowed to enter the property
                Queue<string> middlestep = new Queue<string>(new[] { CurrentDisplay.Text });
                Output.RecentList = middlestep;
            }
        }

        private void CommaButton(object sender, EventArgs e)
        {
            if (Input.Operator == null)
            {
                if (!CurrentDisplay.Text.Contains(","))
                {
                    _ = Output.Check();
                    CurrentDisplay.Text += ",";
                }
            }
            else if (!CurrentDisplay.Text.Split((char)Formulas.SplitSeparator())[1].Contains(","))
            {
                if (!int.TryParse(CurrentDisplay.Text[CurrentDisplay.Text.Length - 1].ToString(), out _))
                    CurrentDisplay.Text += "0,";
                else
                    CurrentDisplay.Text += ",";
            }
        }
        #endregion

        public void RecentDisplayUpdate()
        {
            Queue<string> localList = new Queue<string>(Output.RecentList);

            RecentDisplay.Clear();

            while (localList.Count > 0)
                RecentDisplay.Text += localList.Dequeue() + Environment.NewLine;
        }

        private void RecentDisplayEmpty(object sender, EventArgs e)
        {
            if (Output.RecentList.Count == 0)
                RecentDisplay.Text = "No recent mathmatical events done";
        }
    }
}

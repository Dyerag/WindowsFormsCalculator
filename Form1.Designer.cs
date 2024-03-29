﻿namespace WindowsFormsCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CurrentDisplay = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RecentDisplay = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentDisplay
            // 
            this.CurrentDisplay.Enabled = false;
            this.CurrentDisplay.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDisplay.Location = new System.Drawing.Point(22, 13);
            this.CurrentDisplay.Multiline = true;
            this.CurrentDisplay.Name = "CurrentDisplay";
            this.CurrentDisplay.Size = new System.Drawing.Size(327, 80);
            this.CurrentDisplay.TabIndex = 2;
            this.CurrentDisplay.Text = "0";
            this.CurrentDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button16
            // 
            this.button16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button16.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(274, 319);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 132);
            this.button16.TabIndex = 32;
            this.button16.Text = "=";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ResultButton);
            // 
            // button13
            // 
            this.button13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button13.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(22, 319);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 63);
            this.button13.TabIndex = 31;
            this.button13.Text = "7";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button7);
            // 
            // button14
            // 
            this.button14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button14.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(106, 319);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 63);
            this.button14.TabIndex = 30;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button8);
            // 
            // button15
            // 
            this.button15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button15.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(190, 319);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 63);
            this.button15.TabIndex = 29;
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button9);
            // 
            // button10
            // 
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(274, 112);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 63);
            this.button10.TabIndex = 28;
            this.button10.Text = "/";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.DivisionButton);
            // 
            // button11
            // 
            this.button11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(274, 181);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 132);
            this.button11.TabIndex = 27;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ClearButton);
            // 
            // button12
            // 
            this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button12.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(22, 388);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(159, 63);
            this.button12.TabIndex = 26;
            this.button12.Text = "0";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button0);
            // 
            // button9
            // 
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(106, 112);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 63);
            this.button9.TabIndex = 25;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SubtractionButton);
            // 
            // button8
            // 
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(190, 112);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 63);
            this.button8.TabIndex = 24;
            this.button8.Text = "*";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.MultiplicationButton);
            // 
            // button7
            // 
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(22, 181);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 63);
            this.button7.TabIndex = 23;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button1);
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(106, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 63);
            this.button6.TabIndex = 22;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button2);
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(190, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 63);
            this.button5.TabIndex = 21;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button3);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(22, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 63);
            this.button4.TabIndex = 20;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(106, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 63);
            this.button3.TabIndex = 19;
            this.button3.Text = "5";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button5);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(190, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 63);
            this.button2.TabIndex = 18;
            this.button2.Text = "6";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button6);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 17;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AdditionButton);
            // 
            // RecentDisplay
            // 
            this.RecentDisplay.Enabled = false;
            this.RecentDisplay.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentDisplay.Location = new System.Drawing.Point(358, 13);
            this.RecentDisplay.Multiline = true;
            this.RecentDisplay.Name = "RecentDisplay";
            this.RecentDisplay.Size = new System.Drawing.Size(240, 438);
            this.RecentDisplay.TabIndex = 33;
            this.RecentDisplay.Text = "No recent mathmatical events done";
            this.RecentDisplay.TextChanged += new System.EventHandler(this.RecentDisplayEmpty);
            // 
            // button17
            // 
            this.button17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button17.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(190, 388);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 63);
            this.button17.TabIndex = 34;
            this.button17.Text = ",";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.CommaButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 466);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.RecentDisplay);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CurrentDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentDisplay;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RecentDisplay;
        private System.Windows.Forms.Button button17;
    }
}


using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            button13 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            button15 = new System.Windows.Forms.Button();
            button16 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();

           
            SuspendLayout();


       
            button1.Location = new System.Drawing.Point(128, 205);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(228, 205);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(328, 200);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(button3_Click);
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(128, 240);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(button4_Click);
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(228, 240);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(button5_Click);
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(328, 240);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(button6_Click);
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(228, 310);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(94, 29);
            button8.TabIndex = 10;
            button8.Text = "0";
            button8.UseVisualStyleBackColor = true;
            button8.Click += new System.EventHandler(button8_Click);
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(328, 275);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(94, 29);
            button10.TabIndex = 8;
            button10.Text = "2";
            button10.UseVisualStyleBackColor = true;
            button10.Click += new System.EventHandler(button10_Click);
            // 
            // button11
            // 
            button11.Location = new System.Drawing.Point(228, 275);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(94, 29);
            button11.TabIndex = 7;
            button11.Text = "3";
            button11.UseVisualStyleBackColor = true;
            button11.Click += new System.EventHandler(button11_Click);
          
            button12.Location = new System.Drawing.Point(128, 275);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(94, 29);
            button12.TabIndex = 6;
            button12.Text = "1";
            button12.UseVisualStyleBackColor = true;
            button12.Click += new System.EventHandler(button12_Click);
          
            button13.Location = new System.Drawing.Point(458, 205);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(94, 29);
            button13.TabIndex = 12;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += new System.EventHandler(button13_Click);
            // 
            // button14
            // 
            button14.Location = new System.Drawing.Point(458, 240);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(94, 29);
            button14.TabIndex = 13;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += new System.EventHandler(button14_Click);
            // 
            // button15
            // 
            button15.Location = new System.Drawing.Point(458, 275);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(94, 29);
            button15.TabIndex = 14;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = true;
            button15.Click += new System.EventHandler(button15_Click); 
            // 
            // button16
            // 
            button16.Location = new System.Drawing.Point(458, 310);
            button16.Name = "button16";
            button16.Size = new System.Drawing.Size(94, 29);
            button16.TabIndex = 15;
            button16.Text = "*";
            button16.UseVisualStyleBackColor = true;
            button16.Click += new System.EventHandler(button16_Click);
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(303, 165);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(94, 29);
            button7.TabIndex = 17;
            button7.Text = "AC";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(418, 165);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(94, 29);
            button9.TabIndex = 16;
            button9.Text = "=";
            button9.UseVisualStyleBackColor = true;
            button9.Click += new System.EventHandler(button9_Click); 
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(228, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(324, 27);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(302, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(250, 27);
            textBox2.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button8);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
           
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

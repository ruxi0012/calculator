using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string string_de_input = "";
        private string pana_la_semn = "";
        private double rezultat = 0;
        private string semn = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cifrele("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cifrele("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cifrele("9");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cifrele("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cifrele("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cifrele("6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cifrele("0");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cifrele("2");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cifrele("3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cifrele("1");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            semnele_fac("+");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            semnele_fac("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            semnele_fac("/");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            semnele_fac("*");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stergeTOT();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calcul();
            textBox2.Text = rezultat.ToString();
            string_de_input = rezultat.ToString();
        }

        private void cifrele(string digit)
        {
            string_de_input += digit;
            textBox1.Text = string_de_input;
        }

        private void semnele_fac(string operatorText)
        {
            if (!string.IsNullOrEmpty(semn))
            {
                calcul();
                textBox2.Text = rezultat.ToString();
            }

            semn = operatorText;
            pana_la_semn = string_de_input;
            string_de_input = "";
            textBox1.Text = $"{pana_la_semn} {semn} ";
        }

        private void stergeTOT()
        {
            string_de_input = "";
            textBox1.Text = string_de_input;
            rezultat = 0;
            semn = "";
            pana_la_semn = "";
            textBox2.Text = "";
        }


        private void calcul()
        {
            if (double.TryParse(pana_la_semn, out double stanga) && double.TryParse(string_de_input, out double dreapta))
            {
                switch (semn)
                {
                    case "+":
                        rezultat = stanga + dreapta;
                        break;
                    case "-":
                        rezultat = stanga - dreapta;
                        break;
                    case "*":
                        rezultat = stanga * dreapta;
                        break;
                    case "/":
                        if (dreapta != 0)
                        {
                            rezultat = stanga / dreapta;
                        }
                        else
                        {
                            MessageBox.Show("Nu se poate imparti la 0.", "EROARE!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            stergeTOT();
                        }
                        break;
                }
            }
            else
            {

                stergeTOT();
            }
        }

   
    }
}

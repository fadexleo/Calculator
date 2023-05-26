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
        double term1 = 0;
        double term2 = 0;
        double result = 0;
        double operation = 0; 
        /* 
            1 for addition 
            2 for subtraction
            3 for multiplication
            4 for division
            5 for powers
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += "1";
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += "2";
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += "3";
        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += "4";
        }
        private void metroButton5_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += "5";
        }
        private void metroButton6_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += "6";
        }
        private void metroButton7_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += "7";
        }
        private void metroButton8_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += "8";
        }
        private void metroButton9_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += "9";
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += "0";
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text.Length > 0)
            {
                metroTextBox1.Text = metroTextBox1.Text.Substring(0, metroTextBox1.Text.Length - 1);
            } else
            {
                MessageBox.Show("No number.", "Error");
            }
            
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(metroTextBox1.Text, out term1))
            {
                MessageBox.Show("Invalid Characters.", "Error");
            }

            operation = 1;
            
            metroTextBox1.Text = "";
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(metroTextBox1.Text, out term1))
            {
                MessageBox.Show("Invalid Characters.", "Error");
            }

            operation = 2;

            metroTextBox1.Text = "";
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(metroTextBox1.Text, out term1))
            {
                MessageBox.Show("Invalid Characters.", "Error");
            }

            operation = 3;

            metroTextBox1.Text = "";
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(metroTextBox1.Text, out term1))
            {
                MessageBox.Show("Invalid Characters.", "Error");
            }

            operation = 4;

            metroTextBox1.Text = "";
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(metroTextBox1.Text, out term2))
            {
                MessageBox.Show("Invalid Characters.", "Error");
            }
            switch (operation)
            {
                case 0:
                    metroTextBox1.Text = term1.ToString("F");
                    break;
                case 1:
                    result = term1 + term2;
                    metroTextBox1.Text = result.ToString("F");
                    break;

                case 2:
                    result = term1 - term2;
                    metroTextBox1.Text = result.ToString("F");
                    break;

                case 3:
                    result = term1 * term2;
                    metroTextBox1.Text = result.ToString("F");
                    break;

                case 4:
                    if (term2 == 0) { MessageBox.Show("Cannot divide by zero.", "Error"); }
                    result = term1 / term2;
                    metroTextBox1.Text = result.ToString("F");
                    break;

                case 5:
                    result = Math.Pow(term1, term2);
                    metroTextBox1.Text = result.ToString("F");
                    break;
            }

            term2 = 0;

        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(metroTextBox1.Text, out term1))
            {
                MessageBox.Show("Invalid Characters.", "Error");
            }

            operation = 5;

            metroTextBox1.Text = "";
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text += ".";
        }
    }
}

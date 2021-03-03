using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUsage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (!regex.Match(Num1.Text).Success || !regex.Match(Num2.Text).Success)
            {
                MessageBox.Show("Enter Only Numbers", "Wrong Input Type", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                Num1.Text = string.Empty;
                Num2.Text = string.Empty;
            }
            else
            {
                double n1 = Convert.ToDouble(Num1.Text);
                double n2 = Convert.ToDouble(Num2.Text);
                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
                {
                    MessageBox.Show("Select an Operation to Perform", "Missing Operation Type", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (radioButton1.Checked)
                        {
                            MessageBox.Show($"{n1} + {n2} = {n1 + n2}", "Addition Results");
                        }
                        else if (radioButton2.Checked)
                        {
                            MessageBox.Show($"{n1} - {n2} = {n1 - n2}", "Subtraction Results");
                        }
                        else if (radioButton3.Checked)
                        {
                            MessageBox.Show($"{n1} * {n2} = {n1 * n2}", "Multiplication Results");
                        }
                        else if (radioButton4.Checked)
                        {
                            if (n1 == 0 || n2 == 0)
                            {
                                MessageBox.Show("Cannot DivideBy / Divide zero", "Zero Value Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                                Num1.Text = string.Empty;
                                Num2.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show($"{n1} / {n2} = {n1 / n2}", "Division Results");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
    }
}
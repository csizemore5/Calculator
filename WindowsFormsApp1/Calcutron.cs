using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
       
    public partial class Calcutron : Form
    {
        private decimal currentValue;
        private decimal operand1 = 0;
        private decimal operand2 = 0;
        private string op;

        public Calcutron()
        {
            InitializeComponent();
        }

        
        
        public void Caculator() { }


        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            currentValue = Convert.ToDecimal(txtResult.Text);
            else
                txtResult.Text = txtResult.Text + "0";
            currentValue = Convert.ToDecimal(txtResult.Text);
        }
            private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "1";
            currentValue = Convert.ToDecimal(txtResult.Text);
        }

        

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "2";
            currentValue = Convert.ToDecimal(txtResult.Text);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";
            currentValue = Convert.ToDecimal(txtResult.Text);
           
        }



        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "4";
            currentValue = Convert.ToDecimal(txtResult.Text);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "5";
            currentValue = Convert.ToDecimal(txtResult.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "6";
            currentValue = Convert.ToDecimal(txtResult.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text = (txtResult.Text + "7");
            currentValue = Convert.ToDecimal(txtResult.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text = (txtResult.Text + "8");
            currentValue = Convert.ToDecimal(txtResult.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text = (txtResult.Text + "9");
            currentValue = Convert.ToDecimal(txtResult.Text);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            if (operand1 != 0)
            {
                operand2 = currentValue;
            }
            else
                operand1 = currentValue;
            op = "/";
            txtResult.Text = "";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            decimal root = (decimal)Math.Sqrt((double)currentValue);
            txtResult.Text = Convert.ToString(root);
            currentValue = Convert.ToDecimal(txtResult.Text);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StringBuilder removing = new StringBuilder(txtResult.Text);
            if (removing.Length >= 1)
            {
                removing.Length--;
                txtResult.Text = Convert.ToString(removing);
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            operand1 = 0;
            operand2 = 0;
            op = "None";
        }


        private void btnMult_Click(object sender, EventArgs e)
        {
            if (operand1 != 0)

                operand2 = currentValue;
            
            else
                operand1 = currentValue;
            op = "*";
            txtResult.Text = "";
        }

        private void btnRecip_Click(object sender, EventArgs e)
        {
            currentValue = Convert.ToDecimal(txtResult.Text);
            currentValue = 1 / currentValue;
            txtResult.Text = Convert.ToString(currentValue);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            operand2 = Convert.ToDecimal(txtResult.Text);
            try
            {
                if (op == "/")
                {


                    if (operand2 == 0)
                    {
                        MessageBox.Show("The laws of mathematics state you cannot divide by 0! Please restart the equasion.");
                        op = null;
                        operand1 = 0;
                        txtResult.Text = "";
                    }
                    else
                    {
                        currentValue = operand1 / operand2;
                        txtResult.Text = Convert.ToString(currentValue);
                        operand1 = currentValue;
                    }
                }
                if (op == "+")
                {
                    currentValue = operand1 + operand2;
                    txtResult.Text = Convert.ToString(currentValue);
                    operand1 = currentValue;
                }
                if (op == "*")
                {


                    currentValue = operand1 * operand2;
                    txtResult.Text = Convert.ToString(currentValue);
                    operand1 = currentValue;
                }



                if (op == "-")
                {
                    currentValue = operand1 - operand2;
                    txtResult.Text = Convert.ToString(currentValue);
                    operand1 = currentValue;
                }
            }
            catch (OverflowException fe)
            {
                MessageBox.Show(fe.Message + " The calculator" +
                    " has been reset", "Number too large, calculator has been reset");

                operand1 = 0;
                operand2 = 0;
                op = null;
                currentValue = 0;
                txtResult.Text = "";
            }
        }
        

        private void btnMinu_Click(object sender, EventArgs e)
        {if (operand1 != 0)
            {
                operand2 = currentValue;
                txtResult.Text = "";
                op = "-";
            }
        else
            {
                operand1 = Convert.ToDecimal(txtResult.Text);
                op = "-";
                txtResult.Text = "";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (operand1 != 0)
            {
                operand2 = currentValue;
                txtResult.Text = "";
                op = "+";
            }
            else
            {
                operand1 = Convert.ToDecimal(txtResult.Text);
                op = "+";
                txtResult.Text = "";
            }
        }
        private void btnDeci_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains(".")) ;
            else
                txtResult.Text = txtResult.Text + ".";
        }






                private void btnNegpos_Click(object sender, EventArgs e)
                {
                    currentValue = Convert.ToDecimal(txtResult.Text);
                    currentValue = currentValue * -1;
                    txtResult.Text = Convert.ToString(currentValue);

                }


    }
}

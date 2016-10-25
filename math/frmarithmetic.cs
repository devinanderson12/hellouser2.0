using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math
{
    public partial class frmarithmetic : Form
    {
        public frmarithmetic()
        {
            InitializeComponent();
        }

        private void lblsecondnum_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double firstnum = Convert.ToDouble(txtFirstNum.Text);
            double secondNum = Convert.ToDouble(txtsecondnum.Text);

            double sum = firstnum + secondNum;
            double difference = firstnum - secondNum;
            double product = firstnum * secondNum;
            double quotient = firstnum / secondNum;
            double mod = firstnum % secondNum;

            double power = Math.Pow(firstnum, secondNum);
            double root = Math.Pow(secondNum, 1 / firstnum);
            double absOfFirst = Math.Abs(firstnum);
            double absOfSecond = Math.Abs(secondNum);

            lbldisplay.Text = "Your sum is : " + sum;
            lbldisplay.Text += "\nYour difference is " + difference;
            lbldisplay.Text += "\nYour product is " + product;
            lbldisplay.Text += "\nYour quotient is " + quotient;
            lbldisplay.Text += "\nYour modulus is " + mod;
            lbldisplay.Text += "\nYour power is " + power;
            lbldisplay.Text += "\nYour root is " + root;
            lbldisplay.Text += "\nthe absolute value of the first number is " + absOfFirst;
            lbldisplay.Text += "\nthe absolute value of the second number is " + absOfSecond;


        }

        private void lbldisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnhello_Click(object sender, EventArgs e)
        {
            lbldisplay2.Text = "HELLO USER";

            /**
 *
 * Name:Devin 
 * Teacher: hardman
 * Assignment 1#, Program #hellouser
 * Date Last Modified: today
 *
 */
        }

        private void frmarithmetic_Load(object sender, EventArgs e)
        {

        }

        private void btnans_Click(object sender, EventArgs e)
        {
            double costOfGoods = Convert.ToDouble(txtUserCost.Text);
            double taxes = Convert.ToDouble(txtUserTaxes.Text) / 100.0;

            double totalCost = costOfGoods * (1 + taxes);

            lblResult2.Text = String.Format("{0,10}{1,15:C2}\n{2,10}{3,15:P}\n{4,10}{5,15:C2}",
                "Subtotal:", costOfGoods, "Taxes:", taxes, "Total:", totalCost);
        }

        private void lblresult2_Click(object sender, EventArgs e)
        {

        }

        private void btnBYE_Click(object sender, EventArgs e)
        {
            lblDisplay3.Text = "GOOD BYE ";
        }
    }
}

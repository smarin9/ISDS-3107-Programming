using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerExamFall2016
{
    public partial class frmShipping : Form
    {
        public frmShipping()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double dblQuantity, dblPrice;
            if (double.TryParse(txtQuantity.Text, out dblQuantity) && dblQuantity > 0)
            {
                if (radCSharp.Checked)
                    dblPrice = 120;
                else
                    dblPrice = 100;
                GetShipping(dblPrice, dblQuantity);

            }
            else
            {
                txtQuantity.Focus();
                txtQuantity.SelectAll();
                MessageBox.Show("Please enter a number", "Input Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GetShipping(double dblP, double dblQ)
        {
            double dblShipCost = 0, dblTotal = 0;
            if (dblQ < 20)
                dblShipCost = 2;
            else if (dblQ >= 20 && dblQ <= 49)
                dblShipCost = 1;
            else
                dblShipCost = .5;


            dblTotal = dblP * dblQ + dblShipCost;
            lblShipping.Text = dblShipCost.ToString("C");
            lblTotal.Text = dblTotal.ToString("C");


 
        }
    }
}

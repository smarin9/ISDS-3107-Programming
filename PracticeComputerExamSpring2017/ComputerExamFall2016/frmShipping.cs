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

        //7898
        const double dblC_PRICE = 120;
        const double dblVB_PRICE = 100;
        const double dblHIGH_PERTEXT_SHIPCOST = 2;
        const double dblMID_PERTEXT_SHIPCOST = 1;
        const double dblLOW_PERTEXT_SHIPCOST = .5;

        public frmShipping()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            double dblQuantity, dblPrice;

            if (double.TryParse(txtQuantity.Text, out dblQuantity) && dblQuantity > 0)
            {
                if (radCSharp.Checked == true)
                {
                    dblPrice = dblC_PRICE;
                }
                else
                {
                    dblPrice = dblVB_PRICE;
                }
            }
            else
            {
                txtQuantity.Focus();
                txtQuantity.SelectAll();
                MessageBox.Show("Please enter a number", "Input error");


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetShipping(double dblP, double dblQ)
        {
            double dblShipCost = 0, dblTotal = 0;
            if (dblQ < 20)
                dblShipCost = dblHIGH_PERTEXT_SHIPCOST;
            else if (dblQ > 20 && dblQ <= 49)


        }
    }
}

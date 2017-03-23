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
    public partial class frmDetermineTax : Form
    {
        const decimal decSTATE_TAX = .07m;
        const decimal decLOCAL_TAX = .03m;

        public frmDetermineTax()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double dblTaxRate, dblTotalSales;
            dblTotalSales = double.Parse(txtTotalSales.Text);

            if (radStateTax.Checked == true)
            {
                dblTaxRate = (double)decSTATE_TAX;
            }
            else
            {
                dblTaxRate = (double)decLOCAL_TAX; 
            }

            MessageBox.Show("The tax amount is "+ GetTax(dblTotalSales, dblTaxRate),"tax");

        }

        private string GetTax(double dblTS, double dblTR)
        {
            double dblTaxOwed;
            dblTaxOwed
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

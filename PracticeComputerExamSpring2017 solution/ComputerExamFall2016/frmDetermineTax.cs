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

        public frmDetermineTax()
        {
            InitializeComponent();
        }

        //Carolyn Borne
        const double dblSTATE_RATE = .07;
        const double dblLOCAL_RATE = .03;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double dblTaxRate, dblTotalSales;
            dblTotalSales = double.Parse(txtTotalSales.Text);
            if (radLocalTax.Checked)
                dblTaxRate = dblLOCAL_RATE;
            else
                dblTaxRate = dblSTATE_RATE;

            MessageBox.Show("The tax amount is "+GetTax(dblTotalSales, dblTaxRate),"Tax");


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTotalSales.Clear();
            radLocalTax.Checked = false;
            radStateTax.Checked = false;
            txtTotalSales.Focus();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string GetTax(double dblSales, double dblTax)
        {
            double dblTaxOwed;
            dblTaxOwed = dblSales * dblTax;
            return dblTaxOwed.ToString("C");
        }

    }
}

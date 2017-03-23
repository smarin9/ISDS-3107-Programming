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
    public partial class frmLoops : Form
    {
        public frmLoops()
        {
            InitializeComponent();
        }

       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dblTuition;
            int intCount;

            dblTuition = double.Parse(txtTuition.Text);
            for (intCount = 1; intCount <= 5; intCount++)
            {
                dblTuition = dblTuition * 1.05;
                lstTuition.Items.Add("Year " + intCount + " " + dblTuition.ToString("c"));
            }
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            // array declared and given initial values
            double[] dblCollegeTuition;
            dblCollegeTuition = new double[] {5000,7000, 9000, 11000};

            double dblTotal = 0, dblAverage;

            //for(int intCount = 0; intCount < dblCollegeTuition.Length; intCount++)
            //{
            //    dblTotal += dblCollegeTuition[intCount];
            //}

            foreach (double dblCurrentElement in dblCollegeTuition)
            {
                dblTotal += dblCurrentElement;
            }

            dblAverage = dblTotal / dblCollegeTuition.Length;
            lstTuition.Items.Add("The average tuition is " + dblAverage.ToString("c"));         
           
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

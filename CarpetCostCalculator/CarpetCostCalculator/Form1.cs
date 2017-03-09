//Title: Sean's Carpet Cost Estimator
//Author: Sean Marino
//ISDS 3107 - Programming Project 2
//Due Date: March 9, 2017



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpetCostCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void widthText_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //Variables
            double width = double.Parse(widthText.Text);
            double length = double.Parse(lengthText.Text);
            double budgetCost = 0.0;
            double qualityCost = 0.0;
            double luxuryCost = 0.0;
            double budgetInstall = 0.0;
            double qualityInstall = 0.0;
            double luxuryInstall = 0.0;
            double installFee = .10;
            double irregular = .15;
            double nonIrregular = .05;
            double area = 0;
            double areaAfterCutting = 0;

            //Calculates the area of the carpet
            area = width * length;

            //If the radio button is clicked, the irregular carpet value is added. If the button is not clicked, the carpet is assumed non irregular.
            if (irregRadio.Checked == true)
            {
                areaAfterCutting = (area * irregular) + area;
            }
            else
            {
                areaAfterCutting = (area * nonIrregular) + area;
            }
            
            //Calculates the initial cost of the carpet
            budgetCost = areaAfterCutting * 20;
            qualityCost = areaAfterCutting * 40;
            luxuryCost = areaAfterCutting * 60;

            //Calculates the cost of the carpet after the installation fees are added
            budgetInstall = (budgetCost * installFee) + budgetCost;
            qualityInstall = (qualityCost * installFee) + qualityCost;
            luxuryInstall = (luxuryCost * installFee) + luxuryCost;


            //Displays the cost of the carpet before install fees in the list box.
            costList.Items.Add("Budget " + budgetCost.ToString("c"));
            costList.Items.Add("Quality " + qualityCost.ToString("c"));
            costList.Items.Add("Luxury " + luxuryCost.ToString("c"));

            //Displays the cost of the carpet fees after install fees are added in the list box.
            installList.Items.Add("Budget " + budgetInstall.ToString("c"));
            installList.Items.Add("Quality " + qualityInstall.ToString("c"));
            installList.Items.Add("Luxury " + luxuryInstall.ToString("c"));

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //If the exit button is clicked, the program closes.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //If the clear button is clicked, the input and outputs of the form are cleared.
            widthText.Clear();
            lengthText.Clear();
            costList.Items.Clear();
            installList.Items.Clear();
        }
    }
}

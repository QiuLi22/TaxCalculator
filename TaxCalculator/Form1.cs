using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Qiu Li 4/23/2022 Extra Excercise 5-3
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal taxableIncome = Convert.ToDecimal(txtTaxableIncome.Text);
            decimal incomeTaxOwned = 0m;

            if(taxableIncome <= 9875)
            {
                incomeTaxOwned += taxableIncome * 0.1m;
            }else if(taxableIncome >= 9876 && taxableIncome <= 40125)
            {
                incomeTaxOwned = 987.50m + ((taxableIncome - 9875m) * 0.12m);
            }else if(taxableIncome >= 40126 && taxableIncome <= 85525)
            {
                incomeTaxOwned = 4617.50m + (taxableIncome - 40125m) * 0.22m;
            }

            txtIncomeTaxOwed.Text = incomeTaxOwned.ToString();
            txtTaxableIncome.Focus();
        }
    }
}

using System;
using System.Windows.Forms;

namespace buchwasa_Assignment03
{
    public partial class PrimeNumberForm : Form
    {
        public PrimeNumberForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int input = (int)nudPrimeInput.Value;
            Boolean isPrime = PrimeNumberChecker.PrimeNumberChecker.IsPrime(input);
            lblIsPrime.Text = input + " is " + (!isPrime ? "not a prime" : "a prime") + " number";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_09072021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            //This code runs when the button is clicked
            // Gets the text written in txtinput
            String input = txtnput.Text;

            //Sets lblHello to the text of the "input" variable
            lblHello.Text = input;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeViewUtilsNamespace;

namespace InClass_1202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TreeViewUtilities.Clear(tvDemo);
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            TreeViewUtilities.Init(tvDemo);
        }

        private void btnAddPlayerName_Click(object sender, EventArgs e)
        {
            TreeViewUtilities.AddPlayerName(tvDemo, txtPlayerName.Text);
        }

        private void btnAddPlayerNumber_Click(object sender, EventArgs e)
        {
            TreeViewUtilities.AddPlayerNumber(tvDemo, txtPlayerNumber.Text);
        }
    }
}

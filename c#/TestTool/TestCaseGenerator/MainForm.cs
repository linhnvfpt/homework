using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCaseGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            AddCommandDialog addCommandDialog = new AddCommandDialog();
            addCommandDialog.ShowDialog();
        }

        private void frmMain_btnAddCommandParameter_Click(object sender, EventArgs e)
        {
            AddCommandParameters addCommandParameters = new AddCommandParameters();
            addCommandParameters.ShowDialog();
        }
    }
}

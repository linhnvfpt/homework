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
    public partial class AddCommandDialog : Form
    {
        public AddCommandDialog()
        {
            InitializeComponent();
        }

        private void frmAddCommand_btnAdd_Click(object sender, EventArgs e)
        {
            // Get text from text box Name Command
            string nameCommand = frmAddCommand_txtNameCommand.Text;

            // Get main form
            MainForm frmParent = Application.OpenForms["MainForm"] as MainForm;

            // Get list box in main form
            Control[] lstCommand = frmParent.Controls.Find("frmMain_lstCommand", true);
            if (lstCommand.Length > 0)
            {
                ListBox listCommand = (ListBox)lstCommand[0];
                listCommand.Items.Add(nameCommand);
            }
            this.Close();
        }
    }
}

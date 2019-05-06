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

            // Create a new command
            Command newCommand = new Command();
            newCommand.Name = nameCommand;

            // Get main form
            MainForm frmParent = Application.OpenForms["MainForm"] as MainForm;

            // Add a new command into list Command
            frmParent.Commands.Add(newCommand);

            // Get list box in main form
            Control[] lstCommand = frmParent.Controls.Find("frmMain_lstCommand", true);
            if (lstCommand.Length > 0 && !nameCommand.Equals(" "))
            {
                ListBox listCommand = (ListBox)lstCommand[0];
                // Binding to listbox
                listCommand.Items.Add(newCommand.Name);
            }
            this.Close();
        }
    }
}

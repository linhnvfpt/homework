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
    public partial class AddAsssertDialog : Form
    {
        public AddAsssertDialog()
        {
            InitializeComponent();
        }

        private void frmAddNewAssert_btnAdd_Click(object sender, EventArgs e)
        {
            // Get text from text box Name Command
            string nameAssert = frmAddNewAssert_txtName.Text;

            // Create a new assert 
            Assert assert = new Assert();
            assert.Name = nameAssert;

            // Get main form
            MainForm frmParent = Application.OpenForms["MainForm"] as MainForm;

            // Add new assert into list Assert
            frmParent.Asserts.Add(assert);

            // Get list box in main form
            Control[] lstAssert = frmParent.Controls.Find("frmMain_lstAssert", true);
            if (lstAssert.Length > 0 && !nameAssert.Equals(" "))
            {
                ListBox listCommand = (ListBox)lstAssert[0];
                listCommand.Items.Add(assert.Name);
            }
            this.Close();
        }
    }
}

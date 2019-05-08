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
    public partial class AddAssertParameters : Form
    {
        public AddAssertParameters()
        {
            InitializeComponent();
        }

        private void frmAssertParam_btnAdd_Click(object sender, EventArgs e)
        {
            AssertParameters assertParameters;

            // Get main form
            MainForm frmParent = Application.OpenForms["MainForm"] as MainForm;

            // Get command in list Command on MainForm
            Control[] controls = frmParent.Controls.Find("frmMain_lstAssert", true);
            if (controls.Length > 0)
            {
                ListBox listAssert = controls[0] as ListBox;
                string nameAssertSelected = listAssert.GetItemText(listAssert.SelectedItem);
                Assert assertSelected = frmParent.Asserts.Find(x => x.Name.Equals(nameAssertSelected));
                if (assertSelected == null) return;

                // Fill data into object Assert Parameters
                assertParameters.name = frmAssertParam_txtName.Text;
                assertParameters.value = frmAssertParam_txtValue.Text;
                assertParameters.operate = frmAssertParam_txtOperator.Text;
                assertParameters.epsilon = frmAssertParam_txtEpsilon.Text;
                assertSelected.AddParameter(assertParameters);
            }
            else
                return;

            // 

            ListViewItem lvi = new ListViewItem(assertParameters.name);
            lvi.SubItems.Add(assertParameters.value);
            lvi.SubItems.Add(assertParameters.operate);
            lvi.SubItems.Add(assertParameters.epsilon);


            Control[] lstControl = frmParent.Controls.Find("frmMainForm_lstAssertProperties", true);
            if (lstControl.Length > 0)
            {
                ListView lstAssertPamram = (ListView)lstControl[0];
                lstAssertPamram.Items.Add(lvi);
            }
            Close();
        }
    }
}

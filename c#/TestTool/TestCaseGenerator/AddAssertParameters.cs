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
            Assert lastAssert = frmParent.Asserts.Last<Assert>();
            if (lastAssert == null) return;

            // Fill data into object Assert Parameters
            assertParameters.name    = frmAssertParam_txtName.Text;
            assertParameters.value   = frmAssertParam_txtValue.Text;
            assertParameters.operate = frmAssertParam_txtOperator.Text;
            assertParameters.epsilon = frmAssertParam_txtEpsilon.Text;
            lastAssert.AddParameter(assertParameters);

            // 

            ListViewItem lvi = new ListViewItem(assertParameters.name);
            lvi.SubItems.Add(assertParameters.value);
            lvi.SubItems.Add(assertParameters.operate);
            lvi.SubItems.Add(assertParameters.epsilon);


            Control[] lstControl = frmParent.Controls.Find("frmMainForm_lstAssertProperties", true);
            if (lstControl.Length > 0)
            {
                ListView listView = (ListView)lstControl[0];
                listView.Items.Add(lvi);
            }
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcadApp = Bricscad.ApplicationServices.Application;
using Bricscad.EditorInput;
using Teigha.Runtime;
using Teigha.Geometry;

namespace TestCaseGenerator
{
    public partial class AddCommandParameters : Form
    {
        public AddCommandParameters()
        {
            InitializeComponent();
            FormatListViews();
        }

        public void FormatListViews()
        {
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = this.frmAddCommandPara_lstCommandParam.Width / 3;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = this.frmAddCommandPara_lstCommandParam.Width * 2 / 3;
        }

        private void frmAddCommandPara_btnAdd_Click(object sender, EventArgs e)
        {
            // Fill to list
            string selectedType = this.frmAddCommandPara_cboType.GetItemText(this.frmAddCommandPara_cboType.SelectedItem);
            ListViewItem lvi = new ListViewItem(selectedType);
            lvi.SubItems.Add(this.frmAddCommandPara_txtValue.Text);

            if (!frmAddCommandPara_txtValue.Text.Equals(" "))
            {
                frmAddCommandPara_lstCommandParam.Items.Add(lvi);
            }

            // Set item default in combobox Type
            frmAddCommandPara_cboType.SelectedIndex = 0;
            // Clear value in text box Value
            frmAddCommandPara_txtValue.Clear();
        }

        private void frmAddCommandPara_btnSave_Click(object sender, EventArgs e)
        {
            CommandParameters dataItem;
            dataItem.id = 0;

            // Get main form
            MainForm frmParent = Application.OpenForms["MainForm"] as MainForm;
            Command lastCommand = frmParent.Commands.Last<Command>();
            if (lastCommand == null) return;

            // Get data from the list view in dialog AddCommandParameters
            for (int iAt = 0; iAt < frmAddCommandPara_lstCommandParam.Items.Count; iAt++)
            {
                dataItem.id += 1;
                dataItem.type  = frmAddCommandPara_lstCommandParam.Items[iAt].Text;
                dataItem.value = frmAddCommandPara_lstCommandParam.Items[iAt].SubItems[1].Text;
                lastCommand.AddParameter(dataItem);
            }

            // Get list box in main form
            Control[] lstControls = frmParent.Controls.Find("frmMain_lstCommandParameters", true);

            // Fill this list data to list view in dialog MainForm
            if (lstControls.Length > 0)
            {
                ListView lstViewCommandParam = (ListView)lstControls[0];
                lstViewCommandParam.Items.Clear();

                for (int jAt = 0; jAt < lastCommand.GetListParam().Count; jAt++)
                {
                    ListViewItem lvi = new ListViewItem(lastCommand.GetListParam().ElementAt(jAt).type);
                    lvi.SubItems.Add(lastCommand.GetListParam().ElementAt(jAt).value);
                    lstViewCommandParam.Items.Add(lvi);
                }
            }           
            Close();
        }

        private void frmAddCommandPara_lstCommandParam_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void frmAddCommandPara_lstCommandParam_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void frmAddCommandPara_cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Only button Pick Point when select item "Point" in combobox Type
            string selectedItem = frmAddCommandPara_cboType.SelectedItem as string;
            bool visibleButtonPickPoint = false;

            if (selectedItem.Equals("Point"))
                visibleButtonPickPoint = true;
            else
                visibleButtonPickPoint = false;
            frmAddCommandPara_btnPick.Visible = visibleButtonPickPoint;
        }

        private void frmAddCommandPara_btnPick_Click(object sender, EventArgs e)
        {
            // get command line editor and prompt user pick point
            Editor ed = AcadApp.DocumentManager.MdiActiveDocument.Editor;
            Point3d pickPoint = Point3d.Origin;
            PromptPointOptions ptopts = new PromptPointOptions("\nPick location: ");
            PromptPointResult ptRes = ed.GetPoint(ptopts);
            if (ptRes.Status != PromptStatus.OK)
            {
                return;
            }
            pickPoint = ptRes.Value;
            pickPoint = pickPoint.TransformBy(ed.CurrentUserCoordinateSystem);
            string point = pickPoint.ToString();
            // remove character "(" and ")" in string
            char[] charToTrim = { '(', ')' };
            point = point.Trim(charToTrim);
            point = point.Replace(',', ' ');
            frmAddCommandPara_txtValue.Text = point;
        }

        private void frmCommandParam_btnDel_Click(object sender, EventArgs e)
        {
            if (frmAddCommandPara_lstCommandParam.SelectedItems.Count < 0) return;
            foreach (ListViewItem eachItem in frmAddCommandPara_lstCommandParam.SelectedItems)
            {
                frmAddCommandPara_lstCommandParam.Items.Remove(eachItem);
            }
        }
    }
}

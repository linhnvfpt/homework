using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TestCaseGenerator
{
    public partial class MainForm : Form
    {
        public List<Command> Commands;
        public List<Assert> Asserts;

        public MainForm()
        {
            InitializeComponent();
            FormatListViews();

            // Init list Command and list Assert
            Commands = new List<Command>();
            Asserts = new List<Assert>();
        }

        public void FormatListViews()
        {
            // Format list view Command Parameters
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = frmMainForm_lstAssertProperties.Width / 4;
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = frmMainForm_lstAssertProperties.Width / 4;
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // columnHeader3
            //           
            this.columnHeader3.Width = frmMainForm_lstAssertProperties.Width / 4;
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = frmMainForm_lstAssertProperties.Width / 4;
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;


            // Format list view Assert Parameters
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = this.frmMain_lstCommandParameters.Width / 3;
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = this.frmMain_lstCommandParameters.Width * 2 / 3;
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }

        #region event handler buttons Add
        private void frmMainForm_btnAddCommand_Click(object sender, EventArgs e)
        {
            AddCommandDialog addCommandDialog = new AddCommandDialog();
            addCommandDialog.StartPosition = FormStartPosition.CenterParent;
            addCommandDialog.ShowDialog();
        }

        private void frmMainForm_btnAddCommandParameter_Click(object sender, EventArgs e)
        {
            AddCommandParameters addCommandParameters = new AddCommandParameters();
            addCommandParameters.StartPosition = FormStartPosition.CenterParent;
            addCommandParameters.ShowDialog();
        }

        private void frmMainForm_btnAddAssert_Click(object sender, EventArgs e)
        {
            AddAsssertDialog addAsssertDialog = new AddAsssertDialog();
            addAsssertDialog.StartPosition = FormStartPosition.CenterParent;
            addAsssertDialog.ShowDialog();
        }

        private void frmMainForm_btnAddAssertParam_Click(object sender, EventArgs e)
        {
            AddAssertParameters addAssertParameters = new AddAssertParameters();
            addAssertParameters.StartPosition = FormStartPosition.CenterParent;
            addAssertParameters.ShowDialog();
        }

        #endregion

        #region event handler buttons Delete

        private void frmMainForm_btnDelCommand_Click(object sender, EventArgs e)
        {
            // Delete list Command Parameter (in memory) with each object command
            string nameCommandSelected = frmMain_lstCommand.GetItemText(frmMain_lstCommand.SelectedItem);
            Command commandSelected = Commands.Find(x => x.Name.Equals(nameCommandSelected));
            if (commandSelected == null) return;
            commandSelected.GetListParam().Clear();

            // Delete list Command Parameter in GUI
            foreach (ListViewItem item in frmMain_lstCommandParameters.Items)
            {
                item.Remove();
            }

            // Delete object command in list Command (in memory)
            Commands.Remove(commandSelected);

            // Delete list Command in GUI
            int iSeletectedItem = frmMain_lstCommand.SelectedIndex;
            if (iSeletectedItem == -1) return;
            frmMain_lstCommand.Items.RemoveAt(iSeletectedItem);
        }

        private void frmMainForm_btnDelParam_Click(object sender, EventArgs e)
        {
            CommandParameters parameters = new CommandParameters();
            // Get data of item will delete
            if (frmMain_lstCommandParameters.SelectedItems.Count < 0) return;
            foreach (ListViewItem eachItem in frmMain_lstCommandParameters.SelectedItems)
            {
                frmMain_lstCommandParameters.Items.Remove(eachItem);
                parameters.type = eachItem.SubItems[0].Text;
                parameters.value = eachItem.SubItems[1].Text;
            }

            // Get command name is selected
            string nameCommandSelected = frmMain_lstCommand.GetItemText(frmMain_lstCommand.SelectedItem);
            Command commandSelected = Commands.Find(x => x.Name.Equals(nameCommandSelected));
            if (commandSelected == null) return;

            // Delete parameters of command is selected
            commandSelected.GetListParam().Remove(parameters);
        }

        private void frmMainForm_btnDelAssert_Click(object sender, EventArgs e)
        {
            // Delete list Assert Parameter (in memory) with each object command
            string nameAssertSelected = frmMain_lstAssert.GetItemText(frmMain_lstAssert.SelectedItem);
            Assert assertSelected = Asserts.Find(x => x.Name.Equals(nameAssertSelected));
            if (assertSelected == null) return;
            assertSelected.GetListParam().Clear();

            // Delete list Assert Parameter in GUI
            foreach (ListViewItem item in frmMainForm_lstAssertProperties.Items)
            {
                item.Remove();
            }

            // Delete object assert in list Assert (in memory)
            Asserts.Remove(assertSelected);

            // Delete list Assert in GUI
            int iSeletectedItem = frmMain_lstAssert.SelectedIndex;
            if (iSeletectedItem == -1) return;
            frmMain_lstAssert.Items.RemoveAt(iSeletectedItem);          
        }

        private void frmMainForm_btnDelAssertParam_Click(object sender, EventArgs e)
        {
            AssertParameters parameters = new AssertParameters();
            // Get data of item will delete
            if (frmMainForm_lstAssertProperties.SelectedItems.Count < 0) return;
            foreach (ListViewItem eachItem in frmMainForm_lstAssertProperties.SelectedItems)
            {
                frmMainForm_lstAssertProperties.Items.Remove(eachItem);
                parameters.name    = eachItem.SubItems[0].Text;
                parameters.value   = eachItem.SubItems[1].Text;
                parameters.operate = eachItem.SubItems[2].Text;
                parameters.epsilon = eachItem.SubItems[3].Text;
            }

            // Get command name is selected
            string nameAssertSelected = frmMain_lstAssert.GetItemText(frmMain_lstAssert.SelectedItem);
            Assert assertSelected = Asserts.Find(x => x.Name.Equals(nameAssertSelected));
            if (assertSelected == null) return;

            // Delete parameters of command is selected
            assertSelected.GetListParam().Remove(parameters);
        }

        #endregion

        private void frmMain_lstCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get command has name that selected
            string nameCommandSelected = frmMain_lstCommand.GetItemText(frmMain_lstCommand.SelectedItem);
            Command commandSelected = Commands.Find(x => x.Name.Equals(nameCommandSelected));
            if (commandSelected == null) return;

            frmMain_lstCommandParameters.Items.Clear();
            for (int jAt = 0; jAt < commandSelected.GetListParam().Count; jAt++)
            {
                ListViewItem lvi = new ListViewItem(commandSelected.GetListParam().ElementAt(jAt).type); 
                lvi.SubItems.Add(commandSelected.GetListParam().ElementAt(jAt).value);
                frmMain_lstCommandParameters.Items.Add(lvi);
            }
        }

        private void frmMain_lstAssert_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameAssertSelected = frmMain_lstAssert.GetItemText(frmMain_lstAssert.SelectedItem);
            Assert assertSelected = Asserts.Find(x => x.Name.Equals(nameAssertSelected));
            if (assertSelected == null) return;              

            frmMainForm_lstAssertProperties.Items.Clear();
            for(int jAt = 0; jAt < assertSelected.GetListParam().Count; jAt++)
            {
                ListViewItem lvi = new ListViewItem(assertSelected.GetListParam().ElementAt(jAt).name);
                lvi.SubItems.Add(assertSelected.GetListParam().ElementAt(jAt).value);
                lvi.SubItems.Add(assertSelected.GetListParam().ElementAt(jAt).operate);
                lvi.SubItems.Add(assertSelected.GetListParam().ElementAt(jAt).epsilon);
                frmMainForm_lstAssertProperties.Items.Add(lvi);
            }
        }

        private void frmMainForm_btnSave_Click(object sender, EventArgs e)
        {
            // create new xml file
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            // TestCmdArg node
            XmlNode testCmdsNode = doc.CreateElement("TestCmdArg");
            doc.AppendChild(testCmdsNode);

            // write list command
            for(int iAt = 0; iAt < Commands.Count(); iAt++)
            {
                XmlNode cfgCmdNode = doc.CreateElement("command");
                XmlAttribute cfgCmdAtr = doc.CreateAttribute("name");
                cfgCmdAtr.Value = Commands.ElementAt(iAt).Name;
                cfgCmdNode.Attributes.Append(cfgCmdAtr);

                // Get the parameters of command
                Command command = Commands.ElementAt(iAt);
                string type  = "";
                string value = "";
                for(int jAt = 0; jAt < command.GetListParam().Count; jAt++)
                {
                    type = command.GetListParam().ElementAt(jAt).type;
                    value = command.GetListParam().ElementAt(jAt).value;

                    XmlNode cfgCmdParamNode = doc.CreateElement(type.ToLower());
                    XmlAttribute cfgCmdParamAtr = doc.CreateAttribute("value");
                    cfgCmdParamAtr.Value = value;
                    cfgCmdParamNode.Attributes.Append(cfgCmdParamAtr);
                    cfgCmdNode.AppendChild(cfgCmdParamNode);
                }
                testCmdsNode.AppendChild(cfgCmdNode);
            }

            // write list assert
            for(int iIndex = 0; iIndex < Asserts.Count(); iIndex++)
            {
                XmlNode assertNode = doc.CreateElement("assertReference");
                XmlAttribute assertAtr = doc.CreateAttribute("name");
                assertAtr.Value = Asserts.ElementAt(iIndex).Name;
                assertNode.Attributes.Append(assertAtr);

                // Get the parameter of assert
                Assert assert = Asserts.ElementAt(iIndex);
                for(int jIndex = 0; jIndex < assert.GetListParam().Count; jIndex++)
                {
                    XmlNode assertParamNode = doc.CreateElement("Property");
                    // Set attribute "Name"
                    XmlAttribute assertAtrName = doc.CreateAttribute("Name");
                    assertAtrName.Value = assert.GetListParam().ElementAt(jIndex).name;
                    assertParamNode.Attributes.Append(assertAtrName);
                    // Set attribute "Value"
                    XmlAttribute assertAtrValue = doc.CreateAttribute("Value");
                    assertAtrValue.Value = assert.GetListParam().ElementAt(jIndex).value;
                    assertParamNode.Attributes.Append(assertAtrValue);
                    // Set attribute "Operator"
                    XmlAttribute assertAtrOperator = doc.CreateAttribute("Operator");
                    assertAtrOperator.Value = assert.GetListParam().ElementAt(jIndex).operate;
                    assertParamNode.Attributes.Append(assertAtrOperator);
                    // Set attribute "Epsilon"
                    XmlAttribute assertAtrEpsilon = doc.CreateAttribute("Epsilon");
                    assertAtrEpsilon.Value = assert.GetListParam().ElementAt(jIndex).epsilon;
                    assertParamNode.Attributes.Append(assertAtrEpsilon);

                    // Bind into node "Property"
                    assertNode.AppendChild(assertParamNode);
                }
                testCmdsNode.AppendChild(assertNode);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML-File | *.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // save xml file
                doc.Save(saveFileDialog.FileName);
            }
        }
    }
}

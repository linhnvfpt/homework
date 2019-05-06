namespace TestCaseGenerator
{
    partial class AddCommandParameters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.frmAddCommandPara_cboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.frmAddCommandPara_txtValue = new System.Windows.Forms.TextBox();
            this.frmAddCommandPara_btnAdd = new System.Windows.Forms.Button();
            this.frmAddCommandPara_btnSave = new System.Windows.Forms.Button();
            this.frmAddCommandPara_btnPick = new System.Windows.Forms.Button();
            this.frmAddCommandPara_lstCommandParam = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frmCommandParam_btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type Parameter";
            // 
            // frmAddCommandPara_cboType
            // 
            this.frmAddCommandPara_cboType.FormattingEnabled = true;
            this.frmAddCommandPara_cboType.Items.AddRange(new object[] {
            "Int",
            "String",
            "Real",
            "Point"});
            this.frmAddCommandPara_cboType.Location = new System.Drawing.Point(110, 15);
            this.frmAddCommandPara_cboType.Name = "frmAddCommandPara_cboType";
            this.frmAddCommandPara_cboType.Size = new System.Drawing.Size(177, 21);
            this.frmAddCommandPara_cboType.TabIndex = 5;
            this.frmAddCommandPara_cboType.Text = "Int";
            this.frmAddCommandPara_cboType.SelectedIndexChanged += new System.EventHandler(this.frmAddCommandPara_cboType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Value";
            // 
            // frmAddCommandPara_txtValue
            // 
            this.frmAddCommandPara_txtValue.Location = new System.Drawing.Point(110, 53);
            this.frmAddCommandPara_txtValue.Name = "frmAddCommandPara_txtValue";
            this.frmAddCommandPara_txtValue.Size = new System.Drawing.Size(305, 20);
            this.frmAddCommandPara_txtValue.TabIndex = 9;
            // 
            // frmAddCommandPara_btnAdd
            // 
            this.frmAddCommandPara_btnAdd.Location = new System.Drawing.Point(246, 89);
            this.frmAddCommandPara_btnAdd.Name = "frmAddCommandPara_btnAdd";
            this.frmAddCommandPara_btnAdd.Size = new System.Drawing.Size(75, 23);
            this.frmAddCommandPara_btnAdd.TabIndex = 10;
            this.frmAddCommandPara_btnAdd.Text = "Add";
            this.frmAddCommandPara_btnAdd.UseVisualStyleBackColor = true;
            this.frmAddCommandPara_btnAdd.Click += new System.EventHandler(this.frmAddCommandPara_btnAdd_Click);
            // 
            // frmAddCommandPara_btnSave
            // 
            this.frmAddCommandPara_btnSave.Location = new System.Drawing.Point(340, 440);
            this.frmAddCommandPara_btnSave.Name = "frmAddCommandPara_btnSave";
            this.frmAddCommandPara_btnSave.Size = new System.Drawing.Size(75, 23);
            this.frmAddCommandPara_btnSave.TabIndex = 11;
            this.frmAddCommandPara_btnSave.Text = "Save";
            this.frmAddCommandPara_btnSave.UseVisualStyleBackColor = true;
            this.frmAddCommandPara_btnSave.Click += new System.EventHandler(this.frmAddCommandPara_btnSave_Click);
            // 
            // frmAddCommandPara_btnPick
            // 
            this.frmAddCommandPara_btnPick.Location = new System.Drawing.Point(154, 89);
            this.frmAddCommandPara_btnPick.Name = "frmAddCommandPara_btnPick";
            this.frmAddCommandPara_btnPick.Size = new System.Drawing.Size(75, 23);
            this.frmAddCommandPara_btnPick.TabIndex = 12;
            this.frmAddCommandPara_btnPick.Text = "Pick point";
            this.frmAddCommandPara_btnPick.UseVisualStyleBackColor = true;
            this.frmAddCommandPara_btnPick.Visible = false;
            this.frmAddCommandPara_btnPick.Click += new System.EventHandler(this.frmAddCommandPara_btnPick_Click);
            // 
            // frmAddCommandPara_lstCommandParam
            // 
            this.frmAddCommandPara_lstCommandParam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.frmAddCommandPara_lstCommandParam.GridLines = true;
            this.frmAddCommandPara_lstCommandParam.Location = new System.Drawing.Point(15, 131);
            this.frmAddCommandPara_lstCommandParam.Name = "frmAddCommandPara_lstCommandParam";
            this.frmAddCommandPara_lstCommandParam.Size = new System.Drawing.Size(400, 292);
            this.frmAddCommandPara_lstCommandParam.TabIndex = 13;
            this.frmAddCommandPara_lstCommandParam.UseCompatibleStateImageBehavior = false;
            this.frmAddCommandPara_lstCommandParam.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCommandParam_btnDel
            // 
            this.frmCommandParam_btnDel.Location = new System.Drawing.Point(340, 89);
            this.frmCommandParam_btnDel.Name = "frmCommandParam_btnDel";
            this.frmCommandParam_btnDel.Size = new System.Drawing.Size(75, 23);
            this.frmCommandParam_btnDel.TabIndex = 14;
            this.frmCommandParam_btnDel.Text = "Delete";
            this.frmCommandParam_btnDel.UseVisualStyleBackColor = true;
            this.frmCommandParam_btnDel.Click += new System.EventHandler(this.frmCommandParam_btnDel_Click);
            // 
            // AddCommandParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 475);
            this.Controls.Add(this.frmCommandParam_btnDel);
            this.Controls.Add(this.frmAddCommandPara_lstCommandParam);
            this.Controls.Add(this.frmAddCommandPara_btnPick);
            this.Controls.Add(this.frmAddCommandPara_btnSave);
            this.Controls.Add(this.frmAddCommandPara_btnAdd);
            this.Controls.Add(this.frmAddCommandPara_txtValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frmAddCommandPara_cboType);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddCommandParameters";
            this.Text = "Add Command Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox frmAddCommandPara_cboType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox frmAddCommandPara_txtValue;
        private System.Windows.Forms.Button frmAddCommandPara_btnAdd;
        private System.Windows.Forms.Button frmAddCommandPara_btnSave;
        private System.Windows.Forms.Button frmAddCommandPara_btnPick;
        private System.Windows.Forms.ListView frmAddCommandPara_lstCommandParam;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button frmCommandParam_btnDel;
    }
}
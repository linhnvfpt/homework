namespace TestCaseGenerator
{
    partial class MainForm
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
            this.frmMainForm_btnAddCommand = new System.Windows.Forms.Button();
            this.frmMain_lstCommand = new System.Windows.Forms.ListBox();
            this.frmMainForm_btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.frmMainForm_btnDelCommand = new System.Windows.Forms.Button();
            this.frmMain_btnAddCommandParameter = new System.Windows.Forms.Button();
            this.frmMainForm_btnDelParam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.frmMain_lstAssert = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.frmMainForm_btnDelAssertParam = new System.Windows.Forms.Button();
            this.frmMainForm_btnAddAssertParam = new System.Windows.Forms.Button();
            this.frmMainForm_btnDelAssert = new System.Windows.Forms.Button();
            this.frmMainForm_btnAddAssert = new System.Windows.Forms.Button();
            this.frmMainForm_lstAssertProperties = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frmMain_lstCommandParameters = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Commands Test";
            // 
            // frmMainForm_btnAddCommand
            // 
            this.frmMainForm_btnAddCommand.Location = new System.Drawing.Point(196, 5);
            this.frmMainForm_btnAddCommand.Name = "frmMainForm_btnAddCommand";
            this.frmMainForm_btnAddCommand.Size = new System.Drawing.Size(40, 23);
            this.frmMainForm_btnAddCommand.TabIndex = 1;
            this.frmMainForm_btnAddCommand.Text = "+";
            this.frmMainForm_btnAddCommand.UseVisualStyleBackColor = true;
            this.frmMainForm_btnAddCommand.Click += new System.EventHandler(this.frmMainForm_btnAddCommand_Click);
            // 
            // frmMain_lstCommand
            // 
            this.frmMain_lstCommand.FormattingEnabled = true;
            this.frmMain_lstCommand.Location = new System.Drawing.Point(15, 34);
            this.frmMain_lstCommand.Name = "frmMain_lstCommand";
            this.frmMain_lstCommand.Size = new System.Drawing.Size(264, 329);
            this.frmMain_lstCommand.TabIndex = 3;
            this.frmMain_lstCommand.SelectedIndexChanged += new System.EventHandler(this.frmMain_lstCommand_SelectedIndexChanged);
            // 
            // frmMainForm_btnSave
            // 
            this.frmMainForm_btnSave.Location = new System.Drawing.Point(762, 798);
            this.frmMainForm_btnSave.Name = "frmMainForm_btnSave";
            this.frmMainForm_btnSave.Size = new System.Drawing.Size(75, 23);
            this.frmMainForm_btnSave.TabIndex = 4;
            this.frmMainForm_btnSave.Text = "Save";
            this.frmMainForm_btnSave.UseVisualStyleBackColor = true;
            this.frmMainForm_btnSave.Click += new System.EventHandler(this.frmMainForm_btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "List Command Parameters";
            // 
            // frmMainForm_btnDelCommand
            // 
            this.frmMainForm_btnDelCommand.Location = new System.Drawing.Point(242, 5);
            this.frmMainForm_btnDelCommand.Name = "frmMainForm_btnDelCommand";
            this.frmMainForm_btnDelCommand.Size = new System.Drawing.Size(38, 23);
            this.frmMainForm_btnDelCommand.TabIndex = 7;
            this.frmMainForm_btnDelCommand.Text = "-";
            this.frmMainForm_btnDelCommand.UseVisualStyleBackColor = true;
            this.frmMainForm_btnDelCommand.Click += new System.EventHandler(this.frmMainForm_btnDelCommand_Click);
            // 
            // frmMain_btnAddCommandParameter
            // 
            this.frmMain_btnAddCommandParameter.Location = new System.Drawing.Point(754, 4);
            this.frmMain_btnAddCommandParameter.Name = "frmMain_btnAddCommandParameter";
            this.frmMain_btnAddCommandParameter.Size = new System.Drawing.Size(37, 23);
            this.frmMain_btnAddCommandParameter.TabIndex = 8;
            this.frmMain_btnAddCommandParameter.Text = "+";
            this.frmMain_btnAddCommandParameter.UseVisualStyleBackColor = true;
            this.frmMain_btnAddCommandParameter.Click += new System.EventHandler(this.frmMainForm_btnAddCommandParameter_Click);
            // 
            // frmMainForm_btnDelParam
            // 
            this.frmMainForm_btnDelParam.Location = new System.Drawing.Point(797, 4);
            this.frmMainForm_btnDelParam.Name = "frmMainForm_btnDelParam";
            this.frmMainForm_btnDelParam.Size = new System.Drawing.Size(40, 23);
            this.frmMainForm_btnDelParam.TabIndex = 9;
            this.frmMainForm_btnDelParam.Text = "-";
            this.frmMainForm_btnDelParam.UseVisualStyleBackColor = true;
            this.frmMainForm_btnDelParam.Click += new System.EventHandler(this.frmMainForm_btnDelParam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "List Asserts";
            // 
            // frmMain_lstAssert
            // 
            this.frmMain_lstAssert.FormattingEnabled = true;
            this.frmMain_lstAssert.Location = new System.Drawing.Point(15, 412);
            this.frmMain_lstAssert.Name = "frmMain_lstAssert";
            this.frmMain_lstAssert.Size = new System.Drawing.Size(264, 368);
            this.frmMain_lstAssert.TabIndex = 11;
            this.frmMain_lstAssert.SelectedIndexChanged += new System.EventHandler(this.frmMain_lstAssert_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "List Assert Propeties";
            // 
            // frmMainForm_btnDelAssertParam
            // 
            this.frmMainForm_btnDelAssertParam.Location = new System.Drawing.Point(797, 378);
            this.frmMainForm_btnDelAssertParam.Name = "frmMainForm_btnDelAssertParam";
            this.frmMainForm_btnDelAssertParam.Size = new System.Drawing.Size(40, 23);
            this.frmMainForm_btnDelAssertParam.TabIndex = 17;
            this.frmMainForm_btnDelAssertParam.Text = "-";
            this.frmMainForm_btnDelAssertParam.UseVisualStyleBackColor = true;
            this.frmMainForm_btnDelAssertParam.Click += new System.EventHandler(this.frmMainForm_btnDelAssertParam_Click);
            // 
            // frmMainForm_btnAddAssertParam
            // 
            this.frmMainForm_btnAddAssertParam.Location = new System.Drawing.Point(754, 378);
            this.frmMainForm_btnAddAssertParam.Name = "frmMainForm_btnAddAssertParam";
            this.frmMainForm_btnAddAssertParam.Size = new System.Drawing.Size(37, 23);
            this.frmMainForm_btnAddAssertParam.TabIndex = 16;
            this.frmMainForm_btnAddAssertParam.Text = "+";
            this.frmMainForm_btnAddAssertParam.UseVisualStyleBackColor = true;
            this.frmMainForm_btnAddAssertParam.Click += new System.EventHandler(this.frmMainForm_btnAddAssertParam_Click);
            // 
            // frmMainForm_btnDelAssert
            // 
            this.frmMainForm_btnDelAssert.Location = new System.Drawing.Point(239, 382);
            this.frmMainForm_btnDelAssert.Name = "frmMainForm_btnDelAssert";
            this.frmMainForm_btnDelAssert.Size = new System.Drawing.Size(40, 23);
            this.frmMainForm_btnDelAssert.TabIndex = 19;
            this.frmMainForm_btnDelAssert.Text = "-";
            this.frmMainForm_btnDelAssert.UseVisualStyleBackColor = true;
            this.frmMainForm_btnDelAssert.Click += new System.EventHandler(this.frmMainForm_btnDelAssert_Click);
            // 
            // frmMainForm_btnAddAssert
            // 
            this.frmMainForm_btnAddAssert.Location = new System.Drawing.Point(196, 382);
            this.frmMainForm_btnAddAssert.Name = "frmMainForm_btnAddAssert";
            this.frmMainForm_btnAddAssert.Size = new System.Drawing.Size(37, 23);
            this.frmMainForm_btnAddAssert.TabIndex = 18;
            this.frmMainForm_btnAddAssert.Text = "+";
            this.frmMainForm_btnAddAssert.UseVisualStyleBackColor = true;
            this.frmMainForm_btnAddAssert.Click += new System.EventHandler(this.frmMainForm_btnAddAssert_Click);
            // 
            // frmMainForm_lstAssertProperties
            // 
            this.frmMainForm_lstAssertProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.frmMainForm_lstAssertProperties.GridLines = true;
            this.frmMainForm_lstAssertProperties.Location = new System.Drawing.Point(310, 412);
            this.frmMainForm_lstAssertProperties.Name = "frmMainForm_lstAssertProperties";
            this.frmMainForm_lstAssertProperties.Size = new System.Drawing.Size(527, 368);
            this.frmMainForm_lstAssertProperties.TabIndex = 20;
            this.frmMainForm_lstAssertProperties.UseCompatibleStateImageBehavior = false;
            this.frmMainForm_lstAssertProperties.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Operator";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Epsilon";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain_lstCommandParameters
            // 
            this.frmMain_lstCommandParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmMain_lstCommandParameters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.frmMain_lstCommandParameters.GridLines = true;
            this.frmMain_lstCommandParameters.Location = new System.Drawing.Point(310, 34);
            this.frmMain_lstCommandParameters.Name = "frmMain_lstCommandParameters";
            this.frmMain_lstCommandParameters.Size = new System.Drawing.Size(527, 329);
            this.frmMain_lstCommandParameters.TabIndex = 21;
            this.frmMain_lstCommandParameters.UseCompatibleStateImageBehavior = false;
            this.frmMain_lstCommandParameters.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 833);
            this.Controls.Add(this.frmMain_lstCommandParameters);
            this.Controls.Add(this.frmMainForm_lstAssertProperties);
            this.Controls.Add(this.frmMainForm_btnDelAssert);
            this.Controls.Add(this.frmMainForm_btnAddAssert);
            this.Controls.Add(this.frmMainForm_btnDelAssertParam);
            this.Controls.Add(this.frmMainForm_btnAddAssertParam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frmMain_lstAssert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frmMainForm_btnDelParam);
            this.Controls.Add(this.frmMain_btnAddCommandParameter);
            this.Controls.Add(this.frmMainForm_btnDelCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frmMainForm_btnSave);
            this.Controls.Add(this.frmMain_lstCommand);
            this.Controls.Add(this.frmMainForm_btnAddCommand);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TestCaseGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button frmMainForm_btnAddCommand;
        private System.Windows.Forms.ListBox frmMain_lstCommand;
        private System.Windows.Forms.Button frmMainForm_btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button frmMainForm_btnDelCommand;
        private System.Windows.Forms.Button frmMain_btnAddCommandParameter;
        private System.Windows.Forms.Button frmMainForm_btnDelParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox frmMain_lstAssert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button frmMainForm_btnDelAssertParam;
        private System.Windows.Forms.Button frmMainForm_btnAddAssertParam;
        private System.Windows.Forms.Button frmMainForm_btnDelAssert;
        private System.Windows.Forms.Button frmMainForm_btnAddAssert;
        private System.Windows.Forms.ListView frmMainForm_lstAssertProperties;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView frmMain_lstCommandParameters;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}


namespace TestCaseGenerator
{
    partial class AddAsssertDialog
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
            this.frmAddNewAssert_txtName = new System.Windows.Forms.TextBox();
            this.frmAddNewAssert_btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Assert";
            // 
            // frmAddNewAssert_txtName
            // 
            this.frmAddNewAssert_txtName.Location = new System.Drawing.Point(95, 23);
            this.frmAddNewAssert_txtName.Name = "frmAddNewAssert_txtName";
            this.frmAddNewAssert_txtName.Size = new System.Drawing.Size(241, 20);
            this.frmAddNewAssert_txtName.TabIndex = 1;
            // 
            // frmAddNewAssert_btnAdd
            // 
            this.frmAddNewAssert_btnAdd.Location = new System.Drawing.Point(251, 58);
            this.frmAddNewAssert_btnAdd.Name = "frmAddNewAssert_btnAdd";
            this.frmAddNewAssert_btnAdd.Size = new System.Drawing.Size(85, 23);
            this.frmAddNewAssert_btnAdd.TabIndex = 2;
            this.frmAddNewAssert_btnAdd.Text = "Add";
            this.frmAddNewAssert_btnAdd.UseVisualStyleBackColor = true;
            this.frmAddNewAssert_btnAdd.Click += new System.EventHandler(this.frmAddNewAssert_btnAdd_Click);
            // 
            // AddAsssertDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 98);
            this.Controls.Add(this.frmAddNewAssert_btnAdd);
            this.Controls.Add(this.frmAddNewAssert_txtName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddAsssertDialog";
            this.Text = "Add New Assert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frmAddNewAssert_txtName;
        private System.Windows.Forms.Button frmAddNewAssert_btnAdd;
    }
}
namespace TestCaseGenerator
{
    partial class AddAssertParameters
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
            this.frmAssertParam_txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.frmAssertParam_txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.frmAssertParam_txtOperator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.frmAssertParam_txtEpsilon = new System.Windows.Forms.TextBox();
            this.frmAssertParam_btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // frmAssertParam_txtName
            // 
            this.frmAssertParam_txtName.Location = new System.Drawing.Point(81, 21);
            this.frmAssertParam_txtName.Name = "frmAssertParam_txtName";
            this.frmAssertParam_txtName.Size = new System.Drawing.Size(221, 20);
            this.frmAssertParam_txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value";
            // 
            // frmAssertParam_txtValue
            // 
            this.frmAssertParam_txtValue.Location = new System.Drawing.Point(81, 66);
            this.frmAssertParam_txtValue.Name = "frmAssertParam_txtValue";
            this.frmAssertParam_txtValue.Size = new System.Drawing.Size(221, 20);
            this.frmAssertParam_txtValue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operator";
            // 
            // frmAssertParam_txtOperator
            // 
            this.frmAssertParam_txtOperator.Location = new System.Drawing.Point(81, 112);
            this.frmAssertParam_txtOperator.Name = "frmAssertParam_txtOperator";
            this.frmAssertParam_txtOperator.Size = new System.Drawing.Size(221, 20);
            this.frmAssertParam_txtOperator.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Epsilon";
            // 
            // frmAssertParam_txtEpsilon
            // 
            this.frmAssertParam_txtEpsilon.Location = new System.Drawing.Point(81, 157);
            this.frmAssertParam_txtEpsilon.Name = "frmAssertParam_txtEpsilon";
            this.frmAssertParam_txtEpsilon.Size = new System.Drawing.Size(221, 20);
            this.frmAssertParam_txtEpsilon.TabIndex = 7;
            // 
            // frmAssertParam_btnAdd
            // 
            this.frmAssertParam_btnAdd.Location = new System.Drawing.Point(227, 197);
            this.frmAssertParam_btnAdd.Name = "frmAssertParam_btnAdd";
            this.frmAssertParam_btnAdd.Size = new System.Drawing.Size(75, 23);
            this.frmAssertParam_btnAdd.TabIndex = 8;
            this.frmAssertParam_btnAdd.Text = "Add";
            this.frmAssertParam_btnAdd.UseVisualStyleBackColor = true;
            this.frmAssertParam_btnAdd.Click += new System.EventHandler(this.frmAssertParam_btnAdd_Click);
            // 
            // AddAssertParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 247);
            this.Controls.Add(this.frmAssertParam_btnAdd);
            this.Controls.Add(this.frmAssertParam_txtEpsilon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frmAssertParam_txtOperator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frmAssertParam_txtValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frmAssertParam_txtName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AddAssertParameters";
            this.Text = "Add Assert Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frmAssertParam_txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frmAssertParam_txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox frmAssertParam_txtOperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox frmAssertParam_txtEpsilon;
        private System.Windows.Forms.Button frmAssertParam_btnAdd;
    }
}
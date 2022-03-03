namespace CalculatePremiumApp
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblSumInsured = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cboOccupation = new System.Windows.Forms.ComboBox();
            this.lblPremiumValue = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAgeValue = new System.Windows.Forms.Label();
            this.txtSumInsured = new System.Windows.Forms.TextBox();
            this.btnCalcPremium = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(84, 91);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(101, 20);
            this.lblDob.TabIndex = 1;
            this.lblDob.Text = "Date of birth:";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(84, 183);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(94, 20);
            this.lblOccupation.TabIndex = 2;
            this.lblOccupation.Text = "Occupation:";
            // 
            // lblSumInsured
            // 
            this.lblSumInsured.AutoSize = true;
            this.lblSumInsured.Location = new System.Drawing.Point(84, 137);
            this.lblSumInsured.Name = "lblSumInsured";
            this.lblSumInsured.Size = new System.Drawing.Size(162, 20);
            this.lblSumInsured.TabIndex = 3;
            this.lblSumInsured.Text = "Death (Sum Insured):";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(261, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(292, 26);
            this.txtName.TabIndex = 0;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(261, 85);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(292, 26);
            this.dtpBirthdate.TabIndex = 1;
            this.dtpBirthdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cboOccupation
            // 
            this.cboOccupation.DisplayMember = "Text";
            this.cboOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOccupation.FormattingEnabled = true;
            this.cboOccupation.Location = new System.Drawing.Point(261, 180);
            this.cboOccupation.Name = "cboOccupation";
            this.cboOccupation.Size = new System.Drawing.Size(292, 28);
            this.cboOccupation.TabIndex = 3;
            this.cboOccupation.ValueMember = "Rating";
            this.cboOccupation.SelectedIndexChanged += new System.EventHandler(this.cboOccupation_SelectedIndexChanged);
            // 
            // lblPremiumValue
            // 
            this.lblPremiumValue.AutoSize = true;
            this.lblPremiumValue.Location = new System.Drawing.Point(257, 292);
            this.lblPremiumValue.Name = "lblPremiumValue";
            this.lblPremiumValue.Size = new System.Drawing.Size(116, 20);
            this.lblPremiumValue.TabIndex = 7;
            this.lblPremiumValue.Text = "Premium Value";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(587, 91);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 20);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age:";
            // 
            // lblAgeValue
            // 
            this.lblAgeValue.AutoSize = true;
            this.lblAgeValue.Location = new System.Drawing.Point(635, 91);
            this.lblAgeValue.Name = "lblAgeValue";
            this.lblAgeValue.Size = new System.Drawing.Size(18, 20);
            this.lblAgeValue.TabIndex = 9;
            this.lblAgeValue.Text = "0";
            // 
            // txtSumInsured
            // 
            this.txtSumInsured.Location = new System.Drawing.Point(261, 134);
            this.txtSumInsured.Name = "txtSumInsured";
            this.txtSumInsured.Size = new System.Drawing.Size(292, 26);
            this.txtSumInsured.TabIndex = 2;
            this.txtSumInsured.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSumInsured_KeyPress);
            // 
            // btnCalcPremium
            // 
            this.btnCalcPremium.Location = new System.Drawing.Point(88, 285);
            this.btnCalcPremium.Name = "btnCalcPremium";
            this.btnCalcPremium.Size = new System.Drawing.Size(116, 34);
            this.btnCalcPremium.TabIndex = 4;
            this.btnCalcPremium.Text = "Calculate";
            this.btnCalcPremium.UseVisualStyleBackColor = true;
            this.btnCalcPremium.Click += new System.EventHandler(this.btnCalcPremium_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(672, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 34);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalcPremium;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalcPremium);
            this.Controls.Add(this.txtSumInsured);
            this.Controls.Add(this.lblAgeValue);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPremiumValue);
            this.Controls.Add(this.cboOccupation);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSumInsured);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Premium";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblSumInsured;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.ComboBox cboOccupation;
        private System.Windows.Forms.Label lblPremiumValue;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeValue;
        private System.Windows.Forms.TextBox txtSumInsured;
        private System.Windows.Forms.Button btnCalcPremium;
        private System.Windows.Forms.Button btnClose;
    }
}


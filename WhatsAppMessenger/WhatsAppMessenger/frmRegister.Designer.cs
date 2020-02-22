namespace WhatsAppMessenger
{
    partial class frmRegister
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
            this.grbRequestCode = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.grbConfirmCode = new System.Windows.Forms.GroupBox();
            this.txtSMSCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRequestCode = new System.Windows.Forms.Button();
            this.btnConfirmCode = new System.Windows.Forms.Button();
            this.grbRequestCode.SuspendLayout();
            this.grbConfirmCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRequestCode
            // 
            this.grbRequestCode.Controls.Add(this.btnRequestCode);
            this.grbRequestCode.Controls.Add(this.txtFullName);
            this.grbRequestCode.Controls.Add(this.txtPhoneNumber);
            this.grbRequestCode.Controls.Add(this.label2);
            this.grbRequestCode.Controls.Add(this.label1);
            this.grbRequestCode.Location = new System.Drawing.Point(12, 12);
            this.grbRequestCode.Name = "grbRequestCode";
            this.grbRequestCode.Size = new System.Drawing.Size(319, 124);
            this.grbRequestCode.TabIndex = 1;
            this.grbRequestCode.TabStop = false;
            this.grbRequestCode.Text = "Step 1 : Request Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(118, 21);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(172, 20);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name :";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(118, 59);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(172, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // grbConfirmCode
            // 
            this.grbConfirmCode.Controls.Add(this.btnConfirmCode);
            this.grbConfirmCode.Controls.Add(this.txtSMSCode);
            this.grbConfirmCode.Controls.Add(this.label4);
            this.grbConfirmCode.Enabled = false;
            this.grbConfirmCode.Location = new System.Drawing.Point(12, 152);
            this.grbConfirmCode.Name = "grbConfirmCode";
            this.grbConfirmCode.Size = new System.Drawing.Size(319, 103);
            this.grbConfirmCode.TabIndex = 1;
            this.grbConfirmCode.TabStop = false;
            this.grbConfirmCode.Text = "Step 2 : Confirm Code";
            this.grbConfirmCode.Enter += new System.EventHandler(this.grbConfirmCode_Enter);
            // 
            // txtSMSCode
            // 
            this.txtSMSCode.Location = new System.Drawing.Point(118, 21);
            this.txtSMSCode.MaxLength = 6;
            this.txtSMSCode.Name = "txtSMSCode";
            this.txtSMSCode.Size = new System.Drawing.Size(172, 20);
            this.txtSMSCode.TabIndex = 1;
            this.txtSMSCode.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SMS Code :";
            // 
            // btnRequestCode
            // 
            this.btnRequestCode.Location = new System.Drawing.Point(205, 85);
            this.btnRequestCode.Name = "btnRequestCode";
            this.btnRequestCode.Size = new System.Drawing.Size(75, 23);
            this.btnRequestCode.TabIndex = 2;
            this.btnRequestCode.Text = "Request";
            this.btnRequestCode.UseVisualStyleBackColor = true;
            this.btnRequestCode.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnConfirmCode
            // 
            this.btnConfirmCode.Location = new System.Drawing.Point(205, 47);
            this.btnConfirmCode.Name = "btnConfirmCode";
            this.btnConfirmCode.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmCode.TabIndex = 3;
            this.btnConfirmCode.Text = "Confirm";
            this.btnConfirmCode.UseVisualStyleBackColor = true;
            this.btnConfirmCode.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 269);
            this.Controls.Add(this.grbConfirmCode);
            this.Controls.Add(this.grbRequestCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.grbRequestCode.ResumeLayout(false);
            this.grbRequestCode.PerformLayout();
            this.grbConfirmCode.ResumeLayout(false);
            this.grbConfirmCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbRequestCode;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbConfirmCode;
        private System.Windows.Forms.TextBox txtSMSCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRequestCode;
        private System.Windows.Forms.Button btnConfirmCode;
    }
}
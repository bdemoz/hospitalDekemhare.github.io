namespace HospitalDC
{
    partial class frmAddModifyInvoice
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientNote = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtInvoiceAddress = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.txtInnvoiceID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(431, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 37);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(177, 265);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(199, 37);
            this.btnAccept.TabIndex = 38;
            this.btnAccept.Text = "A&ccept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Note:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Invoice Date: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "City, State, Zip Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Invoice Address: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Invoice No.: ";
            // 
            // txtPatientNote
            // 
            this.txtPatientNote.Location = new System.Drawing.Point(177, 167);
            this.txtPatientNote.Multiline = true;
            this.txtPatientNote.Name = "txtPatientNote";
            this.txtPatientNote.Size = new System.Drawing.Size(431, 73);
            this.txtPatientNote.TabIndex = 37;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(431, 126);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(63, 22);
            this.txtState.TabIndex = 33;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(177, 126);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(248, 22);
            this.txtCity.TabIndex = 32;
            // 
            // txtInvoiceAddress
            // 
            this.txtInvoiceAddress.Location = new System.Drawing.Point(177, 83);
            this.txtInvoiceAddress.Name = "txtInvoiceAddress";
            this.txtInvoiceAddress.Size = new System.Drawing.Size(431, 22);
            this.txtInvoiceAddress.TabIndex = 28;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(500, 126);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(108, 22);
            this.txtZipCode.TabIndex = 34;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(177, 47);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(431, 22);
            this.txtInvoiceDate.TabIndex = 27;
            // 
            // txtInnvoiceID
            // 
            this.txtInnvoiceID.Location = new System.Drawing.Point(177, 11);
            this.txtInnvoiceID.Name = "txtInnvoiceID";
            this.txtInnvoiceID.ReadOnly = true;
            this.txtInnvoiceID.Size = new System.Drawing.Size(107, 22);
            this.txtInnvoiceID.TabIndex = 26;
            // 
            // frmAddModifyInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 705);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatientNote);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtInvoiceAddress);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.txtInnvoiceID);
            this.Name = "frmAddModifyInvoice";
            this.Text = "frmAddModifyInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientNote;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtInvoiceAddress;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.TextBox txtInnvoiceID;
    }
}
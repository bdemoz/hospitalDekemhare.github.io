namespace HospitalDC
{
    partial class frmPatient
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
            this.components = new System.ComponentModel.Container();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetPatient = new System.Windows.Forms.Button();
            this.txtSalutation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtPatientNote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegisterPatient = new System.Windows.Forms.Button();
            this.btnModifyPatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPhysician = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMedicalRecord = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrimaryPhysician = new System.Windows.Forms.TextBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(167, 22);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(107, 22);
            this.txtPatientID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Patient ID: ";
            // 
            // btnGetPatient
            // 
            this.btnGetPatient.Location = new System.Drawing.Point(313, 15);
            this.btnGetPatient.Name = "btnGetPatient";
            this.btnGetPatient.Size = new System.Drawing.Size(152, 37);
            this.btnGetPatient.TabIndex = 2;
            this.btnGetPatient.Text = "&Get Patient";
            this.btnGetPatient.UseVisualStyleBackColor = true;
            this.btnGetPatient.Click += new System.EventHandler(this.btnGetPatient_Click);
            // 
            // txtSalutation
            // 
            this.txtSalutation.Location = new System.Drawing.Point(167, 100);
            this.txtSalutation.Name = "txtSalutation";
            this.txtSalutation.ReadOnly = true;
            this.txtSalutation.Size = new System.Drawing.Size(107, 22);
            this.txtSalutation.TabIndex = 0;
            this.txtSalutation.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salutation:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(167, 136);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(431, 22);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(167, 172);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(431, 22);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(167, 280);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(431, 22);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Address:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(167, 316);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(248, 22);
            this.txtCity.TabIndex = 0;
            this.txtCity.TabStop = false;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(421, 316);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(63, 22);
            this.txtState.TabIndex = 0;
            this.txtState.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "City, State, Zip Code:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(490, 316);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.ReadOnly = true;
            this.txtZipCode.Size = new System.Drawing.Size(108, 22);
            this.txtZipCode.TabIndex = 0;
            this.txtZipCode.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 352);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(438, 352);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(160, 22);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.TabStop = false;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(167, 208);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(206, 22);
            this.txtDOB.TabIndex = 0;
            this.txtDOB.TabStop = false;
            // 
            // txtPatientNote
            // 
            this.txtPatientNote.Location = new System.Drawing.Point(167, 392);
            this.txtPatientNote.Multiline = true;
            this.txtPatientNote.Name = "txtPatientNote";
            this.txtPatientNote.ReadOnly = true;
            this.txtPatientNote.Size = new System.Drawing.Size(431, 73);
            this.txtPatientNote.TabIndex = 0;
            this.txtPatientNote.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Date of Birth:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Phone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Note:";
            // 
            // btnRegisterPatient
            // 
            this.btnRegisterPatient.Location = new System.Drawing.Point(636, 65);
            this.btnRegisterPatient.Name = "btnRegisterPatient";
            this.btnRegisterPatient.Size = new System.Drawing.Size(152, 37);
            this.btnRegisterPatient.TabIndex = 3;
            this.btnRegisterPatient.Text = "&Register Patient";
            this.btnRegisterPatient.UseVisualStyleBackColor = true;
            this.btnRegisterPatient.Click += new System.EventHandler(this.btnRegisterPatient_Click);
            // 
            // btnModifyPatient
            // 
            this.btnModifyPatient.Enabled = false;
            this.btnModifyPatient.Location = new System.Drawing.Point(636, 125);
            this.btnModifyPatient.Name = "btnModifyPatient";
            this.btnModifyPatient.Size = new System.Drawing.Size(152, 37);
            this.btnModifyPatient.TabIndex = 4;
            this.btnModifyPatient.Text = "&Modify Patient";
            this.btnModifyPatient.UseVisualStyleBackColor = true;
            this.btnModifyPatient.Click += new System.EventHandler(this.btnModifyPatient_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Enabled = false;
            this.btnDeletePatient.Location = new System.Drawing.Point(636, 185);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(152, 37);
            this.btnDeletePatient.TabIndex = 5;
            this.btnDeletePatient.Text = "&Delete Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Enabled = false;
            this.btnInvoice.Location = new System.Drawing.Point(316, 479);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(123, 37);
            this.btnInvoice.TabIndex = 9;
            this.btnInvoice.Text = "&Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Enabled = false;
            this.btnBalance.Location = new System.Drawing.Point(455, 479);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(123, 37);
            this.btnBalance.TabIndex = 10;
            this.btnBalance.Text = "&Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            // 
            // btnAppointment
            // 
            this.btnAppointment.Enabled = false;
            this.btnAppointment.Location = new System.Drawing.Point(177, 479);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(123, 37);
            this.btnAppointment.TabIndex = 8;
            this.btnAppointment.Text = "&Appointments";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(636, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPhysician
            // 
            this.btnPhysician.Location = new System.Drawing.Point(38, 479);
            this.btnPhysician.Name = "btnPhysician";
            this.btnPhysician.Size = new System.Drawing.Size(123, 37);
            this.btnPhysician.TabIndex = 7;
            this.btnPhysician.Text = "&List of Physician";
            this.btnPhysician.UseVisualStyleBackColor = true;
            this.btnPhysician.Click += new System.EventHandler(this.btnPhysician_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Primary Physician";
            // 
            // txtMedicalRecord
            // 
            this.txtMedicalRecord.Location = new System.Drawing.Point(167, 62);
            this.txtMedicalRecord.Name = "txtMedicalRecord";
            this.txtMedicalRecord.ReadOnly = true;
            this.txtMedicalRecord.Size = new System.Drawing.Size(107, 22);
            this.txtMedicalRecord.TabIndex = 0;
            this.txtMedicalRecord.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Medical Record";
            // 
            // txtPrimaryPhysician
            // 
            this.txtPrimaryPhysician.Location = new System.Drawing.Point(167, 244);
            this.txtPrimaryPhysician.Name = "txtPrimaryPhysician";
            this.txtPrimaryPhysician.ReadOnly = true;
            this.txtPrimaryPhysician.Size = new System.Drawing.Size(431, 22);
            this.txtPrimaryPhysician.TabIndex = 12;
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 16;
            this.lstDisplay.Location = new System.Drawing.Point(38, 539);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(750, 212);
            this.lstDisplay.TabIndex = 13;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(38, 767);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(204, 37);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(274, 767);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 37);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(510, 767);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 37);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnPhysician_Click);
            
            // 
            // frmPatient
            // 
            this.AcceptButton = this.btnGetPatient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 826);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.txtPrimaryPhysician);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnPhysician);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnModifyPatient);
            this.Controls.Add(this.btnRegisterPatient);
            this.Controls.Add(this.btnGetPatient);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatientNote);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtMedicalRecord);
            this.Controls.Add(this.txtSalutation);
            this.Controls.Add(this.txtPatientID);
            this.Name = "frmPatient";
            this.Text = "Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetPatient;
        private System.Windows.Forms.TextBox txtSalutation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtPatientNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRegisterPatient;
        private System.Windows.Forms.Button btnModifyPatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPhysician;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMedicalRecord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrimaryPhysician;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        
    }
}


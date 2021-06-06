namespace HospitalDC
{
    partial class frmAddModifyPhysician
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhysicianNote = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSpeciality = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtPractice = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtLicenceDate = new System.Windows.Forms.TextBox();
            this.lblLicenceDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(417, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 37);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(163, 401);
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
            this.label12.Location = new System.Drawing.Point(42, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Note:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Speciality:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Practice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Middle Initial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "&Title:";
            // 
            // txtPhysicianNote
            // 
            this.txtPhysicianNote.Location = new System.Drawing.Point(163, 307);
            this.txtPhysicianNote.Multiline = true;
            this.txtPhysicianNote.Name = "txtPhysicianNote";
            this.txtPhysicianNote.Size = new System.Drawing.Size(431, 73);
            this.txtPhysicianNote.TabIndex = 37;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(163, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(431, 22);
            this.txtLastName.TabIndex = 29;
            // 
            // txtSpeciality
            // 
            this.txtSpeciality.Location = new System.Drawing.Point(163, 222);
            this.txtSpeciality.Name = "txtSpeciality";
            this.txtSpeciality.Size = new System.Drawing.Size(248, 22);
            this.txtSpeciality.TabIndex = 32;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(163, 152);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(248, 22);
            this.txtDOB.TabIndex = 31;
            // 
            // txtPractice
            // 
            this.txtPractice.Location = new System.Drawing.Point(163, 257);
            this.txtPractice.Name = "txtPractice";
            this.txtPractice.Size = new System.Drawing.Size(180, 22);
            this.txtPractice.TabIndex = 35;
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(163, 82);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(431, 22);
            this.txtMiddleInitial.TabIndex = 28;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(163, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(431, 22);
            this.txtFirstName.TabIndex = 27;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(163, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(107, 22);
            this.txtTitle.TabIndex = 26;
            // 
            // txtLicenceDate
            // 
            this.txtLicenceDate.Location = new System.Drawing.Point(163, 187);
            this.txtLicenceDate.Name = "txtLicenceDate";
            this.txtLicenceDate.Size = new System.Drawing.Size(248, 22);
            this.txtLicenceDate.TabIndex = 32;
            // 
            // lblLicenceDate
            // 
            this.lblLicenceDate.AutoSize = true;
            this.lblLicenceDate.Location = new System.Drawing.Point(42, 190);
            this.lblLicenceDate.Name = "lblLicenceDate";
            this.lblLicenceDate.Size = new System.Drawing.Size(115, 17);
            this.lblLicenceDate.TabIndex = 42;
            this.lblLicenceDate.Text = "Date of Licence: ";
            // 
            // frmAddModifyPhysician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 476);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblLicenceDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhysicianNote);
            this.Controls.Add(this.txtLicenceDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtSpeciality);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtPractice);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmAddModifyPhysician";
            this.Text = "frmAddModifyPhysician";
            this.Load += new System.EventHandler(this.frmAddModifyPhysician_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhysicianNote;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSpeciality;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtPractice;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtLicenceDate;
        private System.Windows.Forms.Label lblLicenceDate;
    }
}
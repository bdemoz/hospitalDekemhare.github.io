using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDC
{
    public partial class frmAddModifyPhysician : Form
    {
        public frmAddModifyPhysician()
        {
            InitializeComponent();
        }
        public Physician physician;
        public bool addPhysician;

        private void frmAddModifyPhysician_Load(object sender, EventArgs e)
        {
            if (addPhysician)
            {
                this.Text = "Add Physician";
            }
            else
            {
                this.Text = "Modify Physician";
                this.DisplayphysicianInfo();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (addPhysician)
                {
                    //to add a physician
                    physician = new Physician();
                    this.PutPhysicianInfo();
                    HospitalEntity.hospitals.Physicians.Add(physician);
                    try
                    {
                        HospitalEntity.hospitals.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                //to modify
                else
                {
                    this.PutPhysicianInfo();
                    try
                    {
                        HospitalEntity.hospitals.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        ex.Entries.Single().Reload();
                        if (HospitalEntity.hospitals.Entry(physician).State ==
                            EntityState.Detached)
                        {
                            MessageBox.Show("Another user has deleted that patient",
                                "Concurrency Error");
                            this.DialogResult = DialogResult.Abort;
                        }
                        else
                        {
                            MessageBox.Show("Another user has updated that patient.",
                                "Concurrency Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }

            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        //Displaying physician
        private void DisplayphysicianInfo()
        {
            txtTitle.Text = physician.Title;
            txtFirstName.Text = physician.FirstName;
            txtLastName.Text = physician.LastName;
            txtSpeciality.Text = physician.Speciality;
            txtDOB.Text = physician.DOB.ToString("MMMM dd,yyyy");
            txtLicenceDate.Text = physician.LicenseDate.ToString("MMMM dd,yyyy");
            txtPhysicianNote.Text = physician.Note;
            txtPractice.Text = physician.Practice;
        }

        //save physician
        private void PutPhysicianInfo()
        {
            physician.Title = txtTitle.Text;
            physician.FirstName = txtFirstName.Text;
            physician.MiddleInitial = txtMiddleInitial.Text;
            physician.LastName = txtLastName.Text;
            physician.DOB = Convert.ToDateTime(txtDOB.Text);
            physician.LicenseDate = Convert.ToDateTime(txtLicenceDate.Text);
            physician.Speciality = txtSpeciality.Text;
            physician.Practice = txtPractice.Text;
            physician.Note = txtPhysicianNote.Text;
        }

        //to check data validity
        private bool isValid()
        {
            return Validator.isPresent(txtFirstName, "First Name") &&
                Validator.isPresent(txtLastName, "Last Name") &&

                Validator.isPresent(txtDOB, "Date of Birth") &&
                Validator.isDate(txtDOB,"Date of Birth") &&
                
                Validator.isPresent(txtLicenceDate, "Licence Date") &&
                Validator.isDate(txtLicenceDate,"Licence Date") &&

                Validator.isPresent(txtSpeciality, "Speciality") &&
                Validator.isPresent(txtPractice, "Practice");
        }
    }
}

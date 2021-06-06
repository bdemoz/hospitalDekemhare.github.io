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
    public partial class frmAddModifyPatient : Form
    {
        public frmAddModifyPatient()
        {
            InitializeComponent();
        }
        public Patient patient;
        public bool addPatient;

        private void frmAddModifyPatient_Load(object sender, EventArgs e)
        {
            this.LoadPhysician();
            if (addPatient)
            {
                this.Text = "Add Patient";
                cboPrimaryPhysician.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Modify Patient";
                this.DisplayPatientInfo();
                
            }

        }

        private void LoadPhysician()
        {
            var physicians = (from physician in HospitalEntity.hospitals.Physicians
                              orderby physician.LastName
                              select physician).ToList();
            cboPrimaryPhysician.DataSource = physicians;
            cboPrimaryPhysician.DisplayMember = "LastName";
            cboPrimaryPhysician.ValueMember = "PhysicianID";
        }

        //Displaying Patient
        private void DisplayPatientInfo()
        {
            string phone = patient.Phone;


            txtSalutation.Text = patient.Salutation;
            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            cboPrimaryPhysician.SelectedValue = patient.PhysicianID;
            txtAddress.Text = patient.Address;
            txtCity.Text = patient.City;
            txtState.Text = patient.State;
            txtZipCode.Text = patient.ZipCode;
            txtDOB.Text = patient.DOB.ToString("MMMM dd,yyyy");
            txtEmail.Text = patient.Email;
            txtPhone.Text = string.Format("({0}) {1} - {2}", phone.Substring(0, 2), phone.Substring(3, 2), phone.Substring(5));
            txtPatientNote.Text = patient.PatientNote;
        }

        //save patient
        private void PutPatientInfo(Patient p)
        {
            p.Salutation = txtSalutation.Text;
            p.FirstName = txtFirstName.Text;
            p.LastName = txtLastName.Text;
            p.PhysicianID = (int) cboPrimaryPhysician.SelectedValue;
            p.Address = txtAddress.Text;
            p.City = txtCity.Text;
            p.State = txtState.Text;
            p.ZipCode = txtZipCode.Text;
            p.DOB = Convert.ToDateTime(txtDOB.Text);
            p.Email = txtEmail.Text;
            p.Phone = txtPhone.Text;
            p.PatientNote = txtPatientNote.Text;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if(cboPrimaryPhysician.SelectedIndex == -1)
                {
                    MessageBox.Show("Primary Doctor is required", "Entry Error");
                    cboPrimaryPhysician.Focus();
                }
                else
                {
                    //to add
                    if (addPatient)
                    {
                        patient = new Patient();
                        this.PutPatientInfo(patient);
                        HospitalEntity.hospitals.Patients.Add(patient);
                        try
                        {
                            HospitalEntity.hospitals.SaveChanges();
                            this.DialogResult = DialogResult.OK;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }
                    //to modify
                    else
                    {
                        this.PutPatientInfo(patient);
                        try
                        {
                            HospitalEntity.hospitals.SaveChanges();
                            this.DialogResult = DialogResult.OK;
                        }
                        catch(DbUpdateConcurrencyException ex)
                        {
                            ex.Entries.Single().Reload();
                            if(HospitalEntity.hospitals.Entry(patient).State ==
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
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }
                    }
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool isValid()
        {
            return Validator.isPresent(txtFirstName, "First Name") &&
                Validator.isPresent(txtLastName, "Last Name") &&
                Validator.isPresent(txtAddress, "Address") &&
                Validator.isPresent(txtCity, "City") &&
                Validator.isPresent(txtState, "State") &&
                Validator.isPresent(txtZipCode, "Zip Code") &&

                Validator.isValidEmail(txtEmail,"Email") &&

                Validator.isPresent(txtDOB, "Date of Birth") &&
                Validator.isDate(txtDOB, "Date of Birth") &&

                Validator.isPresent(txtPhone, "Phone number");                

        }

        
    }
}

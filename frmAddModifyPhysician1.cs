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
    public partial class frmAddModifyPhysician1 : Form
    {
        public frmAddModifyPhysician1()
        {
            InitializeComponent();
        }

        public Physician physician;
        public bool addPhysician;
        private void frmAddModifyPhysician1_Load(object sender, EventArgs e)
        {
            if (addPhysician)
            {
                this.Text = "Add Physician";
            }
            else
            {
                this.Text = "Modify Physician";
                this.DisplayPhysician();
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (addPhysician)
            {
                physician = new Physician();
                this.PutPhysician(physician);
                HospitalEntity.hospitals.Physicians.Add(physician);
                try
                {
                    HospitalEntity.hospitals.insertPhysician(physician.Title,physician.FirstName,physician.LastName,
                        physician.DOB,physician.LicenseDate,physician.Speciality,physician.Practice,physician.Note);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void DisplayPhysician()
        {
            txtTitle.Text = physician.Title;
            txtFirstName.Text = physician.FirstName;
            txtLastName.Text = physician.LastName;
            txtMiddleInitial.Text = physician.MiddleInitial;
            txtDOB.Text = physician.DOB.ToString("MMMM dd, yyyy");
            txtLicenceDate.Text = physician.LicenseDate.ToString("MMMM dd, yyyy");
            txtSpeciality.Text = physician.Speciality;
            txtPractice.Text = physician.Practice;
            txtPhysicianNote.Text = physician.Note;
        }

        private void PutPhysician(Physician p)
        {
            p.Title = txtTitle.Text;
            p.FirstName = txtFirstName.Text;
            p.MiddleInitial = txtMiddleInitial.Text;
            p.DOB = Convert.ToDateTime(txtDOB.Text);
            p.LicenseDate = Convert.ToDateTime(txtLicenceDate.Text);
            p.Speciality = txtSpeciality.Text;
            p.Practice = txtPractice.Text;
            p.Note = txtPhysicianNote.Text;
            p.ModifiedDate = DateTime.Now;
        }
    }
}

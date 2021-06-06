using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDC
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private Patient selectedPatient;
        SortedList<int, int> phys = new SortedList<int, int>();
        SortedList<int, int> Apps = new SortedList<int, int>();
        SortedList<int, int> invs = new SortedList<int, int>();

        private void btnGetPatient_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                int patientID = Convert.ToInt32(txtPatientID.Text);
                this.GetPatientInfo(patientID);
                this.txtPatientID.Text = "";
            }

        }

        //To get patient
        private void GetPatientInfo(int id)
        {
            selectedPatient = (from p in HospitalEntity.hospitals.Patients
                               where p.PatientID == id
                               select p).FirstOrDefault();
            if (selectedPatient == null)
            {
                MessageBox.Show("No patient found with this ID. " +
                    "Please try again", "Patient Not Found");
                this.clearControls();
                txtPatientID.Focus();
            }
            else
            {
                this.DisplayPatientInfo();
                this.buttonEnableProperty(true);
            }
        }

        //to display patient
        private void DisplayPatientInfo()
        {
            string phone = selectedPatient.Phone;
            txtMedicalRecord.Text = selectedPatient.PatientID.ToString("PAT00000");
            txtSalutation.Text = selectedPatient.Salutation;
            txtFirstName.Text = selectedPatient.FirstName;
            txtLastName.Text = selectedPatient.LastName;
            txtPrimaryPhysician.Text = selectedPatient.Physician.LastName + ", " + selectedPatient.Physician.FirstName;
            txtAddress.Text = selectedPatient.Address;
            txtCity.Text = selectedPatient.City;
            txtState.Text = selectedPatient.State;
            txtZipCode.Text = selectedPatient.ZipCode;
            txtDOB.Text = selectedPatient.DOB.ToString("MMMM dd,yyyy");
            txtEmail.Text = selectedPatient.Email;
            txtPhone.Text = string.Format("({0}) {1} - {2}", phone.Substring(0, 3), phone.Substring(2, 3), phone.Substring(5)); ;
            txtPatientNote.Text = selectedPatient.PatientNote;


        }



        //Enable property of Textboxes
        private void clearControls()
        {
            txtSalutation.Text = "";
            txtMedicalRecord.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPrimaryPhysician.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            txtPhone.Text = "";
            txtPatientNote.Text = "";
            txtEmail.Text = "";
            txtDOB.Text = "";

            btnModifyPatient.Enabled = false;
            btnDeletePatient.Enabled = false;
            btnAppointment.Enabled = false;
            btnInvoice.Enabled = false;
            btnBalance.Enabled = false;
        }

        //enabled property of buttons
        private void buttonEnableProperty(bool t)
        {
            btnModifyPatient.Enabled = t;
            btnDeletePatient.Enabled = t;
            btnAppointment.Enabled = t;
            btnInvoice.Enabled = t;
            btnBalance.Enabled = t;

            lstDisplay.Items.Clear();

        }


        //Validate
        private bool isValid()
        {
            return Validator.isPresent(txtPatientID, "Patient ID") &&
                Validator.isInt(txtPatientID, "Patient ID");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            frmAddModifyPatient addModifyPatient = new frmAddModifyPatient();
            addModifyPatient.addPatient = true;
            DialogResult result = addModifyPatient.ShowDialog();
            if(result == DialogResult.OK)
            {
                selectedPatient = addModifyPatient.patient;
                this.DisplayPatientInfo();
            }
        }

        private void btnModifyPatient_Click(object sender, EventArgs e)
        {
            frmAddModifyPatient addModifyPatient = new frmAddModifyPatient();
            addModifyPatient.addPatient = false;
            addModifyPatient.patient = selectedPatient;

            DialogResult result = addModifyPatient.ShowDialog();
            if(result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedPatient = addModifyPatient.patient;
                this.DisplayPatientInfo();
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete patient: " +
               selectedPatient.PatientID.ToString("PAT001000"), "Confirm Delete", 
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                HospitalEntity.hospitals.Patients.Remove(selectedPatient);
                try
                {
                    HospitalEntity.hospitals.SaveChanges();
                    txtPatientID.Focus();
                    this.clearControls();
                }
                catch(DbUpdateException ex)
                {
                    ex.Entries.Single().Reload();
                    //if the entry is deleted by other user
                    if(HospitalEntity.hospitals.Entry(selectedPatient).State == EntityState.Deleted)
                    {
                        MessageBox.Show("Another user has deleted" +
                            "that patient.", "Concurrency Error");
                        this.clearControls();
                    }

                    //if the entry is updated by other user
                    else
                    {
                        MessageBox.Show("Another user has updated that patient.",
                            "Concurrency Error");
                        this.DisplayPatientInfo();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnPhysician_Click(object sender, EventArgs e)
        {
            btnModify.Enabled = true;
            btnModify.Text = "Modify Physician";
            btnAdd.Enabled = true;
            btnAdd.Text = "Add Physician";
            btnDelete.Enabled = false;


            var physicians = (from physician in HospitalEntity.hospitals.Physicians
                              orderby physician.LastName
                              select physician).ToList();

            lstDisplay.Items.Clear();
            string title = "ID" + "\t\t" + "Full Name" + "\t\t\t" +
                "Date of Birth" + "\t\t" + "Speciality";
            phys.Clear();
            lstDisplay.Items.Add(title);
            int i = 0;
            foreach(var p in physicians)
            {
                string detail = $"{p.PhysicianID.ToString("PHY0000")}\t{p.LastName},{p.FirstName}" +
                    $"\t\t{p.DOB.ToString("MM/dd/yyyy")} \t\t {p.Speciality}";
                lstDisplay.Items.Add(detail);
                phys[i] = p.PhysicianID;
                i++;
            }
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            var appointments = (from appointment in HospitalEntity.hospitals.Appointments
                                where appointment.PatientID == selectedPatient.PatientID
                                orderby appointment.VisitDate
                                select appointment).ToList();
            
            lstDisplay.Items.Clear();
            string title = "Apt ID" + "\t" + "Physician ID" + "\t" + "Visit Type" + "\t\t" +
                "Visit Date" + "\t\t" + "From Time" + "\t" + "To Time";
            lstDisplay.Items.Add(title);
            if(appointments != null)
            {
                foreach (var p in appointments)
                {
                    string detail = $"{p.AppointmentID.ToString("APT0000")}\t{p.PhysicianID.ToString("PHY0000")}\t\t{p.VisitType}" +
                        $"\t\t{p.VisitDate.ToString("MM/dd/yyyy")}\t\t{p.FromTime.ToString()}\t" +
                        $"{p.ToTime?.ToString()}";
                    lstDisplay.Items.Add(detail);
                }
            }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //to modify physician
            if(btnModify.Text == "Modify Physician")
            {
                if(lstDisplay.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please select physician to modify", "Entry Error");
                }
                else
                {
                    frmAddModifyPhysician addModifyPhysician = new frmAddModifyPhysician();
                    addModifyPhysician.addPhysician = false;

                    int index = lstDisplay.SelectedIndex - 1;
                    int physicianID = phys[index];
                    Physician selectedPhysician = (from p in HospitalEntity.hospitals.Physicians
                                                   where p.PhysicianID == physicianID
                                                   select p).Single();
                    addModifyPhysician.physician = selectedPhysician;

                    DialogResult result = addModifyPhysician.ShowDialog();
                    if(result == DialogResult.OK || result == DialogResult.Retry)
                    {
                        lstDisplay.Items.Clear();
                    }

                }
            }
            //To modify if invoice is selected
            if(btnModify.Text == "Modify Invoice")
            {
                if (lstDisplay.SelectedIndex <= 0 || lstDisplay.SelectedIndex >= (lstDisplay.Items.Count-2))
                {
                    MessageBox.Show("Please select Invoice to modify", "Entry Error");
                }
                else
                {
                    frmAddModify1 addModifyInvoice = new frmAddModify1();
                    addModifyInvoice.addInvoice = false;
                    int index = lstDisplay.SelectedIndex - 1;
                    int invoiceID = invs[index];
                    Invoice selectedInvoice = (from i in HospitalEntity.hospitals.Invoices
                                                   where i.InvoiceID == invoiceID
                                                   select i).Single();
                    addModifyInvoice.invoice = selectedInvoice;
                    addModifyInvoice.patient = selectedPatient;
                    DialogResult result = addModifyInvoice.ShowDialog();
                    if (result == DialogResult.OK || result == DialogResult.Retry)
                    {
                        lstDisplay.Items.Clear();
                    }

                }

            }

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            btnModify.Text = "Modify Invoice";
            btnModify.Enabled = true;
            btnAdd.Text = "Add Invoice";
            btnAdd.Enabled = true;
            btnDelete.Text = "Delete Invoice";
            btnDelete.Enabled = true;

            decimal totalOwed = 0m;     //total patient owed

            var invoices = (from invoice in HospitalEntity.hospitals.Invoices
                            where invoice.PatientID == selectedPatient.PatientID
                            orderby invoice.InvoiceDate
                            select invoice).ToList();

            string title = "Invoice ID" + "\t\t" + "Invoice Date" + "\t\t" + "Total";
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(title);

            invs.Clear();
            int i = 0;
            decimal totalAmount = 0m;
            if(invoices != null)        //to check if there is at least one invoice for a given patient
            {
                foreach (var p in invoices)
                {
                    //to calculate all the amount of invoice detail
                    var invoiceDetails = (from invDetail in HospitalEntity.hospitals.InvoiceDetails
                                          where invDetail.InvoiceID == p.InvoiceID
                                          select invDetail).ToList();
                    if (invoiceDetails != null)     //to check if there is at least one invoicedetail for a given invoice
                    {
                        foreach (var invd in invoiceDetails)
                        {
                            
                            totalAmount += Convert.ToDecimal(invd.Amount);
                            totalOwed += totalAmount;
                        }

                    }
                    else
                    {
                        totalAmount = 0;
                    }
                    

                    string detail = $"{p.InvoiceID.ToString("INV0000")}\t\t\t {p.InvoiceDate.ToString("MM/dd/yy")}" +
                        $"\t\t{totalAmount.ToString("C")}";
                    lstDisplay.Items.Add(detail);
                    invs[i] = p.InvoiceID;
                    int a = invs[i];
                    i++;
                }
                lstDisplay.Items.Add("==========================");
                lstDisplay.Items.Add("Total Invoices Amount: " + totalOwed.ToString("C"));
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //to Add Physician
            if(btnAdd.Text == "Add Physician")
            {
                frmAddModifyPhysician1 addModifyPhysician = new frmAddModifyPhysician1();
                addModifyPhysician.addPhysician = true;
                DialogResult result = addModifyPhysician.ShowDialog();
                if(result == DialogResult.OK)
                {
                    lstDisplay.Items.Clear();
                }
            }

            //to Add Appointment;
            if (btnAdd.Text == "Add Appointment")
            {
                
            }

            //to Add Invoice
            if (btnAdd.Text == "Add Invoice")
            {
                frmAddModify1 addModifyInvoice = new frmAddModify1();
                addModifyInvoice.addInvoice = true;
                addModifyInvoice.patient = selectedPatient;
                DialogResult result = addModifyInvoice.ShowDialog();
                if (result == DialogResult.OK)
                    lstDisplay.Items.Clear();
            }
        }

    }
}

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
    public partial class frmAddModifyInvoice : Form
    {
        public frmAddModifyInvoice()
        {
            InitializeComponent();
        }

        public Invoice invoice;
        public bool addInvoice;
        public int patientID;

        private void frmAddModifyInvoice_Load(object sender, EventArgs e)
        {
            if (addInvoice)
            {
                //to get patients address
                Patient p = (from inv in HospitalEntity.hospitals.Patients
                             where inv.PatientID == patientID
                             select inv).Single();
                txtInvoiceAddress.Text = p.Address;
                txtCity.Text = p.City;
                txtState.Text = p.State;
                txtZipCode.Text = p.ZipCode;
                this.Text = "Add Invoice";

            }
            else
            {
                this.Text = "Modify Invoice";
                this.DisplayInvoiceInfo();
                

            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.isValid())
            {
                //to add
                if (addInvoice)
                {
                    invoice = new Invoice();
                    
                    this.PutInvoiceInfo(invoice);
                    HospitalEntity.hospitals.Invoices.Add(invoice);
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
                    this.PutInvoiceInfo(invoice);
                    try
                    {
                        HospitalEntity.hospitals.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        ex.Entries.Single().Reload();
                        if (HospitalEntity.hospitals.Entry(invoice).State ==
                            EntityState.Detached)
                        {
                            MessageBox.Show("Another user has deleted that invoice.",
                                "Concurrency Error");
                            this.DialogResult = DialogResult.Abort;
                        }
                        else
                        {
                            MessageBox.Show("Another user has updated that invoice.",
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

       
        //Displaying invoice detail
        private void DisplayInvoiceInfo()
        {
            
            txtInvoiceDate.Text = invoice.InvoiceDate.ToString("MMMM dd,yyyy");
            txtInvoiceAddress.Text = invoice.InvoiceAddress;
            txtCity.Text = invoice.InvoiceCity;
            txtState.Text = invoice.InvoiceState;
            txtZipCode.Text = invoice.InvoiceZipCode;
            txtInvoiceDate.Text = invoice.InvoiceDate.ToString("MMMM dd,yyyy");
            txtPatientNote.Text = invoice.InvoiceNote;

        }

        //save invoice
        private void PutInvoiceInfo(Invoice inv)
        {

            inv.InvoiceDate = Convert.ToDateTime(txtInvoiceDate.Text);
            inv.PatientID = patientID;
            inv.InvoiceAddress = txtInvoiceAddress.Text;
            inv.InvoiceCity = txtCity.Text;
            inv.InvoiceState = txtState.Text;
            inv.InvoiceZipCode = txtZipCode.Text;
            inv.InvoiceNote = txtPatientNote.Text;
        }
        private bool isValid()
        {
            return Validator.isPresent(txtInvoiceAddress, "Invoice Address") &&
                Validator.isPresent(txtCity, "City") &&
                Validator.isPresent(txtState, "State") &&
                Validator.isPresent(txtZipCode, "Zip Code");

        }
    }
}

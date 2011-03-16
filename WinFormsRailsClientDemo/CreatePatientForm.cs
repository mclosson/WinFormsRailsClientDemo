using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using RailsClient;

namespace WinFormsRailsClientDemo
{
    public partial class CreatePatientForm : Form
    {
        List<Patient> list;

        public CreatePatientForm(List<Patient> list)
        {
            InitializeComponent();
            this.list = list;
            tbName.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient() { 
                name = tbName.Text, 
                age = System.Convert.ToInt32(tbAge.Text), 
                smoker = cbSmoker.Checked 
            };

            patient = (Patient)patient.create();
            list.Add(patient);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

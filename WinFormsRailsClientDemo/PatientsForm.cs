using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RailsClient;

namespace WinFormsRailsClientDemo
{
    public partial class PatientsForm : Form
    {
        List<Patient> patients;

        public PatientsForm()
        {
            InitializeComponent();
            RESTfulResourceBase.baseurl = "http://restfuldemo.heroku.com/";
            patients = RESTfulFinder.all<Patient>();
            bsPatients.DataSource = patients;
        }

        private void dgPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPatients.SelectedRows.Count > 0)
            {
                int index = dgPatients.SelectedRows[0].Index;

                tbName.Text = patients[index].name;
                tbAge.Text = patients[index].age.ToString();
                cbSmoker.Checked = patients[index].smoker;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgPatients.SelectedRows[0].Index;

            patients[index].name = tbName.Text;
            patients[index].age = System.Convert.ToInt32(tbAge.Text);
            patients[index].smoker = cbSmoker.Checked;

            patients[index].save();
            dgPatients.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgPatients.SelectedRows.Count > 0)
            {
                int index = dgPatients.SelectedRows[0].Index;

                patients[index].delete();
                patients.RemoveAt(index);
                dgPatients.Refresh();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new CreatePatientForm(patients).ShowDialog();
            dgPatients.Refresh();
        }

    }
}

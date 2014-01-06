using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marksheet
{
    public partial class frm_Add_Subjects : Form
    {
        class_subject_details classDetails= new class_subject_details();
        public frm_Add_Subjects()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            classDetails.SubjectName = txtSubjectName.Text;
            classDetails.CredtHour = Convert.ToInt16(cbCreditHour.SelectedItem) ;
            classDetails.HasPractical = cboHasPractical.Checked;
            classDetails.Add_Subject_Details();
            MessageBox.Show("Success");

        }
    }
}

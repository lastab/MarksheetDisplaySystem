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
        class_subject_details classSubjectDetails= new class_subject_details();
        public frm_Add_Subjects()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            classSubjectDetails.SubjectCode = txtSubjectCode.Text;
            classSubjectDetails.SubjectName = txtSubjectName.Text;
            classSubjectDetails.CredtHour = Convert.ToInt16(cbCreditHour.Text ) ;
            classSubjectDetails.HasPractical = cboHasPractical.Checked;

            if (classSubjectDetails .Add_Subject_Details() == "inserted")
                MessageBox.Show("Success!");
            else
                MessageBox.Show(classSubjectDetails.Update_Subject_Details());
        }
    }
}

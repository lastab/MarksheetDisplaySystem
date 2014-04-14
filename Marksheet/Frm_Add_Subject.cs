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
        class_subject_details SubjectDetails = new class_subject_details();
        public frm_Add_Subjects()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtSubjectCode.Text == "")
            {
                errorProvider1.SetError(txtSubjectCode, "Empty Subject Code");
            }

            else
            {
                errorProvider1.Dispose();
                if (txtSubjectName.Text == "")
                {
                    errorProvider1.SetError(txtSubjectName, "Empty Subject Name");
                }
                else
                {
                    errorProvider1.Dispose();
                    if (Convert.ToInt16(cbCreditHour.Text) > 0 && Convert.ToInt16(cbCreditHour.Text) < 5)
                    {
                        errorProvider1.Dispose();
                        SubjectDetails.SubjectCode = txtSubjectCode.Text;
                        SubjectDetails.SubjectName = txtSubjectName.Text;
                        SubjectDetails.CredtHour = Convert.ToInt16(cbCreditHour.Text);
                        SubjectDetails.HasPractical = cboHasPractical.Checked;

                        if (SubjectDetails.Add_Subject_Details() == "inserted")
                            MessageBox.Show("Success!");
                        else
                            if (MessageBox.Show("The data of '" + SubjectDetails.SubjectCode + "' already exists\n" + "Do you want to update the information? ", "The Data already exists.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                MessageBox.Show(SubjectDetails.Update_Subject_Details());

                        txtSubjectCode.Text = "";
                        txtSubjectName.Text = "";
                    }
                    else
                    {
                        errorProvider1.SetError(cbCreditHour, "not valid");
                    }
                }
                See_All_Subjects();
            }
        }
        
        private void See_All_Subjects()
        {
            DataTable dt = new DataTable();
            dt = SubjectDetails.Get_All_Subject_Details();
            dgvSubjectDetails.DataSource = dt;


        }

        private void frm_Add_Subjects_Load(object sender, EventArgs e)
        {
            See_All_Subjects();
        }

        private void dgvSubjectDetails_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the selected Subject's Deteails? ", "Delete!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SubjectDetails .SubjectCode  = dgvSubjectDetails.CurrentRow.Cells["Subject_code"].Value.ToString ();
                MessageBox .Show ( SubjectDetails .Delete_Subject_Details ());
                See_All_Subjects ();
            }
        }

       
    }
}

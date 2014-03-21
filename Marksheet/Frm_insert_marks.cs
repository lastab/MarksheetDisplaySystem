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
    public partial class Frm_Insert_marks : Form
    {
        database db = new database();
        class_insert_marks classInsertMarks = new class_insert_marks();
        public Frm_Insert_marks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            classInsertMarks.Roll = Convert.ToInt32(cbRollNo.Text);
            classInsertMarks.SubjectName = cbName.Text;
            try
            {
                classInsertMarks.Assignment = Convert.ToInt16(txtAssignment.Text);
                if (classInsertMarks.Assignment > 10)
                    errorProvider1.SetError(txtAssignment, "value must be between 0-10");
                else
                {
                    errorProvider1.Dispose();
                    classInsertMarks.Attendance = Convert.ToInt16(txtAttendence.Text);
                    if (classInsertMarks.Attendance > 10)
                        errorProvider1.SetError(txtAttendence, "value must be  between 0-10");
                    else
                    {
                        errorProvider1.Dispose();
                        classInsertMarks.TermTest = Convert.ToInt16(txtTermTest.Text);
                        if (classInsertMarks.TermTest > 70)
                            errorProvider1.SetError(txtTermTest, "value must be  between 0-70");
                        else
                        {
                            classInsertMarks.Practical = Convert.ToInt16(txtPractical.Text);
                            if (classInsertMarks.Practical > 10)
                                errorProvider1.SetError(txtPractical, "value Must be between 0-10");
                            else
                            {
                                errorProvider1.Dispose();
                                classInsertMarks.Calculate_Total();

                                if (classInsertMarks.Add_Student_Marks() == "inserted")
                                    MessageBox.Show("Success!");
                                else
                                    MessageBox.Show(classInsertMarks.Update_Student_Marks());

                                txtAssignment.Text  = "0";
                                txtAttendence .Text = "0";
                                txtPractical.Text = "0";
                                txtTermTest.Text = "0";
                            }

                        }
                    }
                }
            }
            catch
            { MessageBox.Show("Please enter numeric character"); }
        }

        private void Frm_insert_marks_Load(object sender, EventArgs e)
        {
            
            
            DataTable dt = new DataTable();
            dt = classInsertMarks.Get_All_Student_Roll();
            cbRollNo.DataSource=dt;
            cbRollNo.DisplayMember = "Student_Roll";
            

            dt = classInsertMarks.Get_All_Subjects();
            cbName.DataSource = dt;
            cbName.DisplayMember = "Subject_Name";



        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            classInsertMarks.SubjectName = cbName.Text;
            if (classInsertMarks.Subject_Has_practical() == "True")
            {
                gbPractical.Enabled = true;
            }
            else
            {
                gbPractical.Enabled = false;
                txtPractical.Text = "0";
            }



        }

      

    
    }
}

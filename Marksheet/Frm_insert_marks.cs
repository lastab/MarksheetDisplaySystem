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
        class_insert_marks InsertMarks = new class_insert_marks();
        public Frm_Insert_marks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertMarks.Roll = Convert.ToInt32(cbRollNo.Text);
            InsertMarks.SubjectName = cbName.SelectedValue.ToString();
            
            try
            {
                InsertMarks.Assignment = float.Parse(txtAssignment.Text, System.Globalization.CultureInfo.InvariantCulture); 
                if (InsertMarks.Assignment > 10 || InsertMarks.Assignment<0)
                    errorProvider1.SetError(txtAssignment, "value must be between 0-10");
                else
                {
                    errorProvider1.Dispose();
                    InsertMarks.Attendance = float.Parse(txtAttendence .Text, System.Globalization.CultureInfo.InvariantCulture); ;
                    if (InsertMarks.Attendance > 10 || InsertMarks.Attendance< 0)
                        errorProvider1.SetError(txtAttendence, "value must be  between 0-10");
                    else
                    {
                        errorProvider1.Dispose();
                        InsertMarks.TermTestI =float.Parse(txtTermTestI.Text , System.Globalization.CultureInfo.InvariantCulture); 
                            
                        if (InsertMarks.TermTestI > 30 || InsertMarks.TermTestI<0)
                            errorProvider1.SetError(txtTermTestI, "value must be  between 0-30");
                        else
                        {
                            errorProvider1.Dispose();
                            InsertMarks.TermTestII = float.Parse(txtTermTestII.Text, System.Globalization.CultureInfo.InvariantCulture); 
                            if (InsertMarks.TermTestII > 50 || InsertMarks.TermTestII < 0)
                                errorProvider1.SetError(txtTermTestII, "value must be  between 0-50");
                            else
                            {
                                errorProvider1.Dispose();
                                InsertMarks.Practical = float.Parse(txtPractical.Text, System.Globalization.CultureInfo.InvariantCulture); 
                                if (InsertMarks.Practical > 10 || InsertMarks.Practical < 0)
                                    errorProvider1.SetError(txtPractical, "value Must be between 0-10");
                                else
                                {
                                    errorProvider1.Dispose();
                                    InsertMarks.Calculate_Total();

                                    if (InsertMarks.Add_Student_Marks() == "inserted")
                                        MessageBox.Show("Success!");
                                    else
                                        if (MessageBox.Show("The marks of roll:'" + InsertMarks.Roll + "' and subject:'" + InsertMarks.SubjectName + "' already exists\n" + "Do you want to update the information? ", "The Data already exists.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                            MessageBox.Show(InsertMarks.Update_Student_Marks());

                                    txtAssignment.Text = "0";
                                    txtAttendence.Text = "0";
                                    txtPractical.Text = "0";
                                    txtTermTestI.Text = "0";
                                    txtTermTestII.Text = "0";
                                }

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
            dt = InsertMarks.Get_All_Student_Roll();
            cbRollNo.DataSource = dt;
            cbRollNo.DisplayMember = "Student_Roll";
            


            dt = InsertMarks.Get_All_Subjects();
            cbName.DataSource = dt;
            cbName.ValueMember = "Subject_Code";
            cbName.DisplayMember = "Subject_Name";
            
           

        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertMarks.SubjectCode = cbName.SelectedValue.ToString();
            if (InsertMarks.SubjectCode != "System.Data.DataRowView")
            {
                if (InsertMarks.Subject_Has_practical() == "True")
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
}

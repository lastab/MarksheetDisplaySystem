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
    public partial class Frm_insert_marks : Form
    {
        database db = new database();
        class_insert_marks classInsertMarks = new class_insert_marks();
        public Frm_insert_marks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            classInsertMarks.Roll = Convert.ToInt32(cbRollNo.Text);
            classInsertMarks.SubjectName = cbName.Text;
            classInsertMarks.Assignment  = Convert.ToInt16(txtAssignment .Text);
            classInsertMarks.Attendance = Convert.ToInt16(txtAttendence.Text);
            classInsertMarks.TermTest  = Convert.ToInt16(txtTermTest.Text);
            classInsertMarks.Practical = Convert.ToInt16 (txtPractical.Text);
            
            if (classInsertMarks.Add_Student_Marks () == "inserted")
                MessageBox.Show("Success!");
            else
                MessageBox.Show(classInsertMarks.Update_Student_Marks ());
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
            if (classInsertMarks.Subject_Has_practical()=="True")
                gbPractical.Enabled = true;
            else
                gbPractical.Enabled = false;



        }

      

    
    }
}

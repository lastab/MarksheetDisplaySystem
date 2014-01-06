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
            class_insert_marks classMarks = new class_insert_marks();
            classMarks.Roll = Convert.ToInt32(cbRollNo.Text);
            classMarks.SubjectName = cbName.Text;
            classMarks.Assignment  = Convert.ToInt16(txtAssignment .Text);
            classMarks.Attendance = Convert.ToInt16(txtAttendence.Text);
            classMarks.TermTest  = Convert.ToInt16(txtTermTest.Text);
            classMarks.Practical = Convert.ToInt16 (txtPractical.Text);
            classMarks.Add_Student_Marks();
            ////Left to add data to database////
            MessageBox.Show("success");
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

      

    
    }
}

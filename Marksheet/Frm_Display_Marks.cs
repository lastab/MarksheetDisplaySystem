using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Marksheet
{
    public partial class Frm_Display_Marks : Form
    {
        class_view_marks  classViewMarks = new class_view_marks ();
        database db = new database();
        public Frm_Display_Marks()
        {
            InitializeComponent();
        }

        private void cbRollNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cbRollNo.Text != "System.Data.DataRowView")
            {
                classViewMarks.Roll = Convert.ToInt32(cbRollNo.Text);
                dt = classViewMarks.Get_Student_Marks();
                dgvMarks.DataSource = dt;
            }

        }

        private void Frm_Display_Marks_Load(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            dt = classViewMarks .Get_Student_Roll_With_Marks ();
            cbRollNo.DataSource = dt;
            cbRollNo.DisplayMember = "Student_Roll";
        }
    }
}

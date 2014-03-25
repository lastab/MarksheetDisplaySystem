using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        class_view_marks ViewMarks = new class_view_marks();
        class_studnet_details StudentDetails = new class_studnet_details();
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
                StudentDetails.Roll = Convert.ToInt32(cbRollNo.Text);
                ViewMarks.Roll = Convert.ToInt32(cbRollNo.Text);
                dt = ViewMarks.Get_Student_Marks();
                dgvMarks.DataSource = dt;

                StudentDetails.Get_Student_Details();
                lblName.Text = StudentDetails.FName;
                lblGender.Text = StudentDetails.Gender;
                lblPhone.Text = StudentDetails.Phone;
                lblAddress.Text = StudentDetails.Address;



                if (File.Exists("image\\" + ViewMarks.Roll + ".jpg"))

                    pbStudentPhoto.Image = Image.FromFile("image\\" + ViewMarks.Roll + ".jpg");
                else
                    if (StudentDetails.Gender == "male")
                        pbStudentPhoto.Image = Image.FromFile("image\\110300m.gif");
                    else
                        pbStudentPhoto.Image = Image.FromFile("image\\110300f.gif");



            }

        }

        private void Frm_Display_Marks_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ViewMarks.Get_Student_Roll_With_Marks();
            cbRollNo.DataSource = dt;
            cbRollNo.DisplayMember = "Student_Roll";
        }

        private void dgvMarks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();

            if (Global.userType != "student")
            {
                if (MessageBox.Show("Do you want to deleate the selected subject marks? ", "Delete!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ViewMarks.delete_Marks(dgvMarks.CurrentRow.Cells["Sub_code"].Value.ToString());
                    MessageBox.Show("the selected subject's marks of the student has been dealeated!");
                    dt = ViewMarks.Get_Student_Marks();
                    dgvMarks.DataSource = dt;
                }
            }

        }
    }
}

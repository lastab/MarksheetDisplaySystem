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
    public partial class Frm_Add_student : Form
    {
        class_studnet_details studentDetails = new class_studnet_details();
        public Frm_Add_student()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            studentDetails.Roll = Convert.ToInt32(txtRoll.Text);
            studentDetails.FName = txtFirstName.Text;
            studentDetails.LName = txtLastName.Text;
            studentDetails.Gender = rdbMale.Checked;
            studentDetails.DOB = dtpDOB.Value;
            studentDetails.Address = txtAddress.Text;
            studentDetails.Phone = txtPhone.Text;
            studentDetails.Add_Student_Details();
            MessageBox.Show("Success!");
        }
    }
}

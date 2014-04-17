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
    public partial class Frm_Login : Form
    {
        class_login cLogin = new class_login();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cLogin.userName = txtUser.Text;
                        /*
            if (rdoAdministrator.Checked == true)
            { cLogin.userType = "admin"; }
            else if (rdoTeacher.Checked == true)
            { cLogin.userType = "teacher"; }
           
            */
            cLogin.Password = txtPass.Text;
            if (cLogin.checkLoginSuccess())
            {
                cLogin.getUserType();
                Global.userType = cLogin.userType;
                MessageBox.Show("Welome " + cLogin.userName + "!","Welcome!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Global.frmMenu = new Frm_Menu();
                Global.frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failure!","Failure",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            string roll;
            DateTime DOB;
            roll = txt_roll.Text;
            DOB = dtpDOB.Value;
            if (cLogin.checkStudentLoginSuccess(roll, DOB))
            {
                MessageBox.Show("Login success!","Welcome!",MessageBoxButtons.OK,MessageBoxIcon.Information );
                Global.userType = "student";
                Global.student_roll=roll ;
                Global.frmMenu = new Frm_Menu();
                Global.frmMenu.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Login Failure!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

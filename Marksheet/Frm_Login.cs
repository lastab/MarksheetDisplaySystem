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
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            class_login cLogin = new class_login();
            if (rdoAdministrator.Checked == true)
            { cLogin.userType = "admin"; }
            else if (rdoTeacher.Checked == true)
            { cLogin.userType = "teacher"; }
            else
            { cLogin.userType = "student"; }

            cLogin.Password = txtPass.Text;
            if (cLogin.checkLoginSuccess())
            {
                Global.userType = cLogin.userType;
                MessageBox.Show("Welome " + cLogin.userType + "!");
                Global.frmMenu = new Frm_Menu();
                Global.frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failure!");
            }
        }
    }
}

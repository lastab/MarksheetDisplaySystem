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
            class_login classLogin = new class_login();
            if (rdoAdministrator.Checked == true && classLogin.getPassword("admin") == txtPass.Text)
            { Global.userType = 2; }
            else if (rdoTeacher.Checked == true && classLogin.getPassword("teacher") == txtPass.Text)
            { Global.userType = 1; }
            else
            { Global.userType = 0; }

            Global.frmMenu = new Frm_Menu();
            Global.frmMenu.Show();
            this.Hide();
        }
    }
}

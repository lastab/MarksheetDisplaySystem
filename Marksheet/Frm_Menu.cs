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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {            
            Global.frmAddStudent=new Frm_Add_student();
            Global.frmAddStudent.Show();
    
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            Global.frmAddSubjects = new frm_Add_Subjects();

            Global.frmAddSubjects.Show();

        }

        private void btnEnterMarks_Click(object sender, EventArgs e)
        {
            Global.frmInesrtMarks = new Frm_insert_marks();
            Global.frmInesrtMarks.Show();
        }

        private void btnSeeMarks_Click(object sender, EventArgs e)
        {
            Global.frmDisplayMarks = new Frm_Display_Marks();
            Global.frmDisplayMarks.Show();
  
        }

 
    }
}

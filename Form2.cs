using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegFormTryCatch
{
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            lblstudentno.Text = StudentInformationClass.SetStudentNo.ToString();
            lblname.Text = StudentInformationClass.SetFullName;
            lblprogram.Text = StudentInformationClass.SetProgram;
            lblbirthday.Text = StudentInformationClass.SetBirthday;
            lblgender.Text = StudentInformationClass.SetGender;
            lblcontactno.Text = StudentInformationClass.SetContactNo.ToString();
            lblage.Text = StudentInformationClass.SetAge.ToString();

        }
    }
}

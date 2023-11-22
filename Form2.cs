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
    public partial class frmFileName : Form
    {

        public string SetFileName { get; set; }

        public frmFileName()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text;
            Close();
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            
        }
    }
}

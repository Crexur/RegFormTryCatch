using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegFormTryCatch
{
    public partial class frmStudentRecord : Form
    {

        public string SetFileName { get; set; }

        public frmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            frmRegistration registrationForm = Application.OpenForms.OfType<frmRegistration>().FirstOrDefault();
            if (registrationForm != null)
            {
                registrationForm.Show();
            }
            else
            {
                frmRegistration showRegistration = new frmRegistration();
                showRegistration.Show();
            }
            this.Hide();

        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Findit();
        }

        public void Findit()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            string path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                IvShowText.Items.Clear();

                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    IvShowText.Items.Add(_getText);
                }
                MessageBox.Show("Successfully Uploaded!", "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void Upladit()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            string path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                IvShowText.Items.Clear();

                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    IvShowText.Items.Add(_getText);
                }

            }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!", "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            IvShowText.Items.Clear();
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegFormTryCatch
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public long StudentNumber(string studNum)
        {
            try
            {
                _StudentNo = long.Parse(studNum);
            }
            catch (FormatException)
            {
                throw new Exception("Invalid student number format.");
            }
            catch (OverflowException)
            {
                throw new Exception("Student number is too large.");
            }

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            try
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }
                else
                {
                    throw new Exception("Invalid contact number format.");
                }
            }
            catch (FormatException)
            {
                throw new Exception("Invalid contact number format.");
            }
            catch (OverflowException)
            {
                throw new Exception("Contact number is too large.");
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") && Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") && Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new Exception("Invalid name format.");
            }

            return _FullName;
        }

        public int Age(string age)
        {
            try
            {
                _Age = int.Parse(age);
            }
            catch (FormatException)
            {
                throw new Exception("Invalid age format.");
            }
            catch (OverflowException)
            {
                throw new Exception("Age is too large.");
            }

            return _Age;
        }

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[] { "BS Information Technology",
        "BS Computer Science", "BS Information Systems", "BS in Accountancy",
        "BS in Hospitality Management", "BS in Tourism Management"
        };

            for (int i = 0; i < 6; i++)
            {
                cbprogram.Items.Add(ListOfProgram[i].ToString());
            }

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInformationClass.SetFullName = FullName(txtlastname.Text, txtfirstname.Text, txtmiddleinitial.Text);
                StudentInformationClass.SetStudentNo = Convert.ToInt32(txtstudentno.Text);
                StudentInformationClass.SetProgram = cbprogram.Text;
                StudentInformationClass.SetGender = cbgender.Text;
                StudentInformationClass.SetContactNo = Convert.ToInt32(txtstudentno.Text);
                StudentInformationClass.SetAge = Age(txtage.Text);
                StudentInformationClass.SetBirthday = datepickerbirthday.Value.ToString("yyyy-MM-dd");

                frmConfirm frm = new frmConfirm();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
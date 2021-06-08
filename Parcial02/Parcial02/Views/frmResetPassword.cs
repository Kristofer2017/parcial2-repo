using System;
using System.Linq;
using System.Windows.Forms;

namespace Parcial02.Views
{
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }
/*
        private void btnReset_Click(object sender, EventArgs e)
        {
            var db = new UCAClinicContext();
            var UsersList = db.Users.OrderBy(u => u.CardID).ToList();

            var Result = UsersList.Where(u => 
                u.CardID.Equals(Int32.Parse(txtUsername.Text)) && u.Answer.Equals(txtSecurityQuestion.Text)).ToList();
            
            if(Result.Count == 0)
                MessageBox.Show("Username not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                frmEnterNewPassword windowEnterNewPassword = new frmEnterNewPassword();
                windowEnterNewPassword.ShowDialog();
                this.Hide();
            }
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            var db = new UCAClinicContext();
            lblSecurityQuestion.Text = db.SecurityQuestions.ToString();
        }
        */

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial02.Entities;
using Parcial02.Views;

namespace Parcial02
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            frmCreateUser windowCreateUser = new frmCreateUser();

            windowCreateUser.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new UCAClinicContext();
            var UsersList = db.Users.OrderBy(u => u.CardID).ToList();

            var Result = UsersList.Where(u => 
                u.CardID.Equals(Int32.Parse(txtUsername.Text)) && u.Password.Equals(txtPassword.Text)).ToList();
            
            if(Result.Count == 0)
                MessageBox.Show("Incorrect Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                frmPrincipal WindowPrincipal = new frmPrincipal();
                WindowPrincipal.ShowDialog();
                this.Hide();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            frmResetPassword WindowResetPassword = new frmResetPassword();

            WindowResetPassword.ShowDialog();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
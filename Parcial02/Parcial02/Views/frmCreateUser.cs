using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Parcial02.Entities;

namespace Parcial02
{
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool validations =
                txtName.Text.Length >= 3 &&
                txtLastName.Text.Length >= 3 &&
                txtPassword1.Text.Length >= 5 &&
                (txtPassword1.Text == txtPassword2.Text);

            if (validations) {

                //var db = new UCAClinicContext();
                //SecurityQuestion sq = db.Set<SecurityQuestion>().SingleOrDefault(s => s.id == SQref.id);


                //db.Add(NewUser);
                //db.SaveChanges();
                
                MessageBox.Show("User Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Hide();
            }else {
                MessageBox.Show("Incorrect Information, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            using(var db = new UCAClinicContext())
            {
                db.SecurityQuestions.RemoveRange(db.SecurityQuestions);
                var questionList = new List<SecurityQuestion>()
                {
                    new SecurityQuestion(1, "What year were you"),
                    new SecurityQuestion(2, "What was your first pet's name?"),
                    new SecurityQuestion(3, "What college did you graduate from?"),
                    new SecurityQuestion(4, "What is your favorite movie?")
                };
            
                questionList.ForEach(sq => db.Add(sq));
                db.SaveChanges();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
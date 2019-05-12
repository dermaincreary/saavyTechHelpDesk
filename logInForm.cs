using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saavyTechHelpDesk
{
    public partial class logInForm : Form
    {
        public logInForm()
        {
            InitializeComponent();
        }

        private void logInForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtPassword.Clear();
            txtusername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtusername.Text;
            var password = txtPassword.Text;

            //declare object of DB model
            var contx = new saavyTechDBE();

            //check if true value was returned fron the user check and grant access
            //If false, then continue to restrict access
            var user = contx.Users.SingleOrDefault(q => q.username == username && q.password == password);

            if (user != null)
            {
                var parent = (saavyTechManinForm)MdiParent;
                parent.isLoggedIn = true;

                var usr = user.firstName + " " + user.lastName;

                var roleID = user.roleId;
                int userid = user.Id;                

                parent.userName = usr;
                parent.userRole = (int)roleID;
                parent.userId = userid;

                parent.checkjobs();
                parent.UpdateMain();

                //notify icon
                txtNotify.Text = "User " + username + "is logged in";
                txtNotify.BalloonTipText = "User " + usr + " is logged in";
                txtNotify.BalloonTipTitle = "Login Successful";
                txtNotify.Icon = SystemIcons.Application;
                txtNotify.ShowBalloonTip(1000);
                this.Close();
            }

            else
            {
                MessageBox.Show("Invalid Credentials. Please try again.");
                txtusername.Text = "";
                txtPassword.Text = "";
                txtusername.Focus();
            }
        }
    }
}

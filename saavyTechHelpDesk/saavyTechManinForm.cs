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
    public partial class saavyTechManinForm : Form
    {
        public saavyTechManinForm()
        {
            InitializeComponent();
        }

        public bool isLoggedIn = false;
        public string userName;
        public int userId;
        public int userRole;

        public void checkjobs()
        {
            //declare object of DB model
            var contx = new saavyTechDBE();

            int newCount = contx.Jobs.Count(q => q.statusId == 1);
            int completeCount = contx.Jobs.Count(q => q.statusId == 3);

            //check jobs and show count 
            switch (userRole)
            {
                case 2:
                    lbljobCount.Text = completeCount.ToString() + " Completed Job(s) Available." ;
                    lbljobCount.ForeColor = Color.Blue;
                    break;
                case 3:
                    lbljobCount.Text = newCount.ToString() + " New Job(s) in Queue.";
                    lbljobCount.ForeColor = Color.Red;
                    break;               
            }

            
        }

        private void saavyTechManinForm_Load(object sender, EventArgs e)
        {
            UpdateMain();
            sslTime.Text = DateTime.Now.ToLongDateString();
        }
        
        // add logged in username to menu bar
        public void UpdateMain()
        {
            if (!isLoggedIn)
            {
                btnLogout.Text = "&Sign In";
                lblUser.Text = "";
                lbljobCount.Text = "";
                showLoginForm();
            }
            else
            {
                btnLogout.Text = "L&ogout";
                lblUser.Text = "Welcome: " + userName;
                checkjobs();
            }

        }

        private void showLoginForm()
        {
            if (Application.OpenForms["logInForm"] == null)
            {
                logInForm logIn = new logInForm();
                logIn.MdiParent = this;
                logIn.Show();
            }
            else
            {
                Application.OpenForms["loginform"].Focus();
            }
        }

        //logout user
        private void btnLogout_Click(object sender, EventArgs e)
        {
            isLoggedIn = false;   
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }            
            UpdateMain();
            
        }

        //open Users Form
        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (userRole != 1)
            {
                MessageBox.Show("RESTRICTED ACCESS!" + "\n\n" + "You do not have permission to view this form.");
            }
            else
            {
                if (isLoggedIn)
                {
                    if (Application.OpenForms["usersForm"] == null)
                    {
                        UpdateMain();

                        usersForm usersForm = new usersForm();
                        usersForm.MdiParent = this;
                        usersForm.Show();
                    }
                    else
                    {
                        Application.OpenForms["usersForm"].Focus();
                    }
                }
                else
                {
                    showLoginForm();
                }
            }
        }

        private void btnAddJobs_Click(object sender, EventArgs e)
        {
            if (userRole != 1 && userRole != 2)
            {
                MessageBox.Show("RESTRICTED ACCESS!" + "\n\n" + "You do not have permission to view this form.");
            }
            else
            {

                if (isLoggedIn)
                {
                    if (Application.OpenForms["addJobForm"] == null)
                    {
                        UpdateMain();

                        addJobForm addjob = new addJobForm();
                        addjob.MdiParent = this;
                        addjob.Show();
                    }
                    else
                    {
                        Application.OpenForms["addJobForm"].Focus();
                    }
                }
                else
                {
                    showLoginForm();
                }
            }
        }

        private void btnViewJobs_Click(object sender, EventArgs e)
        {
            if (userRole == 4)
            {
                MessageBox.Show("RESTRICTED ACCESS!" + "\n\n" + "You do not have permission to view this form.");
            }
            else { 

                if (isLoggedIn)
                {
                    if (Application.OpenForms["jobsForm"] == null)
                    {
                        UpdateMain();

                        jobsForm jobs = new jobsForm();
                        jobs.MdiParent = this;
                        jobs.Show();
                    }
                    else
                    {
                        Application.OpenForms["jobsForm"].Focus();
                    }
                }
                else
                {
                    showLoginForm();
                }
            }
        }   
    }
}

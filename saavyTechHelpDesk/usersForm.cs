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
    public partial class usersForm : Form
    {
        private saavyTechDBE contx;
        private int rowid;

        public usersForm()
        {
            InitializeComponent();
        }

        private void usersForm_Load(object sender, EventArgs e)
        {
            try { 

            contx = new saavyTechDBE();            

                //Populate the roles Dropdown and get roles
                var Roles = contx.userRole.ToList();

                // set roles datasource 
                cbouserRole.DataSource = Roles;

                //Set the data member and value member to the values
                cbouserRole.DisplayMember = "role";
                cbouserRole.ValueMember = "Id";

                //Populate The Grid View
                RefreshGridView();

                //Manually set the text you want for the column headers.
                gvusers.Columns["firstName"].HeaderText = "First Name";
                gvusers.Columns["lastName"].HeaderText = "Last Name";
                gvusers.Columns["phoneNumber"].HeaderText = "Phone #";
                gvusers.Columns["email"].HeaderText = "Email";
                gvusers.Columns["username"].HeaderText = "Username";
                gvusers.Columns["role"].HeaderText = "User Role";

                //Hide columns that you do not want to display for users
                gvusers.Columns[0].Visible = false;
                //Set the first row as selected by default
                //gvusers.Rows[0].Selected = true;

               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void RefreshGridView()
        {
            var users = contx.Users.Select(q => new {
                q.Id,
                q.firstName,
                q.lastName,
                //Using Lazy Loading, corresponding table linked via foreign key
                q.phoneNumber,               
                q.email,
                q.username,
                q.userRole.role
            }).ToList();
            gvusers.DataSource = users;
            gvusers.Refresh();
        }


        private void gvusers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var row = gvusers.SelectedRows[0];
                rowid = (int)row.Cells["Id"].Value;
                txtfname.Text = row.Cells["firstName"].Value.ToString();
                txtlname.Text = row.Cells["LastName"].Value.ToString();
                txtphoneNumber.Text = row.Cells["phoneNumber"].Value.ToString();
                txtemail.Text = row.Cells["email"].Value.ToString();
                txtusername.Text = row.Cells["username"].Value.ToString();
                var rowRole = row.Cells["role"].Value.ToString();
                var role = contx.userRole.FirstOrDefault(q => q.role == rowRole).Id;
                cbouserRole.SelectedValue = role;
            }
            catch (Exception)
            {
                
            }
        }

        int GetSelectedRow()
        {
            int row = (int)gvusers.SelectedRows[0].Cells[0].Value;
            return row;
        }

        Users GetUserByID(int Id)
        {
            var user = contx.Users.Find(Id);
            return user;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Collect data from the form
                var fname = UppercaseFirst(txtfname.Text);
                var lname = UppercaseFirst(txtlname.Text);
                var pNumber = txtphoneNumber.Text;
                var Email = txtemail.Text;
                var uName = txtusername.Text;
                var uRole = Convert.ToInt32(cbouserRole.SelectedValue);

                //Validate minimum data is collected, as well as any other validation that you may want to enforce.
                if (isFormInvalid())
                {
                    MessageBox.Show("Please validate all data before submission!");
                }
                else
                {
                    var user = GetUserByID(rowid);
                    user.firstName = fname;
                    user.lastName = lname;
                    user.phoneNumber = pNumber;
                    user.email = Email;                    
                    user.roleId = uRole;

                    contx.SaveChanges();
                    MessageBox.Show("User " + uName + " successfully updated.");

                    RefreshGridView();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A fatal error occurred. {ex.Message}");
            }
        }

        public string UppercaseFirst(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Collect data from the form
                var fname = UppercaseFirst(txtfname.Text);
                var lname = UppercaseFirst(txtlname.Text);
                var pNumber = txtphoneNumber.Text;
                var mail = txtemail.Text;
                var uName = txtusername.Text;
                var uRole = Convert.ToInt32(cbouserRole.SelectedValue);

                var rand = new Random();
                var pWord = $"{fname[0]}{lname}{rand.Next(10, 99)}";

                //Validate minimum data is collected, as well as any other validation that you may want to enforce.
                if (isFormInvalid())
                {
                    MessageBox.Show("Please validate all data before submission!");
                }
                //Do further validations to check for username and email address
                else if (CheckEmail(mail) || CheckUserName(uName))
                {
                    MessageBox.Show("A user exists with this email/username!");
                }
                else
                {
                    var user = new Users
                    {
                       
                        firstName = fname,
                        lastName = lname,
                        phoneNumber = pNumber,
                        email = mail,
                        username = uName,
                        roleId = uRole,
                        password = pWord,
                        dateCreated = DateTime.Now
                    };

                    contx.Users.Add(user);
                    contx.SaveChanges();
                    MessageBox.Show("User " + uName + " successfully added.");

                    //Functions to Reset the fields to blank and reload all the data in the GridView
                    //The reload makes the changes appear near real-time.
                    RefreshGridView();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There has been a fatal error: {ex.Message}");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var userToDelete = GetUserByID(rowid);
                if (userToDelete != null)
                {
                    contx.Users.Remove(userToDelete);
                    contx.SaveChanges();
                    ResetForm();
                    RefreshGridView();
                }
                else
                {
                    MessageBox.Show("No User was found with this ID");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"A fatal error occurred. {ex.Message}");
            }
        }

        void ResetForm()
        {
            txtfname.Clear();
            txtlname.Clear();
            txtphoneNumber.Clear();
            txtemail.Clear();
            txtusername.Clear();
            cbouserRole.SelectedIndex = 0;
        }

        bool CheckEmail(string mail)
        {
            var emailExists = contx.Users.Any(q => q.email.Trim() == mail);
            return emailExists;
        }

        bool CheckUserName(string uName)
        {
            var usernameExists = contx.Users.Any(q => q.username.Trim() == uName);
            return usernameExists;
        }

        bool isFormInvalid()
        {
            return String.IsNullOrEmpty(txtemail.Text) || String.IsNullOrEmpty(txtusername.Text);
        }
    }
}

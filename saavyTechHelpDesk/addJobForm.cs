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
    public partial class addJobForm : Form
    {
        private saavyTechDBE contx;

       
        public addJobForm()
        {
            InitializeComponent();
        }

        private void addJobForm_Load(object sender, EventArgs e)
        {
            try
            {
                contx = new saavyTechDBE();               

                //Populate the equipment Dropdown
                var equipment = contx.equiptmentType.ToList();
                cboequipType.DataSource = equipment;
                cboequipType.DisplayMember = "equiptmentName";
                cboequipType.ValueMember = "Id";

                //Populate the brand Dropdown
                var brand = contx.Brand.ToList();
                cbobrand.DataSource = brand;
                cbobrand.DisplayMember = "brandName";
                cbobrand.ValueMember = "Id";

                //Populate the status Dropdown
                var status = contx.status.ToList();
                cbostatus.DataSource = status;
                cbostatus.DisplayMember = "statusName";
                cbostatus.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string UppercaseFirst(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void btnsaveJob_Click(object sender, EventArgs e)
        {
            var parent = (saavyTechManinForm)MdiParent;
            var roleId = parent.userRole;

            try
            {
                //Collect data from the form
                var fname = UppercaseFirst(txtfName.Text);
                var lname = UppercaseFirst(txtlName.Text);
                var pNumber = txtphoneNum.Text;
                var mail = txtemail.Text;
                var model = txtmodel.Text;
                var serial = txtserial.Text;
                var problem = txtproblem.Text;

                var equipment = Convert.ToInt32(cboequipType.SelectedValue);
                var brand = Convert.ToInt32(cbobrand.SelectedValue);
                var status = Convert.ToInt32(cbostatus.SelectedValue);

                //generate job number
                char[] letters = "qwertyuiopasdfghjklzxcvbnm0123456789".ToCharArray();
                Random l = new Random();
                string randomString = "";
                for (int i = 0; i < 6; i++)
                {
                    randomString += letters[l.Next(0, 35)].ToString();
                }
                var jobNumber = $"{fname[0]}{lname[0]}{randomString}";

                //Validate minimum data is collected, as well as any other validation that you may want to enforce.
                if (isFormInvalid())
                {
                    MessageBox.Show("Please validate all data before submission!");
                }

                //Do further validations to check if job number already exists
                else if (CheckJob(jobNumber))
                {
                    MessageBox.Show("This job already exists!");
                }
                else
                {
                    var newJob = new Jobs
                    {
                        firstName = fname,
                        lastName = lname,
                        contact = pNumber,
                        email = mail,
                        equipmentTypeId = equipment,
                        brandId = brand,
                        model = model,
                        serial = serial,
                        issues = problem,
                        statusId = status,
                        recepId = roleId,
                        dateIn = DateTime.Now,
                        jobNumber = jobNumber                        
                    };

                    contx.Jobs.Add(newJob);
                    contx.SaveChanges();
                    MessageBox.Show("Job #" + jobNumber + " \nfor " + fname + " " + lname + " successfully added.");

                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A fatal. {ex.Message}");
            }
        }

        void ResetForm()
        {
            txtfName.Clear();
            txtlName.Clear();
            txtphoneNum.Clear();
            txtemail.Clear();
            txtmodel.Clear();
            txtserial.Clear();
            txtproblem.Clear();

            cboequipType.SelectedIndex = 0;
            cbobrand.SelectedIndex = 0;            
            cbostatus.SelectedIndex = 0;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        bool CheckJob(string jobNumber)
        {
            var jobExists = contx.Jobs.Any(q => q.jobNumber.Trim() == jobNumber);
            return jobExists;
        }

        bool isFormInvalid()
        {
            return String.IsNullOrEmpty(txtfName.Text) || String.IsNullOrEmpty(txtphoneNum.Text);
        }
    }
}

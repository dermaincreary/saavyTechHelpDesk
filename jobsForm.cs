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
    public partial class jobsForm : Form
    {
        private saavyTechDBE contx;
        private int rowid;
        
        
        public jobsForm()
        {
            InitializeComponent();
        }
        
        //check user roles and enable/disable controls accordingly
        void checkRole()
        {
            var parent = (saavyTechManinForm)MdiParent;
            var uRole = parent.userRole;

            if (uRole == 1)
            {
                txtproblem.ReadOnly = true;
                txttechReport.ReadOnly = true;
            }
            else if (uRole == 2)
            {
                txtproblem.ReadOnly = false;
                txttechReport.ReadOnly = true;
            }
            else if (uRole == 3)
            {
                txtproblem.ReadOnly = true;
                txttechReport.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("RESTRICTED ACCESS!" + "\n\n" + "You do not have permission to view this form.");
            }

            btnupdateJob.Enabled = true;

        }

        private void jobsForm_Load(object sender, EventArgs e)
        {
            contx = new saavyTechDBE();
            
            checkRole();

            try
            {
                //Populate the status Dropdown and get status
                var status = contx.status.ToList();

                // set roles datasource 
                cbostatus.DataSource = status;

                //Set the data member and value member to the values
                cbostatus.DisplayMember = "statusName";
                cbostatus.ValueMember = "Id";

                //Populate The Grid View
                RefreshGridView();

                //Manually set the text you want for the column headers.
                gvJobs.Columns["firstName"].HeaderText = "First Name";
                gvJobs.Columns["lastName"].HeaderText = "Last Name";
                gvJobs.Columns["jobNumber"].HeaderText = "Job Number";
                gvJobs.Columns["equiptmentName"].HeaderText = "Equipment";
                gvJobs.Columns["brandName"].HeaderText = "Brand";
                gvJobs.Columns["model"].HeaderText = "Model";
                gvJobs.Columns["serial"].HeaderText = "Serial";
                gvJobs.Columns["issues"].HeaderText = "Problems";
                gvJobs.Columns["techReport"].HeaderText = "Tech Report";
                gvJobs.Columns["statusName"].HeaderText = "Status";

                //Hide columns that you do not want to display for users
                gvJobs.Columns[0].Visible = false;

                //Set the first row as selected by default
                //gvJobs.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //efresh dataviewgrid from database
        void RefreshGridView()
        {
            var parent = (saavyTechManinForm)MdiParent;

            var jobs = contx.Jobs.Select(q => new {
                q.Id,
                q.firstName,
                q.lastName,
                q.jobNumber,
                q.equiptmentType.equiptmentName,
                q.Brand.brandName,
                q.model,
                q.serial,
                q.issues,
                q.techReport,               
               q.status.statusName
            }).ToList();
            gvJobs.DataSource = jobs;
            //update job count on mdi parent
            parent.checkjobs();
            //refresh jobs data
            gvJobs.Refresh();
            
            
        }

        //fill form with data on selection of datagrid row
        private void gvJobs_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                checkRole();

                var row = gvJobs.SelectedRows[0];
                rowid = (int)row.Cells["Id"].Value;
                lblfName.Text = row.Cells["firstName"].Value.ToString();
                lbllName.Text = row.Cells["LastName"].Value.ToString();
                lbljobnumber.Text = row.Cells["jobNumber"].Value.ToString();
                lblequipmentType.Text = row.Cells["equiptmentName"].Value.ToString();
                lblbrand.Text = row.Cells["brandName"].Value.ToString();
                lblmodel.Text = row.Cells["model"].Value.ToString();
                lblserial.Text = row.Cells["serial"].Value.ToString();
                txtproblem.Text = row.Cells["issues"].Value.ToString();
                txttechReport.Text = row.Cells["techReport"].Value.ToString();

                
                var rowStatus = row.Cells["statusName"].Value.ToString();
                var status = contx.status.FirstOrDefault(q => q.statusName == rowStatus).Id;
                cbostatus.SelectedValue = status;


                //disable editing in job is collected
                if (cbostatus.SelectedIndex == 3 || cbostatus.SelectedIndex == 4)
                {
                    txtproblem.ReadOnly = true;
                    txttechReport.ReadOnly = true;
                    btnupdateJob.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        int GetSelectedRow()
        {
            int row = (int)gvJobs.SelectedRows[0].Cells[0].Value;
            return row;
        }

        Jobs GetJobByID(int Id)
        {
            var job = contx.Jobs.Find(Id);
            return job;
        }
        
        private void btnupdateJob_Click(object sender, EventArgs e)
        {
            try { 
                var parent = (saavyTechManinForm)MdiParent;

                if (cbostatus.SelectedIndex == 3)
                {
                    //Collect data from the form
                    var techReport = txttechReport.Text;
                    var status = Convert.ToInt32(cbostatus.SelectedValue);
                    var job = GetJobByID(rowid);
                    job.techReport = techReport;
                    job.techId = parent.userId;
                    job.statusId = status;
                    job.dateCollected = DateTime.Now;
                    contx.SaveChanges();
                    MessageBox.Show("Job successfully updated.");
                }
                else
                {
                    var techReport = txttechReport.Text;
                    var status = Convert.ToInt32(cbostatus.SelectedValue);
                    var job = GetJobByID(rowid);
                    job.techReport = techReport;
                    job.techId = parent.userId;
                    job.statusId = status;
                    job.dateRepaired = DateTime.Now;
                    contx.SaveChanges();
                    MessageBox.Show("Job successfully updated.");
                }
                RefreshGridView();
                txttechReport.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txttechReport.Clear();
        }

        

    }
}

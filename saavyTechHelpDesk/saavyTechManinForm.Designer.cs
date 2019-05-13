namespace saavyTechHelpDesk
{
    partial class saavyTechManinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saavyTechManinForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnViewJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbljobCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnJobs,
            this.btnAdmin,
            this.btnLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnJobs
            // 
            this.btnJobs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddJobs,
            this.btnViewJobs});
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(42, 20);
            this.btnJobs.Text = "Jobs";
            // 
            // btnAddJobs
            // 
            this.btnAddJobs.Name = "btnAddJobs";
            this.btnAddJobs.Size = new System.Drawing.Size(125, 22);
            this.btnAddJobs.Text = "Add Jobs";
            this.btnAddJobs.Click += new System.EventHandler(this.btnAddJobs_Click);
            // 
            // btnViewJobs
            // 
            this.btnViewJobs.Name = "btnViewJobs";
            this.btnViewJobs.Size = new System.Drawing.Size(125, 22);
            this.btnViewJobs.Text = "View Jobs";
            this.btnViewJobs.Click += new System.EventHandler(this.btnViewJobs_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsers});
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(55, 20);
            this.btnAdmin.Text = "Admin";
            // 
            // btnUsers
            // 
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(102, 22);
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(57, 20);
            this.btnLogout.Text = "&Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(300, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslTime
            // 
            this.sslTime.Name = "sslTime";
            this.sslTime.Size = new System.Drawing.Size(118, 17);
            this.sslTime.Text = "toolStripStatusLabel1";
            // 
            // lbljobCount
            // 
            this.lbljobCount.AutoSize = true;
            this.lbljobCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljobCount.Location = new System.Drawing.Point(500, 6);
            this.lbljobCount.Name = "lbljobCount";
            this.lbljobCount.Size = new System.Drawing.Size(0, 13);
            this.lbljobCount.TabIndex = 7;
            // 
            // saavyTechManinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lbljobCount);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "saavyTechManinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "saavyTech Help Desk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.saavyTechManinForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnJobs;
        private System.Windows.Forms.ToolStripMenuItem btnAddJobs;
        private System.Windows.Forms.ToolStripMenuItem btnViewJobs;
        private System.Windows.Forms.ToolStripMenuItem btnAdmin;
        private System.Windows.Forms.ToolStripMenuItem btnUsers;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslTime;
        private System.Windows.Forms.Label lbljobCount;
    }
}


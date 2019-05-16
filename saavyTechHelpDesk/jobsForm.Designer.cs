namespace saavyTechHelpDesk
{
    partial class jobsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jobsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblstatus = new System.Windows.Forms.Label();
            this.gbtechReport = new System.Windows.Forms.GroupBox();
            this.txttechReport = new System.Windows.Forms.TextBox();
            this.lblissues = new System.Windows.Forms.Label();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.btnupdateJob = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtproblem = new System.Windows.Forms.TextBox();
            this.gbinfo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblserial = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.lbllName = new System.Windows.Forms.Label();
            this.lbljobnumber = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.lblfName = new System.Windows.Forms.Label();
            this.lblequipmentType = new System.Windows.Forms.Label();
            this.gvJobs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbtechReport.SuspendLayout();
            this.gbinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.lblstatus);
            this.splitContainer1.Panel1.Controls.Add(this.gbtechReport);
            this.splitContainer1.Panel1.Controls.Add(this.lblissues);
            this.splitContainer1.Panel1.Controls.Add(this.cbostatus);
            this.splitContainer1.Panel1.Controls.Add(this.btnupdateJob);
            this.splitContainer1.Panel1.Controls.Add(this.btnreset);
            this.splitContainer1.Panel1.Controls.Add(this.txtproblem);
            this.splitContainer1.Panel1.Controls.Add(this.gbinfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gvJobs);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 511);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(16, 270);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(67, 13);
            this.lblstatus.TabIndex = 4;
            this.lblstatus.Text = "Job Status";
            // 
            // gbtechReport
            // 
            this.gbtechReport.BackColor = System.Drawing.Color.Transparent;
            this.gbtechReport.Controls.Add(this.txttechReport);
            this.gbtechReport.Location = new System.Drawing.Point(12, 313);
            this.gbtechReport.Name = "gbtechReport";
            this.gbtechReport.Size = new System.Drawing.Size(250, 139);
            this.gbtechReport.TabIndex = 8;
            this.gbtechReport.TabStop = false;
            this.gbtechReport.Text = "Technician Report";
            // 
            // txttechReport
            // 
            this.txttechReport.Location = new System.Drawing.Point(7, 22);
            this.txttechReport.Multiline = true;
            this.txttechReport.Name = "txttechReport";
            this.txttechReport.Size = new System.Drawing.Size(233, 103);
            this.txttechReport.TabIndex = 2;
            // 
            // lblissues
            // 
            this.lblissues.AutoSize = true;
            this.lblissues.BackColor = System.Drawing.Color.Transparent;
            this.lblissues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblissues.Location = new System.Drawing.Point(16, 144);
            this.lblissues.Name = "lblissues";
            this.lblissues.Size = new System.Drawing.Size(58, 13);
            this.lblissues.TabIndex = 6;
            this.lblissues.Text = "Problems";
            // 
            // cbostatus
            // 
            this.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Location = new System.Drawing.Point(87, 267);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(165, 21);
            this.cbostatus.TabIndex = 3;
            // 
            // btnupdateJob
            // 
            this.btnupdateJob.Image = ((System.Drawing.Image)(resources.GetObject("btnupdateJob.Image")));
            this.btnupdateJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdateJob.Location = new System.Drawing.Point(136, 461);
            this.btnupdateJob.Name = "btnupdateJob";
            this.btnupdateJob.Size = new System.Drawing.Size(103, 35);
            this.btnupdateJob.TabIndex = 5;
            this.btnupdateJob.Text = "Update Job";
            this.btnupdateJob.UseVisualStyleBackColor = true;
            this.btnupdateJob.Click += new System.EventHandler(this.btnupdateJob_Click);
            // 
            // btnreset
            // 
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(29, 461);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(88, 35);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtproblem
            // 
            this.txtproblem.Location = new System.Drawing.Point(19, 162);
            this.txtproblem.Multiline = true;
            this.txtproblem.Name = "txtproblem";
            this.txtproblem.Size = new System.Drawing.Size(233, 88);
            this.txtproblem.TabIndex = 1;
            // 
            // gbinfo
            // 
            this.gbinfo.BackColor = System.Drawing.Color.Transparent;
            this.gbinfo.Controls.Add(this.label6);
            this.gbinfo.Controls.Add(this.label5);
            this.gbinfo.Controls.Add(this.label4);
            this.gbinfo.Controls.Add(this.label3);
            this.gbinfo.Controls.Add(this.label2);
            this.gbinfo.Controls.Add(this.label1);
            this.gbinfo.Controls.Add(this.lblserial);
            this.gbinfo.Controls.Add(this.lblbrand);
            this.gbinfo.Controls.Add(this.lbllName);
            this.gbinfo.Controls.Add(this.lbljobnumber);
            this.gbinfo.Controls.Add(this.lblmodel);
            this.gbinfo.Controls.Add(this.lblfName);
            this.gbinfo.Controls.Add(this.lblequipmentType);
            this.gbinfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbinfo.Location = new System.Drawing.Point(12, 12);
            this.gbinfo.Name = "gbinfo";
            this.gbinfo.Size = new System.Drawing.Size(251, 249);
            this.gbinfo.TabIndex = 7;
            this.gbinfo.TabStop = false;
            this.gbinfo.Text = "Job Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Serial/ Service Tag:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Brand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equipment Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job #:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // lblserial
            // 
            this.lblserial.AutoSize = true;
            this.lblserial.Location = new System.Drawing.Point(135, 113);
            this.lblserial.Name = "lblserial";
            this.lblserial.Size = new System.Drawing.Size(0, 13);
            this.lblserial.TabIndex = 0;
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Location = new System.Drawing.Point(57, 92);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(0, 13);
            this.lblbrand.TabIndex = 0;
            // 
            // lbllName
            // 
            this.lbllName.AutoSize = true;
            this.lbllName.Location = new System.Drawing.Point(118, 26);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(0, 13);
            this.lbllName.TabIndex = 0;
            // 
            // lbljobnumber
            // 
            this.lbljobnumber.AutoSize = true;
            this.lbljobnumber.Location = new System.Drawing.Point(56, 48);
            this.lbljobnumber.Name = "lbljobnumber";
            this.lbljobnumber.Size = new System.Drawing.Size(0, 13);
            this.lbljobnumber.TabIndex = 0;
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Location = new System.Drawing.Point(175, 92);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(0, 13);
            this.lblmodel.TabIndex = 0;
            // 
            // lblfName
            // 
            this.lblfName.AutoSize = true;
            this.lblfName.Location = new System.Drawing.Point(55, 26);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(0, 13);
            this.lblfName.TabIndex = 0;
            // 
            // lblequipmentType
            // 
            this.lblequipmentType.AutoSize = true;
            this.lblequipmentType.Location = new System.Drawing.Point(115, 70);
            this.lblequipmentType.Name = "lblequipmentType";
            this.lblequipmentType.Size = new System.Drawing.Size(0, 13);
            this.lblequipmentType.TabIndex = 0;
            // 
            // gvJobs
            // 
            this.gvJobs.AllowUserToAddRows = false;
            this.gvJobs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightBlue;
            this.gvJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvJobs.Location = new System.Drawing.Point(0, 0);
            this.gvJobs.Name = "gvJobs";
            this.gvJobs.Size = new System.Drawing.Size(906, 511);
            this.gvJobs.TabIndex = 0;
            this.gvJobs.SelectionChanged += new System.EventHandler(this.gvJobs_SelectionChanged);
            // 
            // jobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "jobsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "saavyTech Job Management";
            this.Load += new System.EventHandler(this.jobsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbtechReport.ResumeLayout(false);
            this.gbtechReport.PerformLayout();
            this.gbinfo.ResumeLayout(false);
            this.gbinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gvJobs;
        private System.Windows.Forms.Button btnupdateJob;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ComboBox cbostatus;
        private System.Windows.Forms.TextBox txttechReport;
        private System.Windows.Forms.TextBox txtproblem;
        private System.Windows.Forms.Label lblserial;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.Label lbllName;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Label lblequipmentType;
        private System.Windows.Forms.Label lblfName;
        private System.Windows.Forms.Label lblissues;
        private System.Windows.Forms.GroupBox gbinfo;
        private System.Windows.Forms.GroupBox gbtechReport;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lbljobnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
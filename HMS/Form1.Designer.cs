namespace HMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bILLINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOCTORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pATIENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanPlaceHolder = new System.Windows.Forms.UserControl();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocteCbinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatientDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dischargePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabinBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientChargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPatientBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bILLINGToolStripMenuItem
            // 
            this.bILLINGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientBillToolStripMenuItem,
            this.storeCostToolStripMenuItem,
            this.totalPatientBillToolStripMenuItem});
            this.bILLINGToolStripMenuItem.Name = "bILLINGToolStripMenuItem";
            this.bILLINGToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bILLINGToolStripMenuItem.Text = "BILLING";
            // 
            // dOCTORToolStripMenuItem
            // 
            this.dOCTORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorToolStripMenuItem,
            this.deleteDoctorToolStripMenuItem,
            this.viewScheduleToolStripMenuItem});
            this.dOCTORToolStripMenuItem.Name = "dOCTORToolStripMenuItem";
            this.dOCTORToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dOCTORToolStripMenuItem.Text = "DOCTOR";
            // 
            // pATIENTToolStripMenuItem
            // 
            this.pATIENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.assignDoctorToolStripMenuItem,
            this.allocteCbinToolStripMenuItem,
            this.scheduleOTToolStripMenuItem,
            this.updatePatientDataToolStripMenuItem,
            this.dischargePatientToolStripMenuItem});
            this.pATIENTToolStripMenuItem.Name = "pATIENTToolStripMenuItem";
            this.pATIENTToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.pATIENTToolStripMenuItem.Text = "PATIENT";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.pATIENTToolStripMenuItem,
            this.dOCTORToolStripMenuItem,
            this.bILLINGToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.aboutHMSToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "HELP";
            // 
            // PanPlaceHolder
            // 
            this.PanPlaceHolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanPlaceHolder.Location = new System.Drawing.Point(12, 58);
            this.PanPlaceHolder.Name = "PanPlaceHolder";
            this.PanPlaceHolder.Size = new System.Drawing.Size(786, 525);
            this.PanPlaceHolder.TabIndex = 5;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::HMS.Properties.Resources.home;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem2.Text = "Home";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::HMS.Properties.Resources._2125_3226_128_exit_power_quit_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Image = global::HMS.Properties.Resources.stock_vector_vector_register_icon_80961514;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // assignDoctorToolStripMenuItem
            // 
            this.assignDoctorToolStripMenuItem.Image = global::HMS.Properties.Resources.icon_auto_assign;
            this.assignDoctorToolStripMenuItem.Name = "assignDoctorToolStripMenuItem";
            this.assignDoctorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.assignDoctorToolStripMenuItem.Text = "Assign Doctor";
            this.assignDoctorToolStripMenuItem.Click += new System.EventHandler(this.assignDoctorToolStripMenuItem_Click);
            // 
            // allocteCbinToolStripMenuItem
            // 
            this.allocteCbinToolStripMenuItem.Image = global::HMS.Properties.Resources.functions_icon_thinprov;
            this.allocteCbinToolStripMenuItem.Name = "allocteCbinToolStripMenuItem";
            this.allocteCbinToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.allocteCbinToolStripMenuItem.Text = "Allocate Cabin";
            this.allocteCbinToolStripMenuItem.Click += new System.EventHandler(this.allocteCbinToolStripMenuItem_Click);
            // 
            // scheduleOTToolStripMenuItem
            // 
            this.scheduleOTToolStripMenuItem.Image = global::HMS.Properties.Resources.images;
            this.scheduleOTToolStripMenuItem.Name = "scheduleOTToolStripMenuItem";
            this.scheduleOTToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.scheduleOTToolStripMenuItem.Text = "Schedule OT";
            this.scheduleOTToolStripMenuItem.Click += new System.EventHandler(this.scheduleOTToolStripMenuItem_Click);
            // 
            // updatePatientDataToolStripMenuItem
            // 
            this.updatePatientDataToolStripMenuItem.Image = global::HMS.Properties.Resources.CompuPic;
            this.updatePatientDataToolStripMenuItem.Name = "updatePatientDataToolStripMenuItem";
            this.updatePatientDataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.updatePatientDataToolStripMenuItem.Text = "View Patient Data";
            this.updatePatientDataToolStripMenuItem.Click += new System.EventHandler(this.updatePatientDataToolStripMenuItem_Click);
            // 
            // dischargePatientToolStripMenuItem
            // 
            this.dischargePatientToolStripMenuItem.Image = global::HMS.Properties.Resources.discharge;
            this.dischargePatientToolStripMenuItem.Name = "dischargePatientToolStripMenuItem";
            this.dischargePatientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.dischargePatientToolStripMenuItem.Text = "Discharge Patient";
            this.dischargePatientToolStripMenuItem.Click += new System.EventHandler(this.dischargePatientToolStripMenuItem_Click);
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Image = global::HMS.Properties.Resources.add;
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addDoctorToolStripMenuItem.Text = "Add Doctor";
            this.addDoctorToolStripMenuItem.Click += new System.EventHandler(this.addDoctorToolStripMenuItem_Click);
            // 
            // deleteDoctorToolStripMenuItem
            // 
            this.deleteDoctorToolStripMenuItem.Image = global::HMS.Properties.Resources.DeleteRed;
            this.deleteDoctorToolStripMenuItem.Name = "deleteDoctorToolStripMenuItem";
            this.deleteDoctorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteDoctorToolStripMenuItem.Text = "Delete Doctor";
            this.deleteDoctorToolStripMenuItem.Click += new System.EventHandler(this.deleteDoctorToolStripMenuItem_Click);
            // 
            // viewScheduleToolStripMenuItem
            // 
            this.viewScheduleToolStripMenuItem.Image = global::HMS.Properties.Resources.CompuPic;
            this.viewScheduleToolStripMenuItem.Name = "viewScheduleToolStripMenuItem";
            this.viewScheduleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viewScheduleToolStripMenuItem.Text = "View Schedule";
            this.viewScheduleToolStripMenuItem.Click += new System.EventHandler(this.viewScheduleToolStripMenuItem_Click);
            // 
            // patientBillToolStripMenuItem
            // 
            this.patientBillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cabinBillToolStripMenuItem});
            this.patientBillToolStripMenuItem.Image = global::HMS.Properties.Resources.bill;
            this.patientBillToolStripMenuItem.Name = "patientBillToolStripMenuItem";
            this.patientBillToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.patientBillToolStripMenuItem.Text = "Cabin";
            // 
            // cabinBillToolStripMenuItem
            // 
            this.cabinBillToolStripMenuItem.Image = global::HMS.Properties.Resources.cabin;
            this.cabinBillToolStripMenuItem.Name = "cabinBillToolStripMenuItem";
            this.cabinBillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cabinBillToolStripMenuItem.Text = "Patient Bill";
            this.cabinBillToolStripMenuItem.Click += new System.EventHandler(this.cabinBillToolStripMenuItem_Click);
            // 
            // storeCostToolStripMenuItem
            // 
            this.storeCostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientChargeToolStripMenuItem});
            this.storeCostToolStripMenuItem.Image = global::HMS.Properties.Resources.cost;
            this.storeCostToolStripMenuItem.Name = "storeCostToolStripMenuItem";
            this.storeCostToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.storeCostToolStripMenuItem.Text = "Store";
            // 
            // patientChargeToolStripMenuItem
            // 
            this.patientChargeToolStripMenuItem.Image = global::HMS.Properties.Resources.bill1;
            this.patientChargeToolStripMenuItem.Name = "patientChargeToolStripMenuItem";
            this.patientChargeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.patientChargeToolStripMenuItem.Text = "Patient Charge";
            this.patientChargeToolStripMenuItem.Click += new System.EventHandler(this.patientChargeToolStripMenuItem_Click);
            // 
            // totalPatientBillToolStripMenuItem
            // 
            this.totalPatientBillToolStripMenuItem.Image = global::HMS.Properties.Resources.cost1;
            this.totalPatientBillToolStripMenuItem.Name = "totalPatientBillToolStripMenuItem";
            this.totalPatientBillToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.totalPatientBillToolStripMenuItem.Text = "Total Patient Bill";
            this.totalPatientBillToolStripMenuItem.Click += new System.EventHandler(this.totalPatientBillToolStripMenuItem_Click);
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Image = global::HMS.Properties.Resources.help;
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Image = global::HMS.Properties.Resources.About_icon;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // aboutHMSToolStripMenuItem
            // 
            this.aboutHMSToolStripMenuItem.Image = global::HMS.Properties.Resources.about;
            this.aboutHMSToolStripMenuItem.Name = "aboutHMSToolStripMenuItem";
            this.aboutHMSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutHMSToolStripMenuItem.Text = "About HMS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 595);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PanPlaceHolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hospital Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem patientBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bILLINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOCTORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePatientDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocteCbinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pATIENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleOTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.UserControl PanPlaceHolder;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dischargePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabinBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientChargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalPatientBillToolStripMenuItem;
    }
}


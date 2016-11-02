using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace HMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel1 = new UserControl1();
            panel1.Size = PanPlaceHolder.Size;
            Controls.Add(panel1);

            PanPlaceHolder = panel1;

            /*string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();*/
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel1 = new UserControl1();
            panel1.Size = PanPlaceHolder.Size;
            Controls.Add(panel1);

            PanPlaceHolder = panel1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel2 = new UserControl2();
            panel2.Size = PanPlaceHolder.Size;
            Controls.Add(panel2);

            PanPlaceHolder = panel2;
        }

        private void allocteCbinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel3 = new UserControl3();
            panel3.Size = PanPlaceHolder.Size;
            Controls.Add(panel3);

            PanPlaceHolder = panel3;
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel6 = new UserControl6();
            panel6.Size = PanPlaceHolder.Size;
            Controls.Add(panel6);

            PanPlaceHolder = panel6;
        }

        private void assignDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel5 = new UserControl5();
            panel5.Size = PanPlaceHolder.Size;
            Controls.Add(panel5);

            PanPlaceHolder = panel5;
        }

        private void scheduleOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel7 = new UserControl7();
            panel7.Size = PanPlaceHolder.Size;
            Controls.Add(panel7);

            PanPlaceHolder = panel7;
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel8 = new UserControl8();
            panel8.Size = PanPlaceHolder.Size;
            Controls.Add(panel8);

            PanPlaceHolder = panel8;
        }

        private void updatePatientDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel9 = new UserControl9();
            panel9.Size = PanPlaceHolder.Size;
            Controls.Add(panel9);

            PanPlaceHolder = panel9;
        }

        private void deleteDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel10 = new UserControl10();
            panel10.Size = PanPlaceHolder.Size;
            Controls.Add(panel10);

            PanPlaceHolder = panel10;
        }

        private void dischargePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel11 = new UserControl11();
            panel11.Size = PanPlaceHolder.Size;
            Controls.Add(panel11);

            PanPlaceHolder = panel11;
        }

        private void cabinBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel4 = new UserControl4();
            panel4.Size = PanPlaceHolder.Size;
            Controls.Add(panel4);

            PanPlaceHolder = panel4;
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel1 = new UserControl1();
            panel1.Size = PanPlaceHolder.Size;
            Controls.Add(panel1);

            PanPlaceHolder = panel1;
        }

        private void patientChargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel12 = new UserControl12();
            panel12.Size = PanPlaceHolder.Size;
            Controls.Add(panel12);

            PanPlaceHolder = panel12;
        }

        private void totalPatientBillToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Controls.Remove(PanPlaceHolder);
            PanPlaceHolder.Visible = false;

            var panel13 = new UserControl13();
            panel13.Size = PanPlaceHolder.Size;
            Controls.Add(panel13);

            PanPlaceHolder = panel13;
        }
    }
}

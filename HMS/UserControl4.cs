using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace HMS
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();

            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();

            OracleCommand ccd = new OracleCommand();
            ccd.Connection = conn;
            ccd.CommandText = "select name, patient_id from patient_info where type = 'Indoor' and discharge_date is not null";
            DataTable dt1 = new DataTable();
            dt1.Load(ccd.ExecuteReader());

            ((ComboBox)comboBox1).DataSource = dt1;
            ((ComboBox)comboBox1).DisplayMember = "name";
            ((ComboBox)comboBox1).ValueMember = "patient_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";

            OracleConnection conn = new OracleConnection(oradb); // C#

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into patient_bill(patient_id, cabin_bill) values(:patient_id, :cabin_bill)";

                cmd.Parameters.Add(new OracleParameter(":patient_id", comboBox1.SelectedValue));
                cmd.Parameters.Add(new OracleParameter(":cabin_bill", textBox1.Text));
                //cmd.Parameters.Add(new OracleParameter(":cabin_bill", "(SELECT DATEDIFF(day,entry_date,discharge_date) from patient_info where discharge_date is not null)*"+textBox1.Text+""));

                int rowsUpdated = cmd.ExecuteNonQuery();

                if (rowsUpdated == 0)
                    MessageBox.Show("Record not inserted");
                else
                    MessageBox.Show("Successfully made!");
            }
            catch (Exception exception) { }
            finally
            {
                conn.Dispose();

                Refresh();
                Application.Restart();
            }
        }
    }
}

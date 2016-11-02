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
    public partial class UserControl11 : UserControl
    {
        public UserControl11()
        {
            InitializeComponent();

            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();

            OracleCommand ccd = new OracleCommand();
            ccd.Connection = conn;
            ccd.CommandText = "select name, patient_id from patient_info  where discharge_date is null";
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
                cmd.CommandText = "Update patient_info set discharge_date = :discharge_date where patient_id = :patient_id";
                cmd.Parameters.Add(new OracleParameter(":discharge_date", dateTimePicker1.Value));
                cmd.Parameters.Add(new OracleParameter(":patient_id", comboBox1.SelectedValue));                


                int rowsUpdated = cmd.ExecuteNonQuery();

                if (rowsUpdated == 0)
                    MessageBox.Show("Record not inserted");
                else
                    MessageBox.Show("Successfully discharged!");
            }
            catch (Exception exception) { }
            finally
            {
                conn.Dispose();
            }
        }
    }
}

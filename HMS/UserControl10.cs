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
    public partial class UserControl10 : UserControl
    {
        public UserControl10()
        {
            InitializeComponent();

            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();

            OracleCommand ccd = new OracleCommand();
            ccd.Connection = conn;
            ccd.CommandText = "select name, doc_id from doctor_info where resign_date is null";
            DataTable dt1 = new DataTable();
            dt1.Load(ccd.ExecuteReader());

            ((ComboBox)comboBox1).DataSource = dt1;
            ((ComboBox)comboBox1).DisplayMember = "name";
            ((ComboBox)comboBox1).ValueMember = "doc_id";
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
                cmd.CommandText = "Update doctor_info set resign_date = :resign_date where doc_id = :doc_id";
                cmd.Parameters.Add(new OracleParameter(":resign_date", dateTimePicker1.Value));
                cmd.Parameters.Add(new OracleParameter(":doc_id", comboBox1.SelectedValue));


                int rowsUpdated = cmd.ExecuteNonQuery();

                if (rowsUpdated == 0)
                    MessageBox.Show("Record not succeeded!");
                else
                    MessageBox.Show("Successfully Saved!");
            }
            catch (Exception exception) { }
            finally
            {
                conn.Dispose();
            }
        }
    }
}

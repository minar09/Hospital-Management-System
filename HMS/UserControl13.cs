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
    public partial class UserControl13 : UserControl
    {
        public UserControl13()
        {
            InitializeComponent();

            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();

            OracleCommand ccd = new OracleCommand();
            ccd.Connection = conn;
            ccd.CommandText = "select name, patient_id from patient_info";
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
                //MessageBox.Show("connected");

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                OracleParameter parm = new OracleParameter();
                parm.OracleDbType = OracleDbType.Decimal;
                parm.Value = comboBox1.SelectedValue;

                cmd.Parameters.Add(parm);
                cmd.CommandText = "select cabin_bill from patient_bill where patient_id = 93";
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add(new OracleParameter(":cabin_bill", "(SELECT DATEDIFF(day,entry_date,discharge_date) from patient_info where discharge_date is not null)*"+textBox1.Text+""));

                //int rowsUpdated = cmd.ExecuteNonQuery();
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string str = dr.GetString(0);
                    MessageBox.Show(str);
                }
                else
                    MessageBox.Show("Process unsuccessful");
            }
            catch (Exception exception) { }
            finally
            {
                conn.Dispose();
                //MessageBox.Show("connected");

                Refresh();
                //Application.Restart();
            }
        }
    }
}

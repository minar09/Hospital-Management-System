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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();

            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();

            OracleCommand ccd = new OracleCommand();
            ccd.Connection = conn;
            ccd.CommandText = "select cabin_id from cabin";
            DataTable dt1 = new DataTable();
            dt1.Load(ccd.ExecuteReader());

            ((ComboBox)comboBox1).DataSource = dt1;
            ((ComboBox)comboBox1).DisplayMember = "cabin_id";
            ((ComboBox)comboBox1).ValueMember = "cabin_id";


            OracleCommand cod = new OracleCommand();
            cod.Connection = conn;
            cod.CommandText = "select name, patient_id from patient_info  where discharge_date is null and type = 'Indoor'";
            DataTable dt2 = new DataTable();
            dt2.Load(cod.ExecuteReader());

            ((ComboBox)comboBox2).DataSource = dt2;
            ((ComboBox)comboBox2).DisplayMember = "name";
            ((ComboBox)comboBox2).ValueMember = "patient_id";

            conn.Close();
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
                cmd.CommandText = "Update cabin set patient_id = :patient_id where cabin_id = :cabin_id";

                cmd.Parameters.Add(new OracleParameter(":patient_id", comboBox2.SelectedValue));
                cmd.Parameters.Add(new OracleParameter(":cabin_id", comboBox1.SelectedValue));
                

                int rowsUpdated = cmd.ExecuteNonQuery();

                if (rowsUpdated == 0)
                    MessageBox.Show("Record not inserted");
                else
                    MessageBox.Show("Successfully allocated!");
            }
            catch (Exception exception) { }
            finally
            {
                conn.Dispose();
            }
        }
    }
}

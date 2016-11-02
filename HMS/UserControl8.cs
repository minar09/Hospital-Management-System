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
    public partial class UserControl8 : UserControl
    {
        OracleDataAdapter adapter;
        DataSet dt;
        int scoolval;

        public UserControl8()
        {
            InitializeComponent();

            scoolval = 0;
            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;"; 
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name, doc_id from doctor_info";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            ((ComboBox)comboBox1).DataSource = dt;
            ((ComboBox)comboBox1).DisplayMember = "Name";
            ((ComboBox)comboBox1).ValueMember = "doc_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#

            string sql = "select doc_id, patient_id, visit_date, time from doc_visit where doc_id = "+comboBox1.SelectedValue+"";
            /*OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select doc_id, patient_id, visit_date, time from doc_visit where doc_id = :doc_id";
            cmd.Parameters.Add(new OracleParameter(":doc_id", comboBox1.SelectedValue));*/

            adapter = new OracleDataAdapter(sql, oradb);
            conn.Open();
            dt = new DataSet();
            adapter.Fill(dt, 0, 0, "doc_visit");
            conn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = "doc_visit";
        }
    }
}

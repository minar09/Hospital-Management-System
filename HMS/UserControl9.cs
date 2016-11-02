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
    public partial class UserControl9 : UserControl
    {

        OracleDataAdapter adapter;
        DataSet dt;
        int scoolval;

        public UserControl9()
        {
            InitializeComponent();

            scoolval = 0;
            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name, patient_id from patient_info";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            ((ComboBox)comboBox1).DataSource = dt;
            ((ComboBox)comboBox1).DisplayMember = "Name";
            ((ComboBox)comboBox1).ValueMember = "patient_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#

            string sql = "select cabin.cabin_id, doctor_info.name as Doctor, doc_visit.visit_date, doc_visit.time from doc_visit,cabin, doctor_info where doc_visit.patient_id = " + comboBox1.SelectedValue + " and doc_visit.patient_id = cabin.patient_id and doc_visit.doc_id = doctor_info.doc_id";
            string sql1 = "select doctor_info.name as Doctor, doc_visit.visit_date, doc_visit.time from doc_visit, doctor_info where doc_visit.patient_id = " + comboBox1.SelectedValue + " and doc_visit.doc_id = doctor_info.doc_id";
            /*OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select doc_id, patient_id, visit_date, time from doc_visit where doc_id = :doc_id";
            cmd.Parameters.Add(new OracleParameter(":doc_id", comboBox1.SelectedValue));*/

            //if(comboBox1)
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

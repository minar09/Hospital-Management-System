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
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();

            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();

            OracleCommand ccd = new OracleCommand();
            ccd.Connection = conn;
            ccd.CommandText = "select theatre_id from ot_name";
            DataTable dt1 = new DataTable();
            dt1.Load(ccd.ExecuteReader());

            ((ComboBox)comboBox1).DataSource = dt1;
            ((ComboBox)comboBox1).DisplayMember = "theatre_id";
            ((ComboBox)comboBox1).ValueMember = "theatre_id";


            OracleCommand cod = new OracleCommand();           
            cod.Connection = conn;
            cod.CommandText = "select name, patient_id from patient_info where discharge_date is null";            
            DataTable dt2 = new DataTable();
            dt2.Load(cod.ExecuteReader());

            ((ComboBox)comboBox2).DataSource = dt2;
            ((ComboBox)comboBox2).DisplayMember = "name";
            ((ComboBox)comboBox2).ValueMember = "patient_id";


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name, doc_id from doctor_info where resign_date is null";
            DataTable dt3 = new DataTable();
            dt3.Load(cmd.ExecuteReader());

            ((ComboBox)comboBox3).DataSource = dt3;
            ((ComboBox)comboBox3).DisplayMember = "name";
            ((ComboBox)comboBox3).ValueMember = "doc_id";
                                  

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
                cmd.CommandText = "Insert into OT(OP_id, OT_date, doc_id, patient_id, OT_time, theatre_id) VALUES(:OP_id, :OT_date, :doc_id, :patient_id, :OT_time, :theatre_id)";
                                               
                cmd.Parameters.Add(new OracleParameter(":OP_id", textBox1.Text));
                cmd.Parameters.Add(new OracleParameter(":OT_date", dateTimePicker2.Value));
                cmd.Parameters.Add(new OracleParameter(":doc_id", comboBox3.SelectedValue));
                cmd.Parameters.Add(new OracleParameter(":patient_id", comboBox2.SelectedValue));
                cmd.Parameters.Add(new OracleParameter(":OT_time", dateTimePicker1.Text));
                cmd.Parameters.Add(new OracleParameter(":theatre_id", comboBox1.SelectedValue));
                /*OracleParameter parm = new OracleParameter();
                parm.OracleDbType = OracleDbType.Decimal;
                parm.Value = checkedListBox1.Text;                
                OracleCommand cmdd = new OracleCommand();
                cmdd.Connection = conn;
                cmdd.Parameters.Add(parm);
                cmdd.CommandText = "Select doc_id from doctor_info where name = ':name' ";               
                cmdd.CommandType = CommandType.Text;
                OracleDataReader dr = cmdd.ExecuteReader();*/
                ///    cmd.Parameters.Add(new OracleParameter(":doc_id", checkedListBox1.SelectedValue));*/
                OracleCommand ccd = new OracleCommand();
                ccd.Connection = conn;
                ccd.CommandText = "Insert into patient_bill(patient_id, OT_bill) VALUES(:patient_id, :OT_bill)";

                ccd.Parameters.Add(new OracleParameter(":patient_id", comboBox2.SelectedValue));
                ccd.Parameters.Add(new OracleParameter(":OT_bill", textBox2.Text));

                             
                int rowsUpdated = cmd.ExecuteNonQuery();
                ccd.ExecuteNonQuery();

                if (rowsUpdated == 0)
                    MessageBox.Show("Record not inserted");
                else
                    MessageBox.Show("Successfully scheduled!");
            }
            catch (Exception exception) { }
            finally
            {
                conn.Dispose();
            }
        }

    }
}

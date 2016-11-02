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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();

            //var items = checkedListBox1.Items;
            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name, doc_id from doctor_info where resign_date is null";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            //conn.Close();

            OracleCommand ccd = new OracleCommand();
            ccd.Connection = conn;
            ccd.CommandText = "select name, patient_id from patient_info where discharge_date is null ";
            DataTable dt1 = new DataTable();
            dt1.Load(ccd.ExecuteReader());
            

            //checkedListBox1.DataBindings = dt.DataSet;
            ((ComboBox)comboBox1).DataSource = dt1;
            ((ComboBox)comboBox1).DisplayMember = "Name";
            ((ComboBox)comboBox1).ValueMember = "patient_id";
            //checkedListBox1.Show();

            ((ComboBox)comboBox2).DataSource = dt;
            ((ComboBox)comboBox2).DisplayMember = "name";
            ((ComboBox)comboBox2).ValueMember = "doc_id";

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
                cmd.CommandText = "Insert into doc_visit(id, patient_id, doc_id, visit_date, time) VALUES(:id, :patient_id, :doc_id, :visit_date, :time)";
                cmd.Parameters.Add(new OracleParameter(":id", textBox1.Text));
                cmd.Parameters.Add(new OracleParameter(":patient_id", comboBox1.SelectedValue));

                OracleCommand ccd = new OracleCommand();
                ccd.Connection = conn;
                ccd.CommandText = "Insert into patient_bill(patient_id, doctor_fee) VALUES(:patient_id, :doctor_fee)";               
                ccd.Parameters.Add(new OracleParameter(":patient_id", comboBox1.SelectedValue));
                ccd.Parameters.Add(new OracleParameter(":doctor_fee", textBox2.Text));

                /*OracleParameter parm = new OracleParameter();
                parm.OracleDbType = OracleDbType.Decimal;
                parm.Value = checkedListBox1.Text;                
                OracleCommand cmdd = new OracleCommand();
                cmdd.Connection = conn;
                cmdd.Parameters.Add(parm);
                cmdd.CommandText = "Select doc_id from doctor_info where name = ':name' ";               
                cmdd.CommandType = CommandType.Text;
                OracleDataReader dr = cmdd.ExecuteReader();*/
                cmd.Parameters.Add(new OracleParameter(":doc_id", comboBox2.SelectedValue));

                cmd.Parameters.Add(new OracleParameter(":visit_date", dateTimePicker1.Value));
                cmd.Parameters.Add(new OracleParameter(":time", dateTimePicker2.Text));               

                int rowsUpdated = cmd.ExecuteNonQuery();
                ccd.ExecuteNonQuery();

                if (rowsUpdated == 0)
                    MessageBox.Show("Record not inserted");
                else
                    MessageBox.Show("Successfully Assigned!");
            }
            catch (Exception exception) { }
            finally
            {
                conn.Dispose();
            }
        }
    }
}

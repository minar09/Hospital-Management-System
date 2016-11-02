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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
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
                cmd.CommandText = "Insert into Doctor_info(doc_id, name,date_of_birth, gender,address,contact, join_date, category) VALUES(:doc_id,:name,:date_of_birth,:gender,:address,:contact, :join_date, :category)";
                cmd.Parameters.Add(new OracleParameter(":doc_id", textBox1.Text));
                cmd.Parameters.Add(new OracleParameter(":name", textBox2.Text));
                cmd.Parameters.Add(new OracleParameter(":date_of_birth", dateTimePicker1.Value));
                if (radioButton1.Checked)
                    cmd.Parameters.Add(new OracleParameter(":gender", radioButton1.Text));
                else if (radioButton2.Checked)
                    cmd.Parameters.Add(new OracleParameter(":gender", radioButton2.Text));

                cmd.Parameters.Add(new OracleParameter(":address", textBox3.Text));
                cmd.Parameters.Add(new OracleParameter(":contact", textBox4.Text));
                cmd.Parameters.Add(new OracleParameter(":join_date", dateTimePicker2.Value));
                cmd.Parameters.Add(new OracleParameter(":category", textBox5.Text));

                int rowsUpdated = cmd.ExecuteNonQuery();

                if (rowsUpdated == 0)
                    MessageBox.Show("Record not inserted");
                else
                    MessageBox.Show("Successfully Added!");

            }
            catch (Exception exception) { }
            finally
            {
                conn.Dispose();
            }
           
        }
    }
}

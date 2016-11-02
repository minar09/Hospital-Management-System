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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=ORCL;User Id=gaara;Password=123456;";
 
            OracleConnection conn = new OracleConnection(oradb); // C#

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into Patient_info(patient_id, name, age, gender, address, contact, type, entry_date) VALUES(:patient_id, :name, :age, :gender, :address, :contact, :type, :entry_date)";
                cmd.Parameters.Add(new OracleParameter(":patient_id", textBox7.Text));
                cmd.Parameters.Add(new OracleParameter(":name", textBox1.Text));
                cmd.Parameters.Add(new OracleParameter(":age", textBox2.Text));
                
                if(radioButton1.Checked)
                    cmd.Parameters.Add(new OracleParameter(":gender", radioButton1.Text));
                else if(radioButton2.Checked)
                    cmd.Parameters.Add(new OracleParameter(":gender", radioButton2.Text));

                cmd.Parameters.Add(new OracleParameter(":address", textBox4.Text));
                cmd.Parameters.Add(new OracleParameter(":contact", textBox5.Text));
                if (radioButton3.Checked)
                    cmd.Parameters.Add(new OracleParameter(":type", radioButton3.Text));
                else if (radioButton4.Checked)
                    cmd.Parameters.Add(new OracleParameter(":type", radioButton4.Text));
                else if(radioButton5.Checked)
                    cmd.Parameters.Add(new OracleParameter(":type", radioButton5.Text));
                cmd.Parameters.Add(new OracleParameter(":entry_date", dateTimePicker1.Value));

                int rowsUpdated = cmd.ExecuteNonQuery();

                if (rowsUpdated == 0)
                    MessageBox.Show("Record not inserted");
                else
                    MessageBox.Show("Successfully Registered!");
            }
            catch (Exception exception) { }
            finally
            {
                conn.Dispose();
                UserControl2 panel = new UserControl2();
                //Application.Restart();
                
            }
           

        }
    }
}

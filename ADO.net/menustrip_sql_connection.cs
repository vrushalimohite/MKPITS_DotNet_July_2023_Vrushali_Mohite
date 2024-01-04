using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace menustrip_login_form_sql_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String str = "server=.\\SQLEXPRESS01;integrated security=true;database=mdi_login_sql";
        SqlConnection con = null;
        SqlCommand cmd = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            con = new SqlConnection(str);
            string strn = "select count (*) from users where username=@username and password=@password";
            cmd = new SqlCommand(strn, con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            if (cnt > 0)
            {
                label3.Text = "Login successfully";
                    Form2 f = new Form2();
                    f.Show();

                    this.Hide();
            }
            else
            {
                label3.Text = "Invalid input,TRY AGAIN";
            }
        }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}

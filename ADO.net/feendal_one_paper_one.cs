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

namespace feendal_project
{
    public partial class Form1 : Form
    {
        string str = "server=.\\SQLEXPRESS01;integrated security=true;database=feendal_1";
        SqlConnection con;
        SqlDataAdapter ad;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                ad = new SqlDataAdapter("select * from TableNation1 order by NationID", con);
                ds = new DataSet();
                ad.Fill(ds, "dt");
                comboBox1.DataSource = ds.Tables["dt"];
                comboBox1.DisplayMember = "NationName";
                comboBox1.ValueMember = "NationID";
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString()!="System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(str);
                    ad = new SqlDataAdapter("select * from TableState where NationID=@NationId", con);
                    ad.SelectCommand.Parameters.AddWithValue("NationID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ad.Fill(ds, "ts");
                    comboBox2.DataSource = ds.Tables["ts"];
                    comboBox2.DisplayMember = "StateName";
                    comboBox2.ValueMember = "StateID";
                }
                catch(Exception ee )
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(str);
                    ad = new SqlDataAdapter("select * from TableCity where StateID=@StateID", con);
                    ad.SelectCommand.Parameters.AddWithValue("@StateID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ad.Fill(ds, "tc");
                    comboBox3.DataSource = ds.Tables["tc"];
                    comboBox3.DisplayMember = "CityName";
                    comboBox3.ValueMember = "CityID";
                       
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public enum category { Students,IT_Professional}
        public enum gender { male,female,other}

        category cat;
        gender ge;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selecteddate = dateTimePicker1.Value;
            if(selecteddate.Date<DateTime.Today)
            {
                MessageBox.Show("please selected date after todays date");
            }
            if (textBox1.Text == " ")
            {
                MessageBox.Show("please Insert your Name");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    cat = category.Students;
                }
                else if (radioButton2.Checked)
                {
                    cat = category.IT_Professional;
                }
                MessageBox.Show("category :" + cat);


                if (radioButton3.Checked)
                {
                    ge = gender.male;
                }
                else if (radioButton4.Checked)
                {
                    ge = gender.female;
                }
                else if (radioButton5.Checked)
                {
                    ge = gender.other;
                }
                MessageBox.Show("Gender :" + ge);
                sdr(cat, ge);
            }

        }

        public void sdr(category c,gender g)
        {
            try
            {
                string strr = "insert into TableCourseRegDetail Values(@Categorylnd,@FullName,@Genderlnd)";
                SqlCommand cmd = new SqlCommand(strr, con);
                cmd.Parameters.AddWithValue("@Categorylnd", Convert.ToInt32(c));
                cmd.Parameters.AddWithValue("@FullName", textBox1.Text);
                cmd.Parameters.AddWithValue("@Genderlnd", Convert.ToInt32(g));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ra()
        {

        }
    }
}

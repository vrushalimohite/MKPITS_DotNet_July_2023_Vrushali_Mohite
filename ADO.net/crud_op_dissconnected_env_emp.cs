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

namespace crud_operation_disconnected_env_employee
{
    public partial class Form1 : Form
    {
        public string ConnectionString { get; set; } = @"data source=.\SQLEXPRESS01;integrated security=true;database=crud_op_dis_env_emp";
        SqlDataAdapter sqlda;
        DataSet ds;
        SqlCommandBuilder sqlcb;
        public Form1()
        {
            InitializeComponent();
            sqlda = new SqlDataAdapter("select * from employee", ConnectionString);
            sqlcb = new SqlCommandBuilder(sqlda);
            ds = new DataSet();
            sqlda.Fill(ds,"emp");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ds.Tables["emp"];
            comboBox1.DisplayMember = "emp_id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["emp"].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = Convert.ToInt32(textBox4.Text);
            dr[4] = textBox5.Text;
            dr[5] = Convert.ToInt32(textBox6.Text);

            ds.Tables["emp"].Rows.Add(dr);
            sqlda.Update(ds.Tables["emp"]);
            MessageBox.Show("data successfully inserted");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["emp"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in ds.Tables["emp"].Rows)
            {
                if (dr[0].ToString()==textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt32(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = Convert.ToInt32(textBox6.Text);
                        sqlda.Update(ds.Tables["emp"]);
                        MessageBox.Show("data successfully inserted");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in ds.Tables["emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        ds.Tables["emp"].Rows.Remove(dr);
                        sqlda.Update(ds.Tables["emp"]);
                        MessageBox.Show("data successfully delete");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string empid = comboBox1.Text;
            MessageBox.Show(empid);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
        }
    }
}

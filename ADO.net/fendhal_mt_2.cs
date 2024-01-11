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


namespace fendahl_mt_product
{
    public partial class Form1 : Form


    {
         enum category {INDIAN,NRI }
        category Cat;

        string str = "server=.\\SQLEXPRESS01;integrated security=true;database=fendahl_2";
        SqlConnection con;
        SqlDataAdapter ad;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cat();
            pn();
            price();
        }

        public void cat()
        {


            con = new SqlConnection(str);
            ad = new SqlDataAdapter("select * from TableProductCategorys", con);
            ds = new DataSet();
            ad.Fill(ds, "c");
            comboBox1.DataSource = ds.Tables["c"];
            comboBox1.DisplayMember = "product_Type_Name";
            comboBox1.ValueMember = "Product_Category_ID";
        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pn();
            if(comboBox1.Text!="System.Data.DataRowView")
            {
               string cname = comboBox1.Text;

                con = new SqlConnection(str);
                ad = new SqlDataAdapter("select * from TableProductGSTDetails Where GST_Detail_Name=@pn", con);
                ad.SelectCommand.Parameters.AddWithValue("@pn", cname);
                ds = new DataSet();
                ad.Fill(ds, "igst");
                foreach (DataRow dr in ds.Tables["igst"].Rows) 
                {
                    textBox3.Text = dr["CGST"].ToString();
                    textBox4.Text = dr["SGST"].ToString();
                    textBox5.Text = dr["IGST"].ToString();


                }
            }
            
        }
        public void pn()
        {

            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                con = new SqlConnection(str);
                ad = new SqlDataAdapter("select * from TableProduct where Product_Category_ID=@pid", con);
                ad.SelectCommand.Parameters.AddWithValue("@pid", comboBox1.SelectedValue);

                ds = new DataSet();
                ad.Fill(ds, "pid");
                comboBox2.DataSource = ds.Tables["pid"];
                comboBox2.DisplayMember = "Product_Name";
                comboBox2.ValueMember = "productID";
            }


        }







        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox7.Text = "0";
            textBox8.Text = "0";
            price();
           
        }
        public void price()
        {
            try
            {
                if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
                {

                    con = new SqlConnection(str);
                    ad = new SqlDataAdapter("select * from TableProduct where productID =@pi ", con);
                    ds = new DataSet();
                    ad.SelectCommand.Parameters.AddWithValue("@pi", comboBox2.SelectedValue);
                    ad.Fill(ds, "tp");
                    foreach (DataRow dr in ds.Tables["tp"].Rows)
                    {
                        textBox6.Text = dr["price"].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("enter only numbers");
            }
        }

        

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (textBox7.Text != "")
            {
                double price = Convert.ToDouble(textBox6.Text);
                double qun = Convert.ToDouble(textBox7.Text);
                double tamt = price * qun;
                textBox8.Text = tamt.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Cat = category.INDIAN;

                double tamt = Convert.ToDouble(textBox8.Text);
                double c = Convert.ToDouble(textBox3.Text) / 100 * tamt;
                textBox10.Text = c.ToString();
                double s = Convert.ToDouble(textBox4.Text) / 100 * tamt;
                textBox11.Text = s.ToString();
                double indian = c + s + tamt;
                if (radioButton1.Text == "INDIAN")
                {
                    textBox9.Text = indian.ToString();
                }
               
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                Cat = category.NRI;
                double tamt = Convert.ToDouble(textBox8.Text);

                double i = Convert.ToDouble(textBox5.Text) / 100 * tamt;
                textBox12.Text = i.ToString();
                double nri = i + tamt;
                if (radioButton2.Text == "NRI")
                {
                    textBox9.Text = nri.ToString();
                }

            }
        }
        
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            double tamt = Convert.ToDouble(textBox8.Text);
            double c = Convert.ToDouble(textBox3.Text) / 100 * tamt;
            textBox10.Text = c.ToString();
            double s = Convert.ToDouble(textBox4.Text) / 100 * tamt;
            textBox11.Text = s.ToString();
            double i = Convert.ToDouble(textBox5.Text) / 100 * tamt;
            textBox12.Text = i.ToString();





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
    }

        

















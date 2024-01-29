using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace permanent_client_side_sm_cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
                

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c1 = new HttpCookie("cook");
            c1.Values.Add("username", TextBox1.Text);
            Response.Cookies.Add(c1);
            Label2.Text = "TEMPRVARY COOKIE";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie c3 = new HttpCookie("cook");
            c3.Values.Add("username", TextBox1.Text);
            DateTime dt= DateTime.Now;
            TimeSpan ds = new TimeSpan(0, 2, 0);
            c3.Expires = dt.Add(ds);
            Label2.Text = "perment cookie add with client server";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpCookie c4 = Request.Cookies["cook"];
            if(c4!=null)
            {
                string str = c4.Values["username"].ToString();
                Label2.Text = "username :" + str;
            }
            else
            {
                Label2.Text = "no permewnt cookie exit";
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            HttpCookie c1 = Request.Cookies["cook"];
            if (c1 != null)
            {
                string str = c1.Values["username"].ToString();
                Label2.Text = "username :" + str;
            }
            else
            {
                Label2.Text = "no Cookie exit";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clent_side_state_mangement_temp_cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c1 = new HttpCookie("cook");
            c1.Values.Add("username", TextBox1.Text);
            Response.Cookies.Add(c1);
            Label2.Text = "temporary cookie are store with client manchine";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie c2 = Request.Cookies["cook"];
            if (c2 != null)
            {
                string str = c2.Values["username"].ToString();
                Label2.Text = "Username :" + str;
            }
            else
            {
                Label2.Text = "No cookie exit";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace area_circumference_circle.Properties
{
    public partial class area_circ_circle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(TextBox1.Text);
            float area = 2 * 3.14f * r * r;
            float circ= 2 * 3.14f * r;
            Label1.Text = area.ToString();
            Label2.Text = circ.ToString();
        }
    }
}
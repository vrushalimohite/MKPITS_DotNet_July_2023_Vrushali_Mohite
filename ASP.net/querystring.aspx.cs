﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace querystring
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["username"].ToString();
            Label1.Text= username;
            string pass = Request.QueryString["pass"].ToString();
            Label2.Text = pass; 
            string mono = Request.QueryString["mono"].ToString();
            Label3.Text = mono;


        }
    }
}
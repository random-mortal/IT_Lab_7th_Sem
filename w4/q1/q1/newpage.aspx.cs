﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q1
{
    public partial class newpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += " " + Request.QueryString["manufacturer"];
            Label2.Text += " " + Request.QueryString["model"];
        }
    }
}
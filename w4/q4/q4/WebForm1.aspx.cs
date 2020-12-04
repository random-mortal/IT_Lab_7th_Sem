using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Session["login_count"] = 0;
                Application["fail_count"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            if (username.Equals("pranav") && password.Equals("12345"))
            {
                int login_count = (int)Session["login_count"];
                login_count++;
                Session["login_count"] = login_count;
                Label2.Text = "Login count:" + login_count.ToString();
                Application["fail_count"] = 0;
            }
            else
            {
                Label2.Text = "Wrong credentials";
                int fail_count = (int)Application["fail_count"];
                fail_count++;
                Application["fail_count"] = fail_count;
                if (fail_count == 3)
                {
                    TextBox1.Enabled = false;
                    TextBox2.Enabled = false;
                }
            }
        }
    }
}
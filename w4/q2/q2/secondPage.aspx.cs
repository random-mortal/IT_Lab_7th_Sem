using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q2
{
    public partial class secondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Label2.Text = "0";
                HttpCookie cookie = new HttpCookie("counter");
                cookie["Counter"] = "0";
                Response.Cookies.Add(cookie);
            }
            string name = (string)Session["name"];
            string rollno = (string)Session["rollno"];
            string subject = (string)Session["subject"];
            Label1.Text = "name:" + name + " rollno:" + rollno + " subject:" + subject;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["counter"];
            if (cookie != null)
            {
                int val = Int32.Parse(cookie["Counter"]);
                val++;
                Label2.Text = val.ToString();
                cookie["Counter"] = val.ToString();
                Response.Cookies.Add(cookie);
            }
        }
    }
}
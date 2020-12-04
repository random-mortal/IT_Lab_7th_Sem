using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace q3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Label3.Text = "New user detected";
            }
            HttpCookie cookie = Request.Cookies["Preferences"];
            if (cookie != null)
            {
                string name = cookie["name"];
                
            string cart = cookie["cart"];
                Label3.Text = "Welcome " + name;
                TextBox2.Text = cart;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Preferences");
            cookie["name"] = TextBox1.Text;
            cookie["cart"] = TextBox2.Text;
            cookie.Expires = DateTime.Now.AddMinutes(2);
            Response.Cookies.Add(cookie);
        }
    }
}
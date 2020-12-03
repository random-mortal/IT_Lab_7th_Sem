using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace q4
{
    public partial class Captcha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }
        protected void submit_Click(object sender, EventArgs e)
        {
            if (String.Equals(input.Text, "qGphJD"))
            {
                output.Text = "Success!";
            }
            else
            {
                int counter;
                if (ViewState["count"] == null)
                {
                    counter = 2;
                }
                else
                {
                    counter = (int)ViewState["count"] - 1;
                    if (counter == 0)
                    {
                        input.Enabled = false;
                    }
                }
                ViewState["count"] = counter;
                if (counter >= 0) output.Text = "You have " + counter + " trials left";
                else output.Text = "You have 0 trials left.";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Offers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
        {
           Image1.ImageUrl = "Images/offer1.jpg";
           Image2.ImageUrl = "Images/offer2.jpg";
        }
    }
}
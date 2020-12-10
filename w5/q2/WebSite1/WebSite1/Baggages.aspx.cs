using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Baggages : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
        {
            Image1.ImageUrl = "Images/laptop_bag.jpg";
            Image2.ImageUrl = "Images/trolley_bag.jpg";
            Image3.ImageUrl = "Images/backpack.jpg";
        }
    }
}
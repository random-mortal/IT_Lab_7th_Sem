using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;

using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
        {
            string file = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Cars.xml");

            XDocument doc = new XDocument(
                new XDeclaration("1.0", null, "yes"),
                new XElement("Cars",
                new XElement("Detail", new XElement("Name", "I20"), new XElement("Make", "Hyundai"), new XElement("Price", "700000")),
                new XElement("Detail", new XElement("Name", "I10"), new XElement("Make", "Hyundai"), new XElement("Price", "600000"))));

            doc.Save(file);
        }
    }
}
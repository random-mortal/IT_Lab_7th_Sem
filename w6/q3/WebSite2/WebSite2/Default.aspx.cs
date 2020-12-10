using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int price = Int32.Parse(TextBox1.Text);

        string connection_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Products;Integrated Security=True;Pooling=False";

        string query = "UPDATE Items SET price=@price WHERE flavour='vanilla'";

        SqlConnection con = new SqlConnection(connection_string);

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@price", price);

        try
        {
            con.Open();

            cmd.ExecuteNonQuery();
        }
        catch(Exception err)
        {
            
        }
        finally
        {
            con.Close();
        }


    }
}
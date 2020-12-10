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
        if(!this.IsPostBack)
        {
            ListBox1.Items.Add("Mumbai");
            ListBox1.Items.Add("Pune");
            ListBox1.Items.Add("Chennai");

            FillID();
        }

        
        
    }

    private void FillID()
    {
        string connection_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=HousingStaff;Integrated Security=True;Pooling=False";

        string select = "SELECT StaffID from Staff";

        SqlConnection con = new SqlConnection(connection_string);

        SqlCommand cmd = new SqlCommand(select, con);

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();

        try
        {
            con.Open();

            adapter.Fill(ds, "Staff");
        }
        catch(Exception err)
        {

        }
        finally
        {
            con.Close();
        }
        foreach(DataRow row in ds.Tables["Staff"].Rows)
        {
            DropDownList1.Items.Add(row["StaffID"].ToString());
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = Int32.Parse(DropDownList1.SelectedValue);

        string connection_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=HousingStaff;Integrated Security=True;Pooling=False";

        string select = "SELECT FirstName,LastName,DNo,Street,City,State,ZipCode FROM Staff where StaffID="+id;

        SqlConnection con = new SqlConnection(connection_string);

        SqlCommand cmd = new SqlCommand(select, con);

        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();

        try
        {
            con.Open();

            adapter.Fill(ds, "Staff");
        }
        catch (Exception err)
        {

        }
        finally
        {
            con.Close();
        }

        DataRow row  = ds.Tables["Staff"].Rows[0];

        string f_name = (string)row["FirstName"];
        string l_name = (string)row["LastName"];
        int d_no = (int)row["DNo"];
        string street = (string)row["Street"];
        string city = (string)row["City"];
        string state = (string)row["State"];
        decimal zip = (decimal)row["ZipCode"];

        Label2.Text += f_name + " " + l_name + " " + d_no.ToString() + " " + street + " " + city + " " + state + " " + zip.ToString();


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = Int32.Parse(DropDownList1.SelectedValue);

        string city = ListBox1.SelectedValue;

        string connection_string = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=HousingStaff;Integrated Security=True;Pooling=False";

        string update = "UPDATE Staff SET City=@city" + " WHERE StaffID=@id" ;

        SqlConnection con = new SqlConnection(connection_string);

        SqlCommand cmd = new SqlCommand(update, con);

        cmd.Parameters.AddWithValue("@city", city);
        cmd.Parameters.AddWithValue("@id", id);
        int updated = 0;
        try
        {
            con.Open();

            updated = cmd.ExecuteNonQuery();
        }
        catch(Exception err)
        {

        }
        finally
        {
            con.Close();
        }
        if(updated>0)
        {
            Label3.Text = "Record has been updated";
        }
        else
        {
            Label3.Text = "Problem in performing update";
        }
    }
}
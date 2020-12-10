<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 519px">
        &nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Categories:"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
            </asp:DropDownList>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Actors:"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" AutoPostBack="true"></asp:ListBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Actor details:"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2">
            </asp:GridView>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=test;Integrated Security=True;Pooling=False" SelectCommand="SELECT name FROM [Table] WHERE category=@category">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="category" PropertyName="SelectedValue"/>
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=test;Integrated Security=True;Pooling=False" SelectCommand="SELECT name,age FROM [Table] WHERE name=@name">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ListBox1" Name="name" PropertyName="SelectedValue"/>
                </SelectParameters>
            </asp:SqlDataSource>

&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>

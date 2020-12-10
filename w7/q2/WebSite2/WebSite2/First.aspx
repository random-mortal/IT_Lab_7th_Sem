<%@ Page Language="C#" AutoEventWireup="true" CodeFile="First.aspx.cs" Inherits="First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 239px">
        &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Travel packages:"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="place" AutoPostBack="true"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=Tour;Integrated Security=True;Pooling=False" SelectCommand="SELECT Place FROM Travel" ></asp:SqlDataSource>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Details" />
        </div>
    </form>
</body>
</html>

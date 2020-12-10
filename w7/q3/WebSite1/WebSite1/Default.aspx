<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 304px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="States:"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
            </asp:DropDownList>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Cities:"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="CityName">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=cityDB;Integrated Security=True;Pooling=False" SelectCommand="SELECT CityName FROM City WHERE StateID=@StateID">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="StateID" PropertyName="SelectedValue"/>
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Second.aspx.cs" Inherits="Second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 238px">
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\mssqllocaldb;Initial Catalog=Tour;Integrated Security=True;Pooling=False" SelectCommand="SELECT * FROM Travel WHERE Place=@place">
                <SelectParameters>
                    <asp:QueryStringParameter Name="place" QueryStringField="place"/>
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>

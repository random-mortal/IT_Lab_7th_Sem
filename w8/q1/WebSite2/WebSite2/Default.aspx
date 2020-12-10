    <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 202px">
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="false" AllowSorting="true" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:TemplateField HeaderText="Details" SortExpression="name">
                        <ItemTemplate>
                            <b>Name:</b>
                            <%# Eval("name") %>
                            <br />
                            <b>Age:</b>
                            <%# Eval("age") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="designation" HeaderText="Designation"/>
                    <asp:BoundField DataField="salary" HeaderText="Salary"/>
                </Columns>
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sure;Integrated Security=SSPI" SelectCommand="SELECT name,age,designation,salary FROM Staff"></asp:SqlDataSource>
    </form>
</body>
</html>

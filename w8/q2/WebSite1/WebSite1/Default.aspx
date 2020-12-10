<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 325px">
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="false" AllowPaging="true" PageSize="3" DataKeyNames="id">
                <HeaderStyle BackColor="Green" ForeColor="Red" Font-Bold="true"/>
                <Columns>
                    <asp:CommandField ShowEditButton="true"/>
                    <asp:BoundField DataField="id" HeaderText="Id" ReadOnly="true"/>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <b>First Name:</b>
                            <%# Eval("first_name") %>
                            <br />
                            <b>Last Name:</b>
                            <%# Eval("last_name") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <b>First Name:</b>
                            <asp:TextBox runat="server" ID="TextBox1" Text='<%# Bind("first_name") %>'></asp:TextBox>
                            <br />
                            <b>Last Name:</b>
                            <%# Eval("last_name") %>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="book_title" HeaderText="Book Title" ReadOnly="true"/>
                    <asp:BoundField DataField="genre" HeaderText="Genre" ReadOnly="true"/>
                    <asp:BoundField DataField="copies_sold" HeaderText="Copies Sold"/>
                </Columns>
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=SSPI" SelectCommand="SELECT * FROM Authors" UpdateCommand="UPDATE Authors SET copies_sold=@copies_sold,first_name=@first_name WHERE id=@id">

        </asp:SqlDataSource>
    </form>
</body>
</html>

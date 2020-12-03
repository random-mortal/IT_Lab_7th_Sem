<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs"
   Inherits="Lab3q2.Employee" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title></title>
   </head>
   <body>
      <form id="form1" runat="server">
         <div>
            Choose Employee:
            <asp:DropDownList ID="employeeList" runat="server" OnSelectedIndexChanged="empChanged" AutoPostBack="true"></asp:DropDownList>
            <br /><br />
            <asp:Image ID="empImage" ImageUrl="1.png" runat="server" />
            <br /><br />
            Name of the employee:
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br /><br />
            Date of joining:
            <asp:TextBox ID="doj" TextMode="Date" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="promotion" runat="server" Text="Am I Eligible for
               promotion?" OnClick="promotion_Click" />
            <br /><br />
            <asp:Label ID="output" runat="server" Text=""></asp:Label>
         </div>
      </form>
   </body>
</html>
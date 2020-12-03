<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q4.Captcha" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Image ID="captcha" ImageUrl="~/captcha.png" runat="server" />
                <br />
                <br />
                <asp:TextBox ID="input" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
                <br />
                <br />
                <asp:Label
                    ID="output"
                    runat="server"
                    Text="You have 3 trials left"
                ></asp:Label>
            </div>
        </form>
    </body>
</html>

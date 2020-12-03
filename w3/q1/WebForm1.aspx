<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="WebForm1.aspx.cs"
    Inherits="q1.WebForm1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <div style="BORDER-RIGHT: thin ridge; 
                    PADDING-RIGHT: 20px; 
                    BORDER-TOP: thin ridge;
                    PADDING-LEFT: 20px;
                    FONT-SIZE: x-small; 
                    PADDING-BOTTOM: 20px; 
                    BORDER-LEFT: thin ridge; 
                    WIDTH: 293px;
                    PADDING-TOP: 20px;
                    BORDER-BOTTOM: thin ridge; 
                    FONT-FAMILY: Verdana; 
                    HEIGHT: 486px; BACKGROUND-COLOR: lightblue">

                    Choose a background color:
                    
                    <br /><br />

                    <asp:DropDownList ID="backList" runat="server">
                    </asp:DropDownList>

                    <br /> <br />

                    Select Image:

                    <asp:DropDownList ID="imageList" runat="server">
                    </asp:DropDownList>

                    <br /><br />

                    Enter Heading Font size:

                    <asp:TextBox ID="headingSize" runat="server"></asp:TextBox>

                    <br /><br />

                    Enter Heading Font Family:

                    <asp:DropDownList ID="headingFamily"
                        runat="server"></asp:DropDownList>

                    <br /><br />

                    Enter Heading Font Color:

                    <asp:TextBox ID="headingColor" runat="server"></asp:TextBox>

                    <br /><br />

                    Enter Heading Text:

                    <asp:TextBox ID="headingText" runat="server"></asp:TextBox>

                    <br /><br />

                    Enter Body Font size:

                    <asp:TextBox ID="bodySize" runat="server"></asp:TextBox>

                    <br /><br />

                    Enter Body Font Family:

                    <asp:DropDownList ID="bodyFamily" runat="server"></asp:DropDownList>

                    <br /><br />

                    Enter Body Font Color:

                    <asp:TextBox ID="bodyColor" runat="server"></asp:TextBox>

                    <br /><br />

                    Enter Body Text:

                    <asp:TextBox ID="bodyText" runat="server"></asp:TextBox>

                    <br /><br />

                    <asp:Button ID="update" runat="server" Text="Update"
                        OnClick="update_Click" />
                </div>

                <asp:panel ID="pnlMag" style="LEFT: 350px; POSITION: absolute; TOP:
                    16px" runat="server"
                    Height="507px" Width="339px" HorizontalAlign="Center" >
                    <br />&nbsp;
                    <asp:Label ID="heading" runat="server" Text=""></asp:Label>
                    <br /><br />
                    <asp:Image ID="dp" runat="server" ImageUrl="" ImageAlign="Middle" />
                    <br /><br /><br />
                    <asp:Label ID="body" runat="server" Text=""></asp:Label>
                </asp:panel>

            </div>
        </form>
    </body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs"
   Inherits="Lab3q3.Card" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title></title>
   </head>
   <body>
      <form id="form1" runat="server">
         <div>
            <div style="BORDER-RIGHT: thin ridge; PADDING-RIGHT: 20px; BORDER-TOP: thin ridge;
               PADDING-LEFT: 20px;
               FONT-SIZE: x-small; PADDING-BOTTOM: 20px; BORDER-LEFT: thin ridge; WIDTH: 293px;
               PADDING-TOP: 20px;
               BORDER-BOTTOM: thin ridge; FONT-FAMILY: Verdana; HEIGHT: 486px; BACKGROUND-
               COLOR: lightyellow">
               Choose background color
               <br />
               <asp:DropDownList ID="backColor" runat="server"></asp:DropDownList>
               <br /><br />
               Choose font family
               <br />
               <asp:DropDownList ID="fontFamily" runat="server"></asp:DropDownList>
               <br /><br />
               Enter font size
               <br />
               <asp:TextBox ID="fontSize" runat="server"></asp:TextBox>
               <br /><br />
               Enter input message
               <br />
               <asp:TextBox ID="message" runat="server"></asp:TextBox>
               <br /><br />
               Choose image
               <br />
               <asp:DropDownList ID="imageList" runat="server"></asp:DropDownList>
               <br /><br />
               <asp:Button ID="submit" runat="server" Text="Create"
                  OnClick="submit_Click" />
               <asp:Button ID="clear" runat="server" Text="Clear"
                  OnClick="clear_Click" />
            </div>
            <asp:panel ID="pnlCard" style="LEFT: 350px; POSITION: absolute; TOP: 16px"
               runat="server"
               Height="507px" Width="339px" HorizontalAlign="Center" >
               <br />&nbsp;
               <asp:Label ID="display" runat="server" Text=""></asp:Label>
               <br /><br />
               <asp:Image ID="dp" runat="server" ImageUrl="default.jpg"
                  ImageAlign="Middle" />
               <br /><br /><br />
            </asp:panel>
         </div>
      </form>
   </body>
</html>
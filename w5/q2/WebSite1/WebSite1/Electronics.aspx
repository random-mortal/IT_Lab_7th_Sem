<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Electronics.aspx.cs" Inherits="Electronics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Mobiles"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="Laptops"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
</p>
<p>
    <asp:Label ID="Label5" runat="server" Text="Printers"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList3" runat="server">
    </asp:DropDownList>
</p>
<p>
</p>
</asp:Content>


<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 562px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Choose Candidate"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please choose a candidate" ControlToValidate="DropDownList1" EnableClientScript="false" Display="None"></asp:RequiredFieldValidator>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Choose House"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please choose a house" ControlToValidate="RadioButtonList1" EnableClientScript="false" Display="None"></asp:RequiredFieldValidator>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            </asp:RadioButtonList>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Class"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator Display="None" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Class is required" ControlToValidate="TextBox1" EnableClientScript="false"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;
            <asp:RangeValidator Display="None" ID="RangeValidator1" runat="server" ErrorMessage="Value of class should be between 6 and 12" ControlToValidate="TextBox1" EnableClientScript="false" MinimumValue="6" MaximumValue="12" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator Display="None" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email is required" ControlToValidate="TextBox2" EnableClientScript="false"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator Display="None" ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email format is not valid" ControlToValidate="TextBox2" EnableClientScript="false" ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Parent Contact"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:CustomValidator Display="None" ID="CustomValidator1" runat="server" ErrorMessage="Number should be 10 digits long" OnServerValidate="CustomValidator1_ServerValidate" ControlToValidate="TextBox3" EnableClientScript="false"></asp:CustomValidator>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
        </div>
    </form>
</body>
</html>

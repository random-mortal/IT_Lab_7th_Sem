<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="q3.aspx.cs" Inherits="sample.std_reg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <section id ="main-content">
        <section id ="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <div class="col-md-4 col-md-offset-4">
                                <h1>Student Registration</h1>
                            </div>
                        </header>

                        <div class="panel-body">

                            

                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label ID="Label1" runat="server" Text="Student's Name"></asp:Label>
                                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control input-sm" placeholder="ABC"></asp:TextBox>
                                        
                                    </div>
                                </div>

                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label ID="Label2" runat="server" Text="Father's Name"></asp:Label>
                                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control input-sm" placeholder="DEF"></asp:TextBox>
                                    </div>
                                </div>
                            
                            </div> 

                            <div class="row">
                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label ID="Label3" runat="server" Text="Date of Birth"></asp:Label>
                                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Date" CssClass="form-control input-sm" ></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-md-4 col-md-offset-1">
                                    <div class="form-group">
                                        <asp:Label ID="Label4" runat="server" Text="Program"></asp:Label>
                                        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control input-sm" placeholder="GHI"></asp:TextBox>
                                    </div>
                                </div>
                            
                            </div>


                        </div>
                    </section>
                </div>
            </div>

        </section>

    </section>



</asp:Content>

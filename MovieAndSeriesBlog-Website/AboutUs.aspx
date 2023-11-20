<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="MovieAndSeriesBlog_Website.AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!DOCTYPE HTML>
    <html>

    <body>
        <div class="about-content">
            <div class="container">

                <div class="about-section">
                    <div class="about-grid">
                        <h3>ABOUT ME</h3>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <p><%# Eval("Comment") %></p>
                            </ItemTemplate>
                        </asp:Repeater>
                        
                    </div>


                </div>
            </div>
        </div>
    </body>
    </html>




</asp:Content>

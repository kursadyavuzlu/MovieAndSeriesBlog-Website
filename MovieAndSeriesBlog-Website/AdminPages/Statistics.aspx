<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="MovieAndSeriesBlog_Website.AdminPages.Statistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class ="table table-bordered">
        <tr>
            <td>
                Total number of blogs: <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" BackColor="#0099FF"></asp:Label>
            </td>
            <td>
                Total number of comments: <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="True" BackColor="#0099FF"></asp:Label>
            </td>
            <td>
                Total number of movies: <asp:Label ID="Label3" runat="server" Text="Label" Font-Bold="True" BackColor="#0099FF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                Total number of series: <asp:Label ID="Label4" runat="server" Text="Label" Font-Bold="True" BackColor="#0099FF"></asp:Label>
            </td>
            <td>
                Total number of documentaries: <asp:Label ID="Label5" runat="server" Text="Label" Font-Bold="True" BackColor="#0099FF"></asp:Label>
            </td>
            <td>
                Blog with most comments: <asp:Label ID="Label6" runat="server" Text="Label" Font-Bold="True" BackColor="#0099FF"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>

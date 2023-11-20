<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Messages.aspx.cs" Inherits="MovieAndSeriesBlog_Website.AdminPages.Messages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class ="table table-bordered">
        <tr>
            <th>ID</th>
            <th>NAME</th>
            <th>MAIL</th>
            <th>PHONE</th>
            <th>TOPIC</th>
            <th>MESSAGE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("MessageID") %></td>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Mail") %></td>
                    <td><%# Eval("Phone") %></td>
                    <td><%# Eval("Topic") %></td>
                    <td><%# Eval("Message") %></td>
                    <td></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>

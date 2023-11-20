<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Comments.aspx.cs" Inherits="MovieAndSeriesBlog_Website.AdminPages.Comments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class ="table table-bordered">
        <tr>
            <th>ID</th>
            <th>USERNAME</th>
            <th>BLOG</th>
            <th>DELETE</th>
            <th>UPDATE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("CommentID") %></td>
                    <td><%# Eval("Username") %></td>
                    <td><%# Eval("BlogTitle") %></td>
                    <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"CommentDelete.Aspx?CommentID="+Eval("CommentID") %>' CssClass="btn btn-danger">DELETE</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"CommentUpdate.Aspx?CommentID="+Eval("CommentID") %>' CssClass="btn btn-warning">UPDATE</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>

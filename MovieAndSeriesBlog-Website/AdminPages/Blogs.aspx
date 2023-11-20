<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Blogs.aspx.cs" Inherits="MovieAndSeriesBlog_Website.AdminPages.Blogs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class ="table table-bordered">
        <tr>
            <th>ID</th>
            <th>TITLE</th>
            <th>DATE</th>
            <th>TYPE</th>
            <th>CATEGORY</th>
            <th>DELETE</th>
            <th>UPDATE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("BlogID") %></td>
                    <td><%# Eval("BlogTitle") %></td>
                    <td><%# Eval("BlogDate") %></td>
                    <td><%# Eval("BlogType") %></td>
                    <td><%# Eval("BlogCategory") %></td>
                    <td><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"BlogDelete.Aspx?BlogID="+Eval("BlogID") %>' CssClass="btn btn-danger">DELETE</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"BlogUpdate.Aspx?BlogID="+Eval("BlogID") %>' CssClass="btn btn-warning">UPDATE</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="NewBlog.Aspx" class="btn btn-primary">New Blog</a>
</asp:Content>

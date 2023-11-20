<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MovieAndSeriesBlog_Website.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="content-grids">
            <div class="col-md-8 content-main">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="content-grid">
                            <div class="content-grid-info">
                                <img src="<%# Eval("BlogImage") %>" alt="" style="height: 300px; width: 600px; margin-bottom: 20px" />
                                <div class="post-info">
                                    <h4><a href="BlogDetail.Aspx?BLOGID=<%# Eval("BlogID") %>"><%# Eval("BlogTitle") %></a>  <%# Eval("BlogDate") %></h4>
                                    <p><%# Eval("BlogContent") %></p>
                                    <a href="BlogDetail.Aspx?BLOGID=<%# Eval("BlogID") %>"><span></span>READ MORE</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
            <div class="col-md-4 content-right">
                <div class="recent">
                    <h3>LATEST BLOGS</h3>
                    <ul>
                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <li><a href="BlogDetail.Aspx?BLOGID=<%# Eval("BlogID") %>"><%# Eval("BlogTitle") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>

                    </ul>
                </div>
                <div class="comments">
                    <h3>LATEST COMMENTS</h3>

                    <asp:Repeater ID="Repeater4" runat="server">
                        <ItemTemplate>
                            <ul>
                                <li><a href="#"><%# Eval("Username") %> - <%# Eval("CommentContent") %></a></li>
                            </ul>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div class="clearfix"></div>
                <div class="categories">
                    <h3>CATEGORIES</h3>
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <li><a href="CategoryDetail.Aspx?CategoryID=<%# Eval("CategoryID") %>"><%# Eval("CategoryName") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>

                    </ul>
                </div>
                <div class="clearfix"></div>
            </div>
            <div class="clearfix"></div>
        </div>
    </div>

</asp:Content>

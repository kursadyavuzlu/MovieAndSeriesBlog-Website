<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MovieAndSeriesBlog_Website.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <html>
    <body>

        <div class="contact-content">
            <div class="container">
                <div class="contact-info">
                    <h2>CONTACT</h2>
                    <p>You can leave us a message on any issue, we are looking forward to your comments.</p>
                </div>




                <div class="contact-details">
                    <form runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="Name" ForeColor="Black"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail"></asp:TextBox>
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Phone"></asp:TextBox>
                        <asp:TextBox ID="TextBox4" runat="server" placeholder="Topic" style="margin-right:0;"></asp:TextBox>
                        <asp:TextBox ID="TextBox5" runat="server" placeholder="Message" TextMode="MultiLine" Height="100px"></asp:TextBox>


                        <asp:Button ID="Button1" runat="server" Text="SEND" OnClick="Button1_Click" />
                    </form>
                </div>
                <div class="contact-details">
                    <div class="col-md-6 contact-map">
                        <h4>FIND US HERE</h4>
                        <div class="mapouter">
                            <div class="gmap_canvas">
                                <iframe width="570" height="510" id="gmap_canvas" src="https://maps.google.com/maps?q=mersin&t=&z=10&ie=UTF8&iwloc=&output=embed" frameborder="0" scrolling="no" marginheight="0" marginwidth="0"></iframe>
                            </div>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                </div>


            </div>
        </div>
    </body>
    </html>




</asp:Content>

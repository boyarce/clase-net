<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.app.site.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login MySite</title>
    <link rel="stylesheet" runat="server" 
        media="screen" href="../css/style.css" />
</head>
<body>
   <form id="frm_login" runat="server">
        <div id="pnl_container" class="container">
            <div id="row_user" class="row">
                <div class="col-100">
                    <asp:TextBox ID="txt_username" 
                        runat="server" 
                        placeholder="Your User ..."/>
                </div>
            </div>
            <div id="row_password" class="row">
                <div class="col-100">
                    <asp:TextBox ID="txt_pass" 
                        TextMode="Password" 
                        runat="server" 
                        placeholder="Your Pass ..."/>
                </div>
            </div>
            <div id="row_send" class="row">
                <div class="col-50"></div>
                <div class="col-50">
                    <asp:Button ID="btn_login" 
                        runat="server" Text="LOGIN"
                        OnClick="btn_login_Click"/>
                </div>
            </div>
            <div id="row_message" class="row">
                <div class="col-100">
                    <asp:Label ID="lbl_message_error"
                        runat="server"
                        Text=" " />
                </div>

            </div>

        </div>
    </form>
    <%-- <form id="frm_login" runat="server">
    <div>
        <asp:Label ID="lbl_username" runat="server">Username</asp:Label>
        <asp:TextBox ID="txt_username" runat="server" placeholder="Your User ..."/>
        <asp:Label ID="lbl_pass" runat="server">Password</asp:Label>
        <asp:TextBox ID="txt_pass" TextMode="Password" runat="server" placeholder="Your Pass ..."/>
        <asp:Button ID="btn_login" runat="server" Text="LOGIN" OnClick="btn_login_Click"/>
    </div>
    </form> --%>
</body>
</html>

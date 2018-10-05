<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="tregistrar_usuario.aspx.cs" Inherits="Presentacion.app.site.tregistrar_usuario" %>
<asp:Content ID="registrar_usuario_header" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="registrar_usuario_body" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-50">
            <span>NOMBRE USUARIO</span>            
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_usuario" runat="server"  placeholder="Nombre Usuario"/>
        </div>
    </div>
    <div class="row">
                <div class="col-50">
            <span>PASSWORD</span>            
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_password" runat="server" TextMode="Password"  placeholder="Password"/>
        </div>
    </div>
    <div class="row">
        <div class="col-75">&nbsp;</div>
    </div>
    <div class="col-25">
        <asp:Button ID="btn_create" runat="server" Text="CREAR"  OnClick="btn_create_Click"/>
    </div>
      <div id="row_message" class="row">
                <div class="col-100">
                    <asp:Label ID="lbl_message_error"
                        runat="server"
                        Text=" " />
                </div>

            </div>
</asp:Content>

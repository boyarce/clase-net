<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="comuna.aspx.cs" Inherits="Presentacion.app.site.comuna" %>
<asp:Content ID="comuna_head" ContentPlaceHolderID="head" runat="server">
    <title>COMUNA</title>
</asp:Content>
<asp:Content ID="comuna_content" ContentPlaceHolderID="content" runat="server">
        <div class="row">
        <div class="col-50">
            <span>CODIGO</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_codigo" runat="server"
                value="" placeholder="Codigo">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>NOMBRE</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_nombre" runat="server"
                value="" placeholder="Nombre">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>REGION</span>
        </div>
        <div class="col-50">
            <asp:DropDownList ID="cmb_regiones" runat="server" DataValueField="Codigo"
               DataTextField="Nombre"></asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="col-75">
            <span>&nbsp;</span>
        </div>
        <div class="col-25 green-button">
            <asp:Button ID="btn_create" runat="server"
                Text="CREATE"  OnClick="btn_create_Click"/>
        </div>
    </div>
    <div class="row">
        <asp:GridView ID="tbl_comunas" runat="server"
            OnRowDataBound="tbl_comunas_RowDataBound"
            OnRowEditing="tbl_comunas_RowEditing"
            OnRowCancelingEdit="tbl_comunas_RowCancelingEdit"
            OnRowUpdating="tbl_comunas_RowUpdating"
            OnRowDeleting="tbl_comunas_RowDeleting"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField ="Codigo"
                    HeaderText="Codigo" ReadOnly="true" />
                <asp:BoundField DataField ="Nombre"
                    HeaderText="Nombre" ReadOnly="false" />
                <asp:TemplateField HeaderText="REGIÓN">
                    <ItemTemplate>
                        <asp:DropDownList ID="cmb_regiones_tbl" runat="server" 
                             DataTextField="Nombre" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="" >
                    <ItemTemplate>
                        <div class="skyblue-button">
                            <asp:Button ID="btn_edit"
                                runat="server" Text="EDIT" CommandName="Edit" />
                        </div>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <div class="skyblue-button">
                            <asp:Button ID="btn_update" 
                                runat="server" Text="UPDATE" CommandName="Update" />
                        </div>
                        <div class="yellow-button">
                            <asp:Button ID="btn_cancel" CssClass="red-button"
                                runat="server" Text="CANCEL" CommandName="Cancel" />
                        </div>

                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="" ItemStyle-CssClass="red-button">
                    <ItemTemplate>
                        <asp:Button ID="btn_delete" runat="server"
                            Text="DELETE" CommandName="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

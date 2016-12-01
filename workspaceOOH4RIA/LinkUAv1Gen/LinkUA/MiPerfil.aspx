<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="MiPerfil.aspx.cs" Inherits="LinkUA.MiPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="col-md-8">
            <div class="form-group">
                <label class="control-label col-sm-2">Nick</label>
                <div class="col-sm-4">
                    <asp:Label ID="LabelNick" runat="server" Text="Label" CssClass="form-control"></asp:Label>
                </div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Email</label>
                <div class="col-sm-4">
                    <asp:Label ID="LabelEmail" runat="server" Text="LabelNombre" CssClass="form-control"></asp:Label>
                </div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Nombre</label>
                <div class="col-sm-4">
                    <asp:Label ID="LabelNombre" runat="server" Text="LabelNombre" CssClass="form-control"></asp:Label>
                </div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Apellidos</label>
                <div class="col-sm-4">
                    <asp:Label ID="LabelApellidos" runat="server" Text="LabelApellidos" CssClass="form-control"></asp:Label>
                </div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Teléfono</label>
                <div class="col-sm-4">
                    <asp:Label ID="LabelTelf" runat="server" Text="LabelTelf" CssClass="form-control"></asp:Label>
                </div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Fecha de Nacimiento</label>
                <div class="col-sm-4">
                    <asp:Label ID="LabelFecha" runat="server" Text="Label" CssClass="form-control"></asp:Label>
                </div>
                <br />
            </div>
            <div class="form-group">
                <br />
                <label class="control-label col-sm-2">Titulación</label>
                <div class="col-sm-4">
                    <asp:Label ID="LabelTitulacion" runat="server" Text="LabelTitula" CssClass="form-control"></asp:Label>
                </div>
            </div>
            <div class="form-group">
                <br />
                <div class="col-sm-4">
                    <asp:Button ID="Button1" runat="server" Text="Modificar Perfil" OnClick="Button1_Click" CssClass="btn btn-info btn-md"></asp:Button></div>
            </div>
        </div>
        <div class="col-md-2"></div>
    </form>
</asp:Content>

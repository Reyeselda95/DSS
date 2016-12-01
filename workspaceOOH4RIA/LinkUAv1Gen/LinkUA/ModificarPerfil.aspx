<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="ModificarPerfil.aspx.cs" Inherits="LinkUA.ModificarPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="col-md-8">
            <div class="form-group">
                <label class="control-label col-sm-2">Nick</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="NickName" runat="server" CssClass="form-control"></asp:TextBox></div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Email</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="User" runat="server" CssClass="form-control"></asp:TextBox></div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Nombre</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox></div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Apellidos</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox></div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Teléfono</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox></div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Fecha de Nacimiento</label>
                <div class="col-sm-4">
                    <asp:TextBox ID="fnac" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"
                        ControlToValidate="fnac" ErrorMessage="Este Campo no puede estar vacio"
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <br />
                <br />
                <br />
            </div>
            <div class="form-group">
                <asp:Button ID="Label6" runat="server" Text="Cambiar Contraseña" OnClick="Label6_Click" CssClass="btn btn-info btn-md"></asp:Button>
            </div>
            <div class="form-group">
                <asp:Button ID="Button1" runat="server" Text="Guardar Cambios" OnClick="Button1_Click" CssClass="btn btn-info btn-md"></asp:Button>
            </div>
        </div>
        <div class="col-md-2"></div>
    </form>
</asp:Content>

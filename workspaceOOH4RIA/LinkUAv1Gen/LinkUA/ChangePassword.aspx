<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="LinkUA.changePass1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <form id="form1" runat="server">
    <div class="form-group">
        <label class ="control-label col-sm-2">Contraseña anterior</label>
        <div class="col-sm-2">
            <asp:TextBox ID="lastPass" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="lastPass" ErrorMessage="Debe introducir su contraseña anterior para poder cambiarla" 
            ForeColor="Red"></asp:RequiredFieldValidator>
    </div>

    <div class="form-group">
        <label class ="control-label col-sm-2">Nueva Contraseña</label>
        <div class="col-sm-2">
            <asp:TextBox ID="pass1" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="pass1" ErrorMessage="Este Campo no puede estar vacio" 
            ForeColor="Red"></asp:RequiredFieldValidator>
    </div>

    <div class="form-group">
        <label class ="control-label col-sm-2">Repita la nueva contraseña</label>
        <div class="col-sm-2">
            <asp:TextBox ID="pass2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="pass2" ErrorMessage="Este Campo no puede estar vacio" 
            ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ControlToCompare="pass2" ControlToValidate="pass1" 
            ErrorMessage="Las contraseñas no coinciden" ForeColor="Red"></asp:CompareValidator>
        <br /><br />
    </div>
    <div class="form-group">
        <asp:Button ID="ButtonIni" runat="server" Text="Cambiar Contraseña" onclick="ButtonIni_Click"/>
    </div>
           </form>
</asp:Content>

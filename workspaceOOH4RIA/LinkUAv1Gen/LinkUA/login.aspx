<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LinkUA.login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-4"></div>
    <div class="container col-md-4">
        <form id="form1" runat="server" class="form-signin">
            <asp:Label ID="LabelError" runat="server" ForeColor="Red"
                Style="text-align: center" Text="* Email o contraseña incorrectos *"
                Visible="False"></asp:Label>
            <asp:TextBox ID="UserName" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ControlToValidate="UserName"
                ErrorMessage="Error, el email no puede estar vacio" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="Password" ErrorMessage="Introduzca contraseña"
                ForeColor="Red"></asp:RequiredFieldValidator>
            <h5 class="form-signin-heading"><a href="Registro.aspx">Registrate</a> si no tiene una cuenta aún.</h5>
            <asp:Button ID="ButtonIni" runat="server" Text="Iniciar Sesión" OnClick="ButtonIni_Click" CssClass="btn btn-lg btn-primary btn-block" />
        </form>
    </div>

</asp:Content>

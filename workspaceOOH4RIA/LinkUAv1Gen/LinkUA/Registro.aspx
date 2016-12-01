<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="LinkUA.Registro1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-10">
        <form id="form1" runat="server">
            <h2>REGISTRO</h2>


            <p>
                <asp:Label ID="LabelError1" runat="server" ForeColor="Red"
                    Text="Error, fallo al crear usuario" Visible="False"></asp:Label>
                <asp:Label ID="LabelError2" runat="server" ForeColor="Red"
                    Text="Error, el email seleccionado ya esta en uso" Visible="False"></asp:Label>
            </p>
            <div class="form-group">
                <label class="control-label col-sm-2">Nick*</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="nick" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                    ControlToValidate="nick" ErrorMessage="Este Campo no puede estar vacio"
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Email*</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="email1" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Label ID="LabelError3" runat="server" ForeColor="Red" Text="El Email introducido no pertenece a la UA" Visible="False"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="email1" ErrorMessage="Este Campo no puede estar vacio"
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Repetir email*</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="email2" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="email2" ErrorMessage="Este Campo no puede estar vacio"
                    ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server"
                    ControlToCompare="email2" ControlToValidate="email1"
                    ErrorMessage="Los emails no coinciden" ForeColor="Red"></asp:CompareValidator>
            </div>
            <h5><span class="label label-default">Datos Personales</span></h5>
            <div class="form-group">
                <label class="control-label col-sm-2">Nombre*</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="nom" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ControlToValidate="nom" ErrorMessage="Este Campo no puede estar vacio"
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Apellidos*</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="ape" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                    ControlToValidate="ape" ErrorMessage="Este Campo no puede estar vacio"
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Fecha de nacimiento*</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="fnac" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"
                    ControlToValidate="fnac" ErrorMessage="Este Campo no puede estar vacio"
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <br />
                <label class="control-label col-sm-2">Titulacion</label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="titulacion" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                    ControlToValidate="titulacion" ErrorMessage="Este Campo no puede estar vacio"
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Teléfono</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="telf" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <br />
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Contraseña*</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="pass1" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                    ControlToValidate="pass1" ErrorMessage="Este Campo no puede estar vacio"
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label class="control-label col-sm-2">Repetir contraseña*</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="pass2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"
                    ControlToValidate="pass2" ErrorMessage="Este Campo no puede estar vacio"
                    ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator2" runat="server"
                    ControlToCompare="pass2" ControlToValidate="pass1"
                    ErrorMessage="Las contraseñas no coinciden" ForeColor="Red"></asp:CompareValidator>
            </div>
            <div class="form-group">
                <asp:Button ID="ButtonCrearCli" runat="server" Text="Crear cuenta" OnClick="ButtonCrear_Click" />
            </div>
            <address>
                *Campos obligatorios
            </address>
        </form>
        <div class="col-md-2"></div>
</asp:Content>

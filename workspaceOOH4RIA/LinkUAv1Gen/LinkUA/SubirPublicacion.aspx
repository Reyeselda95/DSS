<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="SubirPublicacion.aspx.cs" Inherits="LinkUA.SubirPublicacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="LabelTitulo" runat="server" Text="Título: "></asp:Label>
            <asp:TextBox ID="titulo" runat="server" Height="16px" Width="264px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="labelCat" runat="server" Text="Categoría: "></asp:Label>
            <asp:DropDownList ID="cat" runat="server" Height="16px" Width="127px" AutoPostBack="True">
                <asp:ListItem Value="1">Social</asp:ListItem>
                <asp:ListItem Value="2">Alojamiento</asp:ListItem>
                <asp:ListItem Value="3">Educación</asp:ListItem>
                <asp:ListItem Value="4">Flechazo</asp:ListItem>
                <asp:ListItem Value="5">Otros</asp:ListItem>
                <asp:ListItem Value="6">Ocio</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="LabelCont" runat="server" Text="Contenido: "></asp:Label>
        </p>
        <p>
            &nbsp;<asp:TextBox ID="cont" runat="server" Height="159px" Width="482px"></asp:TextBox>
        </p>
        <p>
            <asp:RadioButton ID="RadioAnonimo" runat="server" OnCheckedChanged="RadioAnonimo_CheckedChanged" Text="Anonimo" Checked="True" AutoPostBack="True" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioFirmado" runat="server" OnCheckedChanged="RadioFirmado_CheckedChanged" Text="Firmado" Checked="False" AutoPostBack="True" />
        </p>
        <p>
            <asp:Button ID="Publicar" runat="server" Height="50px" OnClick="Publicar_Click" Text="Publicar" Width="136px" />
        </p>
    </form>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="SubirComentario.aspx.cs" Inherits="LinkUA.SubirComentario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #form1 {
            width: 1118px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div style="width: 1116px;">
            <div style="height: 52px; width: 217px">
                
                <asp:Label ID="NombreUsuario" runat="server"></asp:Label>
                
            </div>
            <asp:TextBox ID="TextBox1" runat="server" Height="188px" Width="762px"></asp:TextBox>
        </div>
    </form>
</asp:Content>

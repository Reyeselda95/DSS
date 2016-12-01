<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="LinkUA.Categoria" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form ID="form2" runat="server">
        <asp:ListView ID="ListView1" runat="server">
            <EmptyDataTemplate>
                <span>No se han devuelto datos.</span>
            </EmptyDataTemplate>
            <ItemTemplate>
                <itemtemplate>
                <div class="container col-md-12">
                    <div class="jumbotron">
                        <table class="table table-condensed">
                            <thead>
                                    <tr>
                                        <th>
                                            <a href="VerPublicacion.aspx?ID=<%# Eval("id") %>'" style="text-decoration: none">
                                            <asp:Label ID="idPublicacionLabel" runat="server" Text='<%# Eval("id") %>' />
                                            <asp:Label ID="tituloLabel" runat="server" Text='<%# Eval("titulo") %>' />
                                            </a>
                                        </th>
                                        <th></th>
                                        <th>
                                            <asp:Label ID="fechaLabel" runat="server" Text='<%# Eval("fecha") %>' /></th>
                                    </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        <asp:Label ID="textoLabel" runat="server" Text='<%# Eval("texto") %>' /></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:LinkButton ID="Like" runat="Server" CommandArgument='<%# Eval("id") %>' CommandName="idPubli"  OnClick="DarLike"><span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span></asp:LinkButton>(<asp:Label ID="likesLabel" runat="server" Text='<%# Eval("likes") %>' />)
                                    </td>
                                    <td></td>
                                    <td>Cat:<asp:Label ID="categoriaLabel" runat="server" Text='<%# Eval("categoria") %>' />
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    </a>
                </div>
            </itemtemplate>
            </ItemTemplate>
            <LayoutTemplate>
                <div class="col-md-8">
                    <div id="itemPlaceholderContainer" runat="server" style="">
                        <span runat="server" id="itemPlaceholder" />
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Primera" OnClick="First" />
                    <asp:Button ID="Button2" runat="server" Text="Anterior" OnClick="Previous" />
                    <asp:Button ID="Button3" runat="server" Text="Siguiente" OnClick="Next" />
                    <asp:Button ID="Button4" runat="server" Text="Ultima" OnClick="Last" />
                </div>
            </LayoutTemplate>
        </asp:ListView>
        <div class="col-md-4">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <h3 class="panel-title">Posts Destacados</h3>
                </div>
                <div class="panel-body">
                    contenido
                </div>
            </div>
        </div>
    </form>

</asp:Content>

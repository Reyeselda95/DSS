<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="VerPublicacion.aspx.cs" Inherits="LinkUA.VerPublicacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
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
                                            <%--<a href="VerPublicacion.aspx?<%# Eval("id") %>'" style="text-decoration: none"> comentado***--%>
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
                </div>
            </LayoutTemplate>
        </asp:ListView>
        </div>
        <div class="container">
            <!-- Trigger the modal with a button -->
            <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Añadir Comentario</button>

            <!-- Modal -->
            <div class="modal fade" id="myModal" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Comentar en esta publicacón</h4>
                        </div>
                        <div class="modal-body">
                            <h4><asp:Label ID="NombreUsuario" runat="server" CssClass="label label-primary"></asp:Label></h4>
                            <asp:TextBox ID="SComentario" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="ButtonComentar" runat="server" Text="Comentar" OnClick="ComentarClick" CssClass="btn btn-info btn-sm"/>
                            <button type="button" class="btn btn-default btn-sm" data-dismiss="modal">Cerrar</button>
                        </div>
                    </div>

                </div>
            </div>

        </div>
        <div>
            <asp:ListView ID="ListView2" runat="server">
                <EmptyDataTemplate>
                <span>No se han devuelto datos.</span>
            </EmptyDataTemplate>
            <ItemTemplate>
                <itemtemplate>
                <div class="container col-md-12">
                    <div class="jumbotron">
                        <table class="table table-condensed">
                            <thead>
                                        <th>
                                            <asp:Label ID="NickUsuario" runat="server" Text='<%# Eval("usuario_2") %>' />
              
                                        </th>
     
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        <asp:Label ID="Comentario" runat="server" Text='<%# Eval("texto") %>' /></td>
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
                </div>
            </LayoutTemplate>
            </asp:ListView>
        </div>
    </form>
</asp:Content>

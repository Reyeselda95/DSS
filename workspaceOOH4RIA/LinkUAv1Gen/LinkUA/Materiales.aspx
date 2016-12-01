<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Materiales.aspx.cs" Inherits="LinkUA.Materiales" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form2" runat="server">
        <asp:ListView ID="ListView1" runat="server">
            <EmptyDataTemplate>
                <span>No se han devuelto datos.</span>
            </EmptyDataTemplate>
            <ItemTemplate>
                <itemtemplate>
                <div class="container col-md-12">
                    <div class="panel panel-default">
                        <div class="panle panel-heading">
                            <a href="VerMaterial.aspx?ID=<%# Eval("id") %>'" style="text-decoration: none">
                                <asp:Label ID="idMaterialLabel" runat="server" Text='<%# Eval("id") %>' />
                                <asp:Label ID="nombreLabel" runat="server" Text='<%# Eval("nombre") %>' />
                            </a>
                        </div>
                        <table class="table table-condensed">
                            <tbody>
                                <tr>
                                    <td>
                                        <asp:Label ID="descripcionLabel" runat="server" Text='<%# Eval("descripcion") %>' /></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:LinkButton ID="Download" runat="Server" CommandArgument='<%# Eval("id") %>' CommandName="idMat" OnClick="Descargar" OnClientClick="Navigate()"><span class="glyphicon glyphicon-download" aria-hidden="true"></span></asp:LinkButton>(<asp:Label ID="descargasLabel" runat="server" Text='<%# Eval("descargas") %>' />)
                                            <script type="text/javascript">
                                                function Navigate()
                                                {
                                                    javascript: window.open('<%# Eval("url") %>');
                                                }
                                            </script>
                                    </td>
                                    <td></td>
                                    <td>Asignatura: <asp:Label ID="asignaturaLabel" runat="server" Text='<%# Eval("asignatura_2.nombre") %>' /></td>
                                    <td>Propietario: <asp:Label ID="propietarioLabel" runat="server" Text='<%# Eval("usuario_8.email") %>' /></td>
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
    </form>

</asp:Content>

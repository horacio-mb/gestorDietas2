<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDieta.aspx.cs" Inherits="capaPresentacion.frmDieta" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>frmDieta</title>
    <style>
        .modalBackground{
            background-color: black;
            filter:alpha(opacity=90) !important;
            opacity:0.6 !important;
            z-index:20;
        }
        .modalPopup{
            padding:20px 0px 24px 10px;
            position: relative;
            width:550px;
            height:300px;
            background-color:white;
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <center>
        <a href="frmTipoComida.aspx">TipoComida</a>&nbsp;
        <a href="frmComida.aspx">Comida</a>&nbsp;
        <a href="frmCliente.aspx">Cliente</a>&nbsp;
	<a href="frmUsuario.aspx">Usuario</a>&nbsp;
        <a href="frmDieta.aspx">Dieta</a>&nbsp;
        <h3>REGISTRO DE DIETAS</h3>
    <form id="form1" runat="server">
            <div>
                <asp:Table runat="server">
                    <asp:TableRow>
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtIdDieta" Type="hidden" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtIdCliente" Type="hidden" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtIdUsuario" Type="hidden" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Nombre Dieta</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtNomDieta" Type="text" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Fecha de Inicio</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtFechaInicio" type="date" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Fecha de Final</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtFechaFinal" type="date" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Cliente</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtCliente" runat="server"></asp:TextBox></asp:TableCell>
                        <asp:TableCell><a href="#" runat="server" onserverclick="buscarCliente">Buscar Cliente</a></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Usuario</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></asp:TableCell>
                        <asp:TableCell><a href="#" runat="server" onserverclick="buscarUsuario">Buscar Usuario</a></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell><a href="#" runat="server" onserverclick="buscarComida">Agregar Comida</a></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <br />
                <%--Tabla detalle Dieta--%>
                <div>
                    <asp:GridView ID="gvDetalle" Width="500px" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvDetalle_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" HeaderText="Opcion" SelectText="Quitar"/>
                            <asp:BoundField DataField="descripcion" ItemStyle-Width="150" HeaderText="Comida"/>
                            <asp:BoundField DataField="distribucion" HeaderText="Distribucion"/>
                        </Columns>
                    </asp:GridView>
                </div>
                <br />
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click"/>&nbsp;
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>&nbsp;
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click"/>&nbsp;
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/>&nbsp;
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/><br />
                <asp:Label ID="lblResp" runat="server" Text=""></asp:Label>
            </div>

            <%--Modales Cliente Usuario Comida--%>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <%--Inicio modal buscar cliente--%>
            <asp:Label ID="lblCliente" runat="server" Text=""></asp:Label>
            <ajaxToolkit:ModalPopupExtender ID="miModalC" runat="server" TargetControlID="lblCliente" PopupControlID="modalCliente" 
                BackgroundCssClass="modalBackground"></ajaxToolkit:ModalPopupExtender>

            <div id="modalCliente" class="modalPopup">
                 <div id="Header" class="header" >
                     Busqueda de Clientes
                     <br />
                     <br />
                 </div>
                 <div id="main" class="main">
                    <asp:TextBox ID="txtBuscarC" runat="server" OnTextChanged="txtBuscarC_TextChanged"></asp:TextBox>&nbsp;
                    <asp:Button ID="btnBuscarCli" runat="server" Text="Buscar por Nombre" OnClick="btnBuscarC"/>
                    <br />
                    <br />
                    <asp:GridView ID="gvCliente" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvCliente_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="idCliente" HeaderText="Id"/>
                            <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
                            <asp:BoundField DataField="apellido_paterno" HeaderText="Paterno"/>
                            <asp:BoundField DataField="apellido_materno" HeaderText="Materno"/>
                            <asp:BoundField DataField="fecha" HeaderText="FechNac"/>
                            <asp:BoundField DataField="correo" HeaderText="Email"/>
                            <asp:BoundField DataField="telefono" HeaderText="Telefono"/>
                            <asp:BoundField DataField="sexo" HeaderText="Sexo"/>
                            
                            <asp:CommandField ShowSelectButton="True" HeaderText="Opcion" SelectText="Seleccionar"/>
                        </Columns>
                    </asp:GridView>

                 </div>
                 <div>
                     <br />
                      <asp:Button id="btnCerrarC" runat="server" text="Cerrar" OnClick="btnCerrarCli" />
                 </div>
            </div>
            <%--Fin modal buscar cliente--%>

            <%--Inicio modal buscar usuario--%>
            <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
            <ajaxToolkit:ModalPopupExtender ID="miModalU" runat="server" TargetControlID="lblCliente" PopupControlID="modalUsuario" 
                BackgroundCssClass="modalBackground"></ajaxToolkit:ModalPopupExtender>
            <div id="modalUsuario" class="modalPopup">
                 <div id="Header4" class="header" >
                     Busqueda de Usuarios
                     <br />
                     <br />
                 </div>
                 <div id="main4" class="main">
                    <asp:TextBox ID="txtBuscarU" runat="server" OnTextChanged="txtBuscarC_TextChanged"></asp:TextBox>&nbsp;
                    <asp:Button ID="btnBuscarUsu" runat="server" Text="Buscar por Nombre" OnClick="btnBuscarU"/>
                    <br />
                    <br />
                    <asp:GridView ID="gvUsuario" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvUsuario_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="idUsuario" HeaderText="Id"/>
                            <asp:BoundField DataField="usuario" HeaderText="Usuario"/>
                            <asp:BoundField DataField="correo" HeaderText="Correo"/>
                            <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
                            <asp:BoundField DataField="paterno" HeaderText="Paterno"/>
                            <asp:BoundField DataField="materno" HeaderText="Materno"/>
                            <asp:BoundField DataField="cargo" HeaderText="Cargo"/>
                            
                            <asp:CommandField ShowSelectButton="True" HeaderText="Opcion" SelectText="Seleccionar"/>
                        </Columns>
                    </asp:GridView>

                 </div>
                 <div>
                     <br />
                      <asp:Button id="btnCerrarU" runat="server" text="Cerrar" OnClick="btnCerrarUsu" />
                 </div>
            </div>
            <%--Fin modal buscar usuario--%>


             <%--Inicio modal buscar Comida--%>
             <asp:Label ID="lblComida" runat="server" Text=""></asp:Label>
            <ajaxToolkit:ModalPopupExtender ID="miModalCo" runat="server" TargetControlID="lblComida" PopupControlID="modalComida" 
                BackgroundCssClass="modalBackground"></ajaxToolkit:ModalPopupExtender>
            <div id="modalComida" class="modalPopup">
                 <div id="Header2" class="header" >
                     Seleccione una o varias comidas
                     <br />
                     <br />
                 </div>
                 <div id="main2" class="main">
                    <asp:TextBox ID="txtBuscarCom" runat="server"></asp:TextBox>&nbsp;
                    <asp:Button ID="btnBuscarComida" runat="server" Text="Buscar por Descripcion" OnClick="btnBuscarCom"/><br />
                     <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                    <br />
                    <br />
                    <asp:GridView ID="gvComida" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvComida_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="idComida" HeaderText="idComida"/>
                            <asp:BoundField DataField="descripcion" HeaderText="descripcion"/>
                            <asp:BoundField DataField="idTipoComida" HeaderText="idTipoComida"/>
                            <asp:CommandField ShowSelectButton="True" HeaderText="Opcion" SelectText="Seleccionar"/>
                        </Columns>
                    </asp:GridView>
                 </div>
                 <div>
                     <br />
                      <asp:Button id="btnCerrarP" runat="server" text="Cerrar" OnClick="btnCerrarPro" />
                 </div>
            </div>
            <%--Fin modal buscar comida--%>

            <%--Inicio modal buscar Dieta--%>
            <asp:Label ID="lblDieta" runat="server" Text=""></asp:Label>
            <ajaxToolkit:ModalPopupExtender ID="miModalD" runat="server" TargetControlID="lblDieta" PopupControlID="modalDieta" 
                BackgroundCssClass="modalBackground"></ajaxToolkit:ModalPopupExtender>
            
            <div id="modalDieta" class="modalPopup">
                 <div id="Header3" class="header" >
                     Busqueda de Dieta
                     <br />
                     <br />
                 </div>
                 <div id="main3" class="main">
                    <asp:TextBox ID="txtBuscarD" runat="server"></asp:TextBox>&nbsp;
                    <asp:Button ID="btnBuscarDieta" runat="server" Text="Buscar por Nombre de Cliente" OnClick="btnBuscarV"/>
                    <br />
                    <br />
                    <asp:GridView ID="gvDieta" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gvDieta_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="idDieta" HeaderText="IdDieta"/>
                            <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
                            <asp:BoundField DataField="fechaInicio" DataFormatString="{0:d}" HeaderText="fechaInicio"/>
                            <asp:BoundField DataField="fechaFinal" DataFormatString="{0:d}" HeaderText="fechaFinal"/>
                            <asp:BoundField DataField="cliente" HeaderText="Cliente"/>
                            <asp:CommandField ShowSelectButton="True" HeaderText="Opcion" SelectText="Seleccionar"/>
                        </Columns>
                    </asp:GridView>

                 </div>
                 <div>
                     <br />
                      <asp:Button id="btnCerrarD" runat="server" text="Cerrar" OnClick="btnCerrarDieta" />
                 </div>
            </div>
            <%--Fin modal buscar Dieta--%>
       
    </form>
    </center>
</body>
</html>

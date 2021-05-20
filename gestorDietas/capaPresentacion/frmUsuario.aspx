<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUsuario.aspx.cs" Inherits="capaPresentacion.frmUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <a href="frmTipoComida.aspx">TipoComida</a>&nbsp;
        <a href="frmComida.aspx">Comida</a>&nbsp;
        <a href="frmCliente.aspx">Cliente</a>&nbsp;
	<a href="frmUsuario.aspx">Usuario</a>&nbsp;
        <a href="frmDieta.aspx">Dieta</a>&nbsp;
    <form id="form1" runat="server">
        <div>
         <h3>REGISTRO DE USUARIOS</h3>
            <div>
              <asp:Table runat="server">
                    <asp:TableRow>
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtIdusuario" Type="hidden" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Usuario</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Correo</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Contraseña</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Nombre</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Apellido Paterno</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtPaterno" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Apellido Materno</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtMaterno" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Cargo</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtCargo" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <br />
                <br />
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click"/>
                &nbsp;
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
                &nbsp;
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click"/>
                &nbsp; 
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/>
                <br />
            </div>
             <br />
            <div>
                <asp:Label ID="lblResp" runat="server" Text=""></asp:Label>
                <label>
                <br />
                <br />
                Listado de Usuarios</label><br />
                <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>&nbsp;
                <asp:Button ID="btnBuscarC" runat="server" Text="Buscar por Cargo" OnClick="btnBuscarC_Click"/>
                <br />
                <br />
                <asp:GridView ID="gdvUsuario" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gdvUsuario_SelectedIndexChanged">
                      <Columns>
                        <asp:BoundField DataField="idUsuario" HeaderText="Id"/>
                        <asp:BoundField DataField="usuario" HeaderText="Usuario"/>
                        <asp:BoundField DataField="correo" HeaderText="Correo"/>
                        <asp:BoundField DataField="contrasena" HeaderText="Contraseña"/>
                        <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
                        <asp:BoundField DataField="paterno" HeaderText="Ap. Paterno"/>
                        <asp:BoundField DataField="materno" HeaderText="Ap. Materno"/>
                        <asp:BoundField DataField="cargo" HeaderText="Cargo"/>
                            <asp:CommandField ShowSelectButton="True" HeaderText="Opciones" SelectText="Seleccionar"/>
                        </Columns>
                  
                </asp:GridView>
                <br />
            </div>
        </div>
    </form>
</body>
</html>

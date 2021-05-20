<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTipoComida.aspx.cs" Inherits="capaPresentacion.frmTipoComida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>frmTipoComida</title>
</head>
<body>
    <a href="frmTipoComida.aspx">TipoComida</a>&nbsp;
        <a href="frmComida.aspx">Comida</a>&nbsp;
        <a href="frmCliente.aspx">Cliente</a>&nbsp;
	<a href="frmUsuario.aspx">Usuario</a>&nbsp;
        <a href="frmDieta.aspx">Dieta</a>&nbsp;
    <h3>REGISTRO DE TIPO COMIDA</h3>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                   <asp:TableCell><asp:TextBox ID="txtIdTipoComida" Type = "hidden" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Nombre</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click"/>&nbsp;
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>&nbsp;
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click"/>&nbsp;
            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/>&nbsp;
            
            <asp:Label ID="txtResp" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <label>Listado de Tipo Comida</label><br />
            <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>&nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar por Nombre" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:GridView ID="gvRegis" runat="server" AutoGenerateColumns="false" OnPageIndexChanged="gvRegis_SelectedIndexChanged" OnSelectedIndexChanged="gvRegis_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="idTipoComida" HeaderText="idTipoComida"/>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
                    <asp:CommandField ShowSelectButton="True" HeaderText="Opciones" SelectText="Editar"/>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

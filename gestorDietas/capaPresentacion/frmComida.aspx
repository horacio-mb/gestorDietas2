<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmComida.aspx.cs" Inherits="capaPresentacion.frmComida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <a href="frmTipoComida.aspx">Tipo Comida</a>&nbsp;
    <a href="frmComida.aspx">Comida</a>
    <h3>REGISTRO DE COMIDA</h3>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server" >
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtIdComida" Type ="hidden" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Descripcion</asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Tipo De Comida</asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="dd1" runat="server" AutoPostBack="false" Width="130"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
             </asp:Table>
             <br />
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click"/>&nbsp;
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>&nbsp;
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />&nbsp;
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" /><br />
            <asp:Label ID="txtResp" runat="server" Text=""></asp:Label>

        </div>
        <div>
            <br />
            <label>Listado de Comida</label><br />
            <asp:TextBox ID="txtBuscar" runat="server" OnTextChanged="txtBuscar_TextChanged"></asp:TextBox>&nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar por Descripcion" OnClick="btnBuscar_Click" />
            
            <br />
            <br />
            <asp:GridView ID="gvRegis" runat="server" AutoGenerateColumns="false" OnPageIndexChanged="gvRegis_SelectedIndexChanged" OnSelectedIndexChanged="gvRegis_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="idComida" HeaderText="idComida"/>
                    <asp:BoundField DataField="Descripcion" HeaderText="descripcion"/>
                    <asp:BoundField DataField="nombre" HeaderText="Tipo de Comida"/>
                    <asp:CommandField ShowSelectButton="True" HeaderText="Opciones" SelectText="Editar"/>
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>

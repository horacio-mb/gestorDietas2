﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCliente.aspx.cs" Inherits="capaPresentacion.frmCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>frmPersona</title>
</head>
<body>
    <h3>REGISTRO DE CLIENTES</h3>
    <form id="form1" runat="server">
        <div>
            <asp:Table runat="server">
                    <asp:TableRow>
                        <asp:TableCell></asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtIdCliente" Type="hidden" runat="server"></asp:TextBox></asp:TableCell>
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
                        <asp:TableCell>Fecha de Nacimiento</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtNacimiento" type="date" runat="server"></asp:TextBox></asp:TableCell>
                     </asp:TableRow>
                      <asp:TableRow>
                        <asp:TableCell>Correo</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox></asp:TableCell>
                     </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Telefono</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox></asp:TableCell>
                     </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>Sexo</asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButton ID="rb1" runat="server" GroupName="rbt" Checked="false"/>Masculino
                        <asp:RadioButton ID="rb2" runat="server" GroupName="rbt"/>Femenino
                    </asp:TableCell>
                     </asp:TableRow>
                </asp:Table>          
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
            <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
            <br />
            
            <asp:Label ID="txtResp" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <label>Listado de Clientes</label><br />
            <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>&nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar por Nombre" OnClick="btnBuscar_Click1" />
            <br />
            <br />
            <asp:GridView ID="gvRegis" runat="server" AutoGenerateColumns="false" OnPageIndexChanged="gvRegis_SelectedIndexChanged" OnSelectedIndexChanged="gvRegis_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID"/>
                    <asp:BoundField DataField="nombre" HeaderText="Nombre"/>
                    <asp:BoundField DataField="paterno" HeaderText="Ape. Paterno"/>
                    <asp:BoundField DataField="materno" HeaderText="Ape. Materno"/>
                    <asp:BoundField DataField="fecha_nacimiento" DataFormatString="{0:d}" HeaderText="Fecha Nacimiento"/>
                    <asp:BoundField DataField="correo" HeaderText="Correo"/>
                    <asp:BoundField DataField="telefono" HeaderText="Telefono"/>
                    <asp:BoundField DataField="sexo" HeaderText="Sexo"/>
                    <asp:CommandField ShowSelectButton="True" HeaderText="Opciones" SelectText="Editar"/>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

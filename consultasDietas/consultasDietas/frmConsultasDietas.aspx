<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConsultasDietas.aspx.cs" Inherits="consultasDietas.frmConsultasDietas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <center>
        <form id="form1" runat="server">
        <h3>Consultas</h3>
        <div>
            <div>
                <%--No funca 
                <h4>Buscar Dietas por Usuario</h4>
                <div>Usuario<br />
                    <asp:TextBox ID="txtBuscarU" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscarU" runat="server" Text="Buscar Usuario" OnClick="btnBuscarU_Click" />
                    <asp:GridView ID="gvdUsuario" runat="server">
                    </asp:GridView>
                </div>
                --%>
                <h4>Buscar Dietas por Cliente</h4>
                <div>Cliente<br />
                    <asp:TextBox ID="txtBuscarC" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscarC" runat="server" Text="Buscar Cliente" OnClick="btnBuscarC_Click" />
                    <asp:GridView ID="gvdBuscarC" runat="server">
                    </asp:GridView>
                </div>
                    
                <h4>Buscar Dietas por Rango de Fecha</h4>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Fecha Inicial"></asp:Label>
                    <asp:TextBox ID="txtFecha1" runat="server"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="FechaFinal"></asp:Label>
                    <asp:TextBox ID="txtFecha2" runat="server"></asp:TextBox>
                    <asp:Button ID="btnRango" runat="server" Text="Buscar Rango" OnClick="btnRango_Click" />
                    <asp:GridView ID="gvdFecha" runat="server">
                    </asp:GridView>
                </div>

                <h4> Mostrar Detalle por Cliente</h4>
                <div>Cliente<br />
                    <asp:TextBox ID="txtCliente" runat="server"></asp:TextBox>
                    <asp:Button ID="btnDetalleCliente" runat="server" Text="Detalle por Cliente" OnClick="btnDetalleCliente_Click" />
                    <asp:GridView ID="gvdDetalleClienteDieta" runat="server">
                    </asp:GridView>
                </div>

                <h4> Mostrar Detalle por Dieta</h4>
                <div>Nombre Dieta<br />
                    <asp:TextBox ID="txtNomDieta" runat="server"></asp:TextBox>
                    <asp:Button ID="btnNomDieta" runat="server" Text="Detalle por Dieta" OnClick="btnNomDieta_Click" />
                    <asp:GridView ID="gvDetalleDieta" runat="server">
                    </asp:GridView>
                </div>

                <h4> Mostrar Clientes por Sexo</h4>
                <div>---<br />
                    
                    <asp:RadioButton ID="rb1" runat="server" GroupName="rbt" Checked="false"/> Masculino
                    <asp:RadioButton ID="rb2" runat="server" GroupName="rbt" /> Femenino
                    <asp:Button ID="btnSexo1" runat="server" Text="Mostrar por Sexo" OnClick="btnSexo1_Click"/>
                    <asp:GridView ID="gvSexo1" runat="server">
                    </asp:GridView>
                </div>

                <h4> Contar Clientes por Sexo</h4>
                <div>---<br />
                    
                    <asp:RadioButton ID="rb3" runat="server" GroupName="rb" Checked="false"/> Masculino
                    <asp:RadioButton ID="rb4" runat="server" GroupName="rb" /> Femenino
                    <asp:Button ID="btnSexo2" runat="server" Text="Contar por Sexo" OnClick="btnSexo2_Click"/>
                    <asp:GridView ID="gvSexo2" runat="server"/>
                    <br />
                    
                </div>

            </div>
        </div>
    </form>
    </center>
    
</body>
</html>

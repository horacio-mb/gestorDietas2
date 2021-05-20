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
                <h4>Buscar Dietas por Usuario</h4>
                <div>Usuario<br />
                    <asp:TextBox ID="txtBuscarU" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscarU" runat="server" Text="Buscar Usuario" OnClick="btnBuscarU_Click" />
                    <asp:GridView ID="gvdUsuario" runat="server">
                    </asp:GridView>
                </div>
                <h4>Buscar Dietas por Cliente</h4>
                <div>Usuario<br />
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
            </div>
        </div>
    </form>
    </center>
    
</body>
</html>

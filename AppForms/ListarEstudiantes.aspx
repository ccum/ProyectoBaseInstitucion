<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarEstudiantes.aspx.cs" Inherits="AppForms.ListarEstudiantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">Listas estudiantes</asp:Label>
        <asp:Table ID="tb_listaEstudiantes" runat="server" BackColor="Yellow">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Apellido</asp:TableCell>
                <asp:TableCell runat="server">Nombre</asp:TableCell>
            </asp:TableRow>

            
        </asp:Table>
    </div>

    </form>
</body>
</html>

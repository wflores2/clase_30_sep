<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="prueba.aspx.vb" Inherits="clase_30_sep.prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Vericacion de DUI</title>
</head>
<body>
    <h1>Verificación de DUI</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="text_dui" runat="server" Text="Digite un numero de DUI: "></asp:Label>
            <asp:TextBox ID="dui" runat="server"></asp:TextBox>
            <asp:Button ID="Verificar" runat="server" Text="Verificar" />
        </div>
        <div>
            <asp:Label ID="resultado" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>

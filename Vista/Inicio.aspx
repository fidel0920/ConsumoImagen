<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Vista.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image runat="server" ID="imagenConsumo" />
            <br />
            <asp:Button runat="server" ID="btnConsultar" Text="Consultar" OnClick="btnConsultar_Click" />
        </div>
    </form>
</body>
</html>

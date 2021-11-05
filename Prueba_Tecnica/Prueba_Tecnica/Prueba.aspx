<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="Prueba_Tecnica.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Usuario: "></asp:Label>
        <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Consultar" Width="105px" OnClick="Button1_Click" style="height: 26px" />
        </p>
        <asp:GridView ID="nomina"  runat="server" AutoGenerateColumns="true">

        </asp:GridView>
    </form>
</body>
</html>

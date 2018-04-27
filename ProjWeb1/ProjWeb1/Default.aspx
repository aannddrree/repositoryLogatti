<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjWeb1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Olá Turma!<br />
            <br />
            <asp:TextBox ID="TxtDescricao" runat="server" Width="229px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" Text="OK" Width="130px" />
            <br />
            <br />
            <br />
            <asp:Label ID="LblMSG" runat="server"></asp:Label>
        </div>
        <p>
            <asp:Button ID="BtnListar" runat="server" OnClick="BtnListar_Click" Text="Listar" />
        </p>
        <p>
            <asp:Label ID="Lista" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>

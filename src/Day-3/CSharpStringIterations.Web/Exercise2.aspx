<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise2.aspx.cs" Inherits="CSharpTypes.Web.Exercise2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 64px">
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="btnBRL" runat="server" onclick="btnBRL_Click" Text="BRL" />
        <asp:Button ID="btnUSD" runat="server" Text="USD" onclick="btnUSD_Click" />
        <asp:Button ID="btnGBP" runat="server" Text="GBP" onclick="btnGBP_Click" />
        <br />
        <asp:Label ID="lblFormattedMoney" runat="server" />    
    </div>
    </form>
</body>
</html>
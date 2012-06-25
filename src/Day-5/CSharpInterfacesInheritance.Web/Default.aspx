<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="CSharpClasses.Web._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Beer information:</h2>
    <p>
        Name:
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </p>
    <p>
        Initial Weight:
        <asp:TextBox ID="txtInitialWeight" runat="server"></asp:TextBox>
    </p>
    <p>
        Weight to drink:
        <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
        <asp:Button ID="btnOpenAndDrink" runat="server" OnClick="btnOpenAndDrink_Click" Text="Open and Drink" />
    </p>
    <p>
        <asp:Label ID="lblErrors" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblResult" runat="server" Text="" Visible="false" ForeColor="Green"></asp:Label>
    </p>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">
            www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
</asp:Content>

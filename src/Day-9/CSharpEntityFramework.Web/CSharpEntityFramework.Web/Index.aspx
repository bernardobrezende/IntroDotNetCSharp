<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CSharpEntityFramework.Web.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    Digite seu nome: <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
    <asp:Button ID="btnSetUser" runat="server" Text="OK" 
        onclick="btnSetUser_Click" />
</asp:Content>

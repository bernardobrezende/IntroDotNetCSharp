<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DrinkBeer.aspx.cs" Inherits="CSharpEntityFramework.Web.DrinkBeer" %>

<%@ Register src="UserControls/ucBeerList.ascx" tagname="ucBeerList" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Drink Beer
    </h2>
    <h2>
        <uc1:ucBeerList ID="ucBeerList1" runat="server" />
    </h2>    
</asp:Content>

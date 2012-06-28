<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FavoriteBeers.aspx.cs" Inherits="CSharpEntityFramework.Web.FavoriteBeers" %>

<%@ Register TagName="BeerList" TagPrefix="uc" Src="~/UserControls/ucBeerList.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        My Favorite Beers
    </h2>
    <uc:BeerList ID="ucBeerList" runat="server" />
    <asp:Button ID="btnAddToFavorites" runat="server" Text="Add To Favorites" 
        onclick="btnAddToFavorites_Click" />
    <asp:ListBox ID="lbFavorites" runat="server"></asp:ListBox>
</asp:Content>
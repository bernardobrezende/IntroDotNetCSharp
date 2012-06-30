<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="FavoriteBeers.aspx.cs" Inherits="TweetBeer.Web.FavoriteBeers" %>

<%@ Register TagName="BeerList" TagPrefix="uc" Src="../UserControls/ucBeerList.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <h2>
        My Favorite Beers
    </h2>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <uc:BeerList ID="ucBeerList" runat="server" />
            <asp:Button ID="btnAddToFavorites" runat="server" Text="Add To Favorites" OnClick="btnAddToFavorites_Click" />
            <asp:ListBox ID="lbFavorites" runat="server"></asp:ListBox>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

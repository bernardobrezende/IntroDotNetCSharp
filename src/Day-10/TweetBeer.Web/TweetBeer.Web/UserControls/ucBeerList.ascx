<%@ Control Language="C#" AutoEventWireup="true" 
CodeBehind="ucBeerList.ascx.cs" Inherits="TweetBeer.Web.UserControls.ucBeerList" %>

<asp:DropDownList ID="ddlBeerList" runat="server">
</asp:DropDownList>
<asp:Label runat="server" ID="lblError" 
    ForeColor="Red" Visible="false" Text="No Beer available."></asp:Label>
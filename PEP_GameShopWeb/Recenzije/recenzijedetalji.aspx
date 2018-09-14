<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="recenzijedetalji.aspx.cs" Inherits="PEP_GameShopWeb.Recenzije.recenzijedetalji" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <div class="ord">

        <asp:Label ID="Labeldatum" runat="server" Text="Datum"></asp:Label>&nbsp &nbsp &nbsp &nbsp &nbsp <asp:Label ID="Labelautor" CssClass="aut" runat="server" Text="Autor"></asp:Label>
        <br />
        <asp:Label ID="datum" runat="server" Text=""></asp:Label>&nbsp
        <asp:Label ID="autor" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="naslov" runat="server" Font-Bold="true" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="sadrzaj" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>

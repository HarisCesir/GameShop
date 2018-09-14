<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="zahtjeviDetalji.aspx.cs" Inherits="PEP_GameShopWeb.Zahtjevi.zahtjeviDetalji" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="ord">
        <div class="right">
        <asp:Label ID="Label5" CssClass="nabavka" runat="server" Font-Bold="true" Text="POTREBNO JOŠ:"></asp:Label><br />
        <asp:Label ID="pglasova" runat="server" CssClass="potrebnoglasova" Text=""></asp:Label><br />
        <asp:Label ID="Label7" runat="server" CssClass="glasova" Font-Bold="true" Text="GLASOVA"></asp:Label><br />
            </div>
        <asp:Label ID="Label1" Font-Bold="true" runat="server" Text="Naziv:"></asp:Label><br />
        <asp:Label ID="naziv" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Label2" Font-Bold="true" runat="server" Text="Vrijeme zahtjeva:"></asp:Label><br />
        <asp:Label ID="datum" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Label3" Font-Bold="true" runat="server" Text="Autor zahtjeva:"></asp:Label><br />
        <asp:Label ID="autor" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="Label4" Font-Bold="true" runat="server" Text="Broj glasova:"></asp:Label><br />
        <asp:Label ID="glasovi" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="glasaj" runat="server" Text="Glasaj" OnClick="glasaj_Click" /><br />
        <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

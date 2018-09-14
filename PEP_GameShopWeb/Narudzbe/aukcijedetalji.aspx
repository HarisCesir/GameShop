<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="aukcijedetalji.aspx.cs" Inherits="PEP_GameShopWeb.Narudzbe.aukcijedetalji" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <div class="ord">


        <asp:Image CssClass="imageAukcija" ID="Image1" runat="server" />
        <asp:Label ID="LabelN" runat="server" Font-Bold="true" Text="Naslov:"></asp:Label><br />
        <asp:Label ID="LabelNaslov" runat="server" Text=""></asp:Label><br />
        
        <asp:Label ID="LabelPo" runat="server" Font-Bold="true" Text="Početak aukcije"></asp:Label><br />
        <asp:Label ID="LabelPočetak" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="LabelKr" runat="server" Font-Bold="true" Text="Kraj aukcije"></asp:Label><br />
        <asp:Label ID="LabelKraj" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="LabelSlika" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="LabelTr" runat="server" Font-Bold="true" Text="Ponuda"></asp:Label><br />
        <asp:Label ID="LabelTrenutna" runat="server" Text=""></asp:Label><label>KM</label><br />
        

        
    </div>
</asp:Content>

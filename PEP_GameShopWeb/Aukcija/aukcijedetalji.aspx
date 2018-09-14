<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="aukcijedetalji.aspx.cs" Inherits="PEP_GameShopWeb.Aukcija.aukcijedetalji" %>
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
        <asp:Label ID="LabelPoc" runat="server" Font-Bold="true" Text="Početna cijena"></asp:Label><br />
        <asp:Label ID="LabelPocetna" runat="server" Text=""></asp:Label><label>KM</label><br />
        <asp:Label ID="LabeTr" runat="server" Font-Bold="true" Text="Trenutna cijena"></asp:Label><br />
        <asp:Label ID="LabelTrenutna" runat="server" Text=""></asp:Label><label>KM</label><br />
        <asp:Label ID="LabelDodaj" runat="server" Font-Bold="true" Text="Ponudi:"></asp:Label><br />
        <asp:TextBox ID="TextBoxDodaj" CssClass="inputCijena" runat="server" TextMode="Number"></asp:TextBox><asp:Label ID="Label1" runat="server" Text="KM"></asp:Label><br />
        <asp:Button ID="ButtonDodaj" runat="server" Text="Dodaj" OnClick="ButtonDodaj_Click" /><br />
        <asp:Label ID="error" Visible="false" runat="server" Text="Vaša ponuda mora biti veća od trenutne"></asp:Label>

        
    </div>
</asp:Content>

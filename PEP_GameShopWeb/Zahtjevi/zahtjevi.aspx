<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="zahtjevi.aspx.cs" Inherits="PEP_GameShopWeb.Zahtjevi.zahtjevi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="ord">

        <asp:Label ID="Label1" runat="server" Font-Bold="true" Text="Ako u našem katalogu ne možete naći igricu koja vam treba, možete dodati vaš zahtjev ovdje, svi zahtjevi koji budu imali 20 glasova će se dodati u katalog!"></asp:Label><br />
        <asp:Label ID="LabelZahtjev" runat="server" Text="Zahtjev:"></asp:Label>
        <asp:TextBox ID="TextBoxZahtjev" runat="server"></asp:TextBox>

        <asp:Button ID="ButtonDodaj" runat="server" Text="Dodaj novi zahtjev" OnClick="ButtonDodaj_Click" />
        <asp:Label ID="zahtjevError" runat="server" Text=""></asp:Label><br />
        
        <asp:DataGrid runat="server" AutoGenerateColumns="False" ID="zahtjeviGrid" AllowPaging="True" AllowCustomPaging="True" DataKeyField="ZahtjeviID" PageSize="30" OnPageIndexChanged="zahtjeviGrid_PageIndexChanged"> <PagerStyle Mode="NumericPages" />
            <Columns>
                <asp:TemplateColumn HeaderText="Zahtjev">
                <ItemTemplate>
                    <asp:HyperLink ID="detalji" runat="server" NavigateUrl='<%#string.Format("zahtjevidetalji.aspx?id={0}",Eval("ZahtjeviID"))%>'><%#Eval("Naslov") %> </asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateColumn>
                
                <asp:BoundColumn DataField="Datum" HeaderText="Datum"></asp:BoundColumn>
                <asp:BoundColumn DataField="Ime" HeaderText="Autor"></asp:BoundColumn>
            </Columns>
        </asp:DataGrid>
        </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="orders.aspx.cs" Inherits="PEP_GameShopWeb.Narudzbe.orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <div class="ord">
    <asp:DataGrid ID="narudzbeGrid" runat="server" AutoGenerateColumns="false" DataKeyField="IgraID" Width="233px" OnItemCommand="narudzbeGrid_ItemCommand">

        <Columns>
            
            <asp:BoundColumn DataField="Igre" HeaderText="Igre"></asp:BoundColumn>
            <asp:BoundColumn DataField="Kolicina" HeaderText="Količina"></asp:BoundColumn>

            <asp:TemplateColumn>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="obrisi">Obriši</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateColumn>
        </Columns>

    </asp:DataGrid>
    <br />
    <label>Iznos računa: </label>
    <asp:Label ID="racun" runat="server" Text=""></asp:Label> KM<br />
        <asp:Button ID="Button1" runat="server" Text="Naruči" OnClick="Button1_Click" />
        </div>
</asp:Content>

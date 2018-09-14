<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="PEP_GameShopWeb.Narudzbe.history" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <div class="hist">
       
        <asp:Label ID="Label5" runat="server" Font-Bold="true" Text="Aukcije:"></asp:Label><br />
    
    <asp:DataGrid ID="aukcije" runat="server" CssClass="aukcije" AutoGenerateColumns="False" AllowPaging="True" DataKeyField="AukcijeID" AllowCustomPaging="True" PageSize="5" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" OnPageIndexChanged="aukcije_PageIndexChanged" >
        <Columns>
            
            <asp:TemplateColumn HeaderText="Igra">
                <ItemTemplate>
                    <asp:HyperLink ID="aukcijedetalji" runat="server" NavigateUrl='<%#string.Format("aukcijedetalji.aspx?id={0}",Eval("AukcijeID"))%>'><%#Eval("Naziv") %> </asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateColumn> 
            <asp:BoundColumn DataField="DatumOD" HeaderText="Početak aukcije"></asp:BoundColumn>
            <asp:BoundColumn DataField="DatumDO" HeaderText="Kraj Aukcije"></asp:BoundColumn>


            
            
             
        </Columns>
        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" />
        <PagerStyle Mode="NumericPages" />
    </asp:DataGrid>
        <asp:Label ID="Label1" Font-Bold="true" CssClass="labelHistory" runat="server" Text="Narudžbe:"> </asp:Label> <asp:Label ID="Label2" CssClass="racunLeft" Font-Bold="true" runat="server" Text="Račun:"></asp:Label> <br />
    <asp:DropDownList ID="DropDownListHistory" AutoPostBack="true" CssClass="labelHistory" runat="server" Height="36px" OnSelectedIndexChanged="DropDownListHistory_SelectedIndexChanged" Width="186px"></asp:DropDownList> <asp:Label ID="Label3" CssClass="racun" runat="server" Text=""></asp:Label><asp:Label ID="Label4" runat="server" Text="KM"></asp:Label>
    <asp:GridView ID="historija" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Naziv" HeaderText="Igra" />
            <asp:BoundField DataField="Cijena" HeaderText="Cijena" />
            <asp:BoundField DataField="Kolicina" HeaderText="Količina" />
        </Columns>
        </asp:GridView>
        
        </div>
</asp:Content>

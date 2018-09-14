<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="aukcija.aspx.cs" Inherits="PEP_GameShopWeb.Aukcija.aukcija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="ord">
    <asp:DataGrid ID="GridAukcije" runat="server" AutoGenerateColumns="False" AllowPaging="True" DataKeyField="AukcijeID" AllowCustomPaging="True" PageSize="20" OnPageIndexChanged="GridAukcije_PageIndexChanged" >
        <Columns>
            
            <asp:TemplateColumn HeaderText="Igra">
                <ItemTemplate>
                    <asp:HyperLink ID="aukcijedetalji" runat="server" NavigateUrl='<%#string.Format("aukcijedetalji.aspx?id={0}",Eval("AukcijeID"))%>'><%#Eval("Naziv") %> </asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateColumn> 
            <asp:BoundColumn DataField="DatumOD" HeaderText="Početak aukcije"></asp:BoundColumn>
            <asp:BoundColumn DataField="DatumDO" HeaderText="Kraj Aukcije"></asp:BoundColumn>


            
            
             
        </Columns>
        <PagerStyle Mode="NumericPages" />

        
        

    </asp:DataGrid>

    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="recenzije.aspx.cs" Inherits="PEP_GameShopWeb.Recenzije.recenzije" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   <div class="ord">
    <asp:DataGrid ID="GridRecenzije" runat="server" AutoGenerateColumns="False" AllowPaging="True" DataKeyField="RecenzijaID" AllowCustomPaging="True" PageSize="20" OnPageIndexChanged="GridRecenzije_PageIndexChanged" >
        <Columns>
             
            <asp:BoundColumn DataField="ImePrezime" HeaderText="Autor"></asp:BoundColumn>
            <asp:BoundColumn DataField="Datum" HeaderText="Datum"></asp:BoundColumn>
           
            <asp:TemplateColumn HeaderText="Igra">
                <ItemTemplate>
                    <asp:HyperLink ID="recenzijedetalji" runat="server" NavigateUrl='<%#string.Format("recenzijedetalji.aspx?id={0}",Eval("RecenzijaID"))%>'><%#Eval("Naziv") %> </asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateColumn>


            
            
             
        </Columns>
        <PagerStyle Mode="NumericPages" />

        
        

    </asp:DataGrid>

    </div>

</asp:Content>

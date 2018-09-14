<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="PEP_GameShopWeb.Proizvodi.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="detalji">
    <table>
        <tr>
            <td>
                <asp:Image ID="Slika" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="naziv" runat="server" style="font-weight:bold;" Text="Label">Naziv Igre:</asp:Label><br />
                <asp:Label ID="lblNaziv" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="datum" runat="server" style="font-weight:bold;" Text="Label">Datum Izdavanja:</asp:Label><br />
                <asp:Label ID="lblDatumIzdavanja" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="izdavac" runat="server" style="font-weight:bold;" Text="Label">Izdavac:</asp:Label><br />
                <asp:Label ID="lblIzdavac" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
             <asp:Label ID="Laabel" runat="server" style="font-weight:bold;" Text="Label">Vrsta:</asp:Label><br />

                <asp:Label ID="lblVrsta" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblOpis" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                               

                <asp:Label ID="lblCijena" CssClass="lblCijena" runat="server"></asp:Label>
                
            </td>
        </tr>
        
        <tr>
            <td>
               
                  
               
                <iframe runat="server" width="420" height="315" id="video" frameborder="0"></iframe>
                
                
            </td>
        </tr>
        <tr>
            <td>
               <asp:DropDownList ID="Ocjena" runat="server">
                        <asp:ListItem Text="1" Value="1"></asp:ListItem>
                        <asp:ListItem Text="2" Value="2"></asp:ListItem>
                        <asp:ListItem Text="3" Value="3"></asp:ListItem>
                        <asp:ListItem Text="4" Value="4"></asp:ListItem>
                        <asp:ListItem Text="5" Value="5" Selected="True"></asp:ListItem>
                    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="dodajOcjenu" runat="server" Text="Ocjeni" OnClick="dodajOcjenu_Click" />
                <br />
                <asp:Button ID="btnDodajUKorpu" runat="server" OnClick="btnDodajUKorpu_Click" Text="Dodaj u korpu" />
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Labelerror" runat="server" Text="" CssClass="Labelerror"></asp:Label>
            </td>
        </tr>
    </table>
        

    <h5 runat="server" id="prepo">Preporučeni proizvodi</h5>
    
        <asp:DataGrid ID="ItemBasedPreporukaGrid" runat="server" AllowPaging="True" AllowCustomPaging="True" PageSize="4"
         AutoGenerateColumns="False" Height="187px"  Width="849px"  
        DataKeyField="IgraID" OnItemCommand="ItemBasedPreporukaGrid_ItemCommand" OnItemDataBound="ItemBasedPreporukaGrid_ItemDataBound" OnPageIndexChanged="ItemBasedPreporukaGrid_PageIndexChanged"  > 
        <PagerStyle Mode="NumericPages" />


        <Columns>
             
             <asp:TemplateColumn>
                 <ItemTemplate>
                     <asp:Image ID="thumbImage" runat="server" />
                 </ItemTemplate>
             </asp:TemplateColumn>
             <asp:TemplateColumn HeaderText="Naziv">
                <ItemTemplate>
                    
                    <asp:HyperLink ID="detalji" runat="server" NavigateUrl='<%#string.Format("ProductDetails.aspx?id={0}",Eval("IgraID"))%>'><%#Eval("Naziv") %> </asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateColumn>
            
           
            <asp:BoundColumn DataField="Šifra" HeaderText="Šifra"></asp:BoundColumn>
             <asp:BoundColumn DataField="Cijena" HeaderText="Cijena"></asp:BoundColumn>
            
             <asp:TemplateColumn> 
                 <ItemTemplate>
                     
                     <asp:LinkButton ID="LinkButton1" runat="server" CommandName="dodajUKorpu">Dodaj u korpu</asp:LinkButton>

                 </ItemTemplate>
             </asp:TemplateColumn>
         </Columns>
    </asp:DataGrid>
    </div>
</asp:Content>


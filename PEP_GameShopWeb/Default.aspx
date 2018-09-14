<%@ Page Title="Početna" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PEP_GameShopWeb._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
     
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="proizvodiHome">
    <h3>Katalog Proizvoda:</h3>
    
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Vrsta"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Naziv"></asp:Label>
            </td>
         
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="VrstaList" runat="server" DataTextField="Naziv" DataValueField="VrstaID"></asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Pretraži" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    <br />

    <asp:DataGrid ID="proizvodiGrid" runat="server" AutoGenerateColumns="False" AllowPaging="True" AllowCustomPaging="True" PageSize="5" OnItemDataBound="proizvodiGrid_ItemDataBound" DataKeyField="IgraID" OnItemCommand="proizvodiGrid_ItemCommand" OnPageIndexChanged="proizvodiGrid_PageIndexChanged">  <PagerStyle Mode="NumericPages" />

        <Columns>
            <asp:TemplateColumn>
                <ItemTemplate>
                    <asp:Image ID="ThumbImage" runat="server" />
                </ItemTemplate>
            </asp:TemplateColumn>

            <asp:TemplateColumn>
                <ItemTemplate>
                    <asp:Image ID="AukcijaSlika" runat="server" />
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Naziv">
                <ItemTemplate>
                    
                    <asp:HyperLink ID="detalji" runat="server" NavigateUrl='<%#string.Format("Proizvodi/ProductDetails.aspx?id={0}",Eval("IgraID"))%>'><%#Eval("Naziv") %> </asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateColumn>
            
           
            <asp:BoundColumn DataField="Šifra" HeaderText="Šifra"></asp:BoundColumn>
            <asp:BoundColumn DataField="Cijena" HeaderText="Cijena"></asp:BoundColumn>

            <asp:TemplateColumn>
                <ItemTemplate>
                   
                     <asp:LinkButton ID="LinkButton1" runat="server" CommandName="dodajUKorpu">Dodaj u korpu</asp:LinkButton>
                   
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn>
                <ItemTemplate>
                        <asp:CheckBox ID="aukcijac" runat="server" />
                    </ItemTemplate>
            </asp:TemplateColumn>
        </Columns>

    </asp:DataGrid>
    
    </div>
</asp:Content>

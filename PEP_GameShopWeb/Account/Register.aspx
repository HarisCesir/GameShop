<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PEP_GameShopWeb.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Registracija</h1>

    </hgroup>

    
                    

                    <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>

                    <fieldset>
                        <legend>Registracija</legend>
                        <ol>
                             <li>
                                <asp:Label ID="Label1" runat="server" AssociatedControlID="imeInput">Ime</asp:Label>
                                <asp:TextBox runat="server" ID="imeInput" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="imeInput"
                                    CssClass="field-validation-error" ErrorMessage="Ime je obavezno." />
                            </li>
                            <li>
                                <asp:Label ID="Label2" runat="server" AssociatedControlID="prezimeInput">Prezime</asp:Label>
                                <asp:TextBox runat="server" ID="prezimeInput" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="prezimeInput"
                                    CssClass="field-validation-error" ErrorMessage="Prezime je obavezno." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="korisnickoIme">Korisničko ime</asp:Label>
                                <asp:TextBox runat="server" ID="korisnickoIme" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="korisnickoIme"
                                    CssClass="field-validation-error" ErrorMessage="Korisničko ime je obavezno." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Email">Email addresa</asp:Label>
                                <asp:TextBox runat="server" ID="Email" TextMode="Email" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                    CssClass="field-validation-error" ErrorMessage="E-mail adresa je obavezna." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="Password">Lozinka</asp:Label>
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                    CssClass="field-validation-error" ErrorMessage="Lozinka je obavezna." />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Potvrda lozinke</asp:Label>
                                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Potvrdite lozinku." />
                                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Niste unijeli istu lozinku." />
                            </li>
                        </ol>
                        <asp:Button ID="registracijaSubmit" runat="server"  Text="Registuj se" OnClick="Unnamed10_Click" />
                        
                    </fieldset>
             
</asp:Content>
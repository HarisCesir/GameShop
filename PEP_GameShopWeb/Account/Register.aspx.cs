using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;
using Services.Data;
using Services.Util;
using Services;
namespace PEP_GameShopWeb.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed10_Click(object sender, EventArgs e)
        {
            Kupci kupac = new Kupci();
            kupac.Ime = imeInput.Text;
            kupac.Prezime = prezimeInput.Text;
            kupac.DatumRegistracije = DateTime.Now;
            kupac.Email = Email.Text;
            kupac.KorisnickoIme = korisnickoIme.Text;
            kupac.LozinkaSalt = Services.Util.UiHelper.GenerateSalt();
            kupac.LozinkaHash = Services.Util.UiHelper.GenerateHash(Password.Text, kupac.LozinkaSalt);

            DBKupci.KupciInsert(kupac);
            
        }
    }
}
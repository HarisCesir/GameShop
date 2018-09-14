using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services.Data;
namespace PEP_GameShopWeb.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            

            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void loginbox_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Kupci kupac = DBKupci.SelectByKorisnickoIme(loginbox.UserName, loginbox.Password);
            try
            {
                if (kupac == null)
                {
                    loginbox.FailureText = "Korisnik sa unesenim podatcima ne postoji";
                    e.Authenticated = false;
                }
                else
                {
                    e.Authenticated = true;
                }
            }
            catch (Exception ex)
            {

                loginbox.FailureText = ex.Message;
                    e.Authenticated = false;
            }
        }
    }
}
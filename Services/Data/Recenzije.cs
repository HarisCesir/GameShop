//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Services.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recenzije
    {
        public int RecenzijaID { get; set; }
        public System.DateTime Datum { get; set; }
        public string Sadrzaj { get; set; }
        public int KorisnikID { get; set; }
        public int IgraID { get; set; }
    
        public virtual Korisnici Korisnici { get; set; }
        public virtual Igre Igre { get; set; }
    }
}

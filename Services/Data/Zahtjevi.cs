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
    
    public partial class Zahtjevi
    {
        public Zahtjevi()
        {
            this.ZahtjeviKupci = new HashSet<ZahtjeviKupci>();
        }
    
        public int ZahtjeviID { get; set; }
        public string Naslov { get; set; }
        public System.DateTime Datum { get; set; }
        public int KupacID { get; set; }
    
        public virtual Kupci Kupci { get; set; }
        public virtual ICollection<ZahtjeviKupci> ZahtjeviKupci { get; set; }
    }
}

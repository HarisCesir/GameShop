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
    
    public partial class Dobavljaci
    {
        public Dobavljaci()
        {
            this.Ulaz = new HashSet<Ulaz>();
        }
    
        public int DobavljacID { get; set; }
        public string Naziv { get; set; }
        public string KontaktOsoba { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string ZiroRacun { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual ICollection<Ulaz> Ulaz { get; set; }
    }
}
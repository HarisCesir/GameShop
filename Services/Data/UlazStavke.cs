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
    
    public partial class UlazStavke
    {
        public int UlazStavkeID { get; set; }
        public int UlazID { get; set; }
        public int IgraID { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
    
        public virtual Igre Igre { get; set; }
        public virtual Ulaz Ulaz { get; set; }
    }
}
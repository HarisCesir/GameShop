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
    
    public partial class Izdavaci
    {
        public Izdavaci()
        {
            this.Igre = new HashSet<Igre>();
        }
    
        public int IzdavacID { get; set; }
        public string Ime { get; set; }
    
        public virtual ICollection<Igre> Igre { get; set; }
    }
}

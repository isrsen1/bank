//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login
{
    using System;
    using System.Collections.Generic;
    
    public partial class Izvor_imovine
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double Vrijednost { get; set; }
        public string Tip { get; set; }
        public Nullable<int> Bilanca_id { get; set; }
        public string Kategorija { get; set; }
    
        public virtual Bilanca Bilanca { get; set; }
    }
}

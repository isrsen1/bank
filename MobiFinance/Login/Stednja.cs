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
    
    public partial class Stednja
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public double Glavnica { get; set; }
        public int RokOrocenja { get; set; }
        public Nullable<double> KonačanIznos { get; set; }
        public Nullable<int> Vrsta_id { get; set; }
        public Nullable<double> Kamate { get; set; }
        public Nullable<int> Klijent_id { get; set; }
        public Nullable<int> Zaposlenik_id { get; set; }
        public Nullable<double> RKS { get; set; }
    
        public virtual Klijent Klijent { get; set; }
        public virtual VrstaStednje VrstaStednje { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
    }
}

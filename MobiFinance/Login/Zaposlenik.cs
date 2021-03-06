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
    
    public partial class Zaposlenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaposlenik()
        {
            this.Kredit_ = new HashSet<Kredit_>();
            this.Stednjas = new HashSet<Stednja>();
        }
    
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public string KorisnickoIme { get; set; }
        public Nullable<int> Tip_id { get; set; }
        public static Zaposlenik PrijavljeniKorisnik;
        public string Lozinka { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kredit_> Kredit_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stednja> Stednjas { get; set; }
        public virtual Tip_zaposlenika Tip_zaposlenika { get; set; }

        public Zaposlenik(int _id,string _ime,string _prezime,string _email,string _adresa,string _brojTelefona,string _korisnickoIme,int _tipId,string _lozinka) {
            Id = _id;
            Ime = _ime;
            Prezime = _prezime;
            Email = _email;
            Adresa = _adresa;
            BrojTelefona = _brojTelefona;
            KorisnickoIme = _korisnickoIme;
            Tip_id = _tipId;
            Lozinka = _lozinka;
        }
    }
}

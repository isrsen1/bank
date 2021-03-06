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
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Klijent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klijent()
        {
            this.Bilancas = new HashSet<Bilanca>();
            this.Kredit_ = new HashSet<Kredit_>();
            this.Račun = new HashSet<Račun>();
            this.Stednjas = new HashSet<Stednja>();
        }
    
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public Nullable<double> Primanja { get; set; }
        public string Tip_klijenta { get; set; }
        public string Adresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilanca> Bilancas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kredit_> Kredit_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Račun> Račun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stednja> Stednjas { get; set; }

        /// <summary>
        /// Metoda za dohvaćanje svih klijenata iz baze podataka
        /// </summary>
        /// <returns></returns>
        public BindingList<Klijent> DohvatiKorisnike()
        {

            BindingList<Klijent> lista = null;
            using (BankaEntities db = new BankaEntities())
            {
                lista = new BindingList<Klijent>(db.Klijents.SqlQuery("Select *from klijent").ToList());
            }
            return lista;
        }
        /// <summary>
        /// Metoda za generiranje pdf417 barcoda prema perdlošku
        /// </summary>
        /// <param name="cijena"></param>
        /// <returns></returns>
        public string GenerirajPodatkeZaBarKod(string cijena) {
            string kod = "";
           
            kod += "HRVHUB30";
            kod += Environment.NewLine+"HRK";
            kod += Environment.NewLine+cijena+Environment.NewLine;
            kod += this.Ime+" "  + this.Prezime+Environment.NewLine;
            kod +=this.Adresa;
            kod += Environment.NewLine+Environment.NewLine+ "Zagrebacka banka d.d" + Environment.NewLine + "Trg bana Josipa Jelacica 10 10000 Zagreb";
            kod +=Environment.NewLine+ "HR01"+Environment.NewLine+"OTLC"+Environment.NewLine+ "20556629-4";
            kod += Environment.NewLine + "Ukupan iznos za kreditnu ratu";
            return kod;
        }
        /// <summary>
        /// metoda za uređivanje anuitetea kredta pogodan za 15-znamenkasti zapis
        /// </summary>
        /// <param name="anuitet"></param>
        /// <returns></returns>
        public string UrediCijenu(double anuitet)
        {
            string novacijena = "";
            string cijena = ((anuitet).ToString()).Replace(".", "");
            for (int i = 0; i < 15-cijena.Length; i++)
            {
                novacijena += "0";
            }
            novacijena += cijena;
            return novacijena;

        }

    }
}

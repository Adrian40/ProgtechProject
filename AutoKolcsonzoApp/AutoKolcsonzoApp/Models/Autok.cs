//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoKolcsonzoApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Autok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Autok()
        {
            this.Kolcsonzeseks = new HashSet<Kolcsonzesek>();
        }
    
        public int AutoID { get; set; }
        public string Marka { get; set; }
        public string Rendszam { get; set; }
        public string Szin { get; set; }
        public Nullable<int> UlesekSzama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kolcsonzesek> Kolcsonzeseks { get; set; }
    }
}

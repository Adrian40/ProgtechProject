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
    
    public partial class Vevok
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vevok()
        {
            this.Kolcsonzeseks = new HashSet<Kolcsonzesek>();
        }
    
        public int VevoID { get; set; }
        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }
        public string TelefonSzam { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kolcsonzesek> Kolcsonzeseks { get; set; }
    }
}
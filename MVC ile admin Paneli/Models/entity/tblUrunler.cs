//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_ile_admin_Paneli.Models.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUrunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUrunler()
        {
            this.tblSatis = new HashSet<tblSatis>();
        }
    
        public int urunId { get; set; }
        public string urunAd { get; set; }
        public string urunMarka { get; set; }
        public Nullable<decimal> urunAlisFiyat { get; set; }
        public Nullable<decimal> urunSatisFiyat { get; set; }
        public Nullable<int> urunKategori { get; set; }
        public Nullable<bool> urunDurumu { get; set; }
        public Nullable<int> toplamStok { get; set; }
        public Nullable<int> kalanStok { get; set; }
    
        public virtual tblKategori tblKategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSatis> tblSatis { get; set; }
    }
}
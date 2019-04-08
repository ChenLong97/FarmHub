namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MASS_UNIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MASS_UNIT()
        {
            FARMER_PREFERENCE_DETAIL = new HashSet<FARMER_PREFERENCE_DETAIL>();
            PURCHASE_OFFER_DETAIL = new HashSet<PURCHASE_OFFER_DETAIL>();
            SALE_OFFER_DETAIL = new HashSet<SALE_OFFER_DETAIL>();
        }

        [Key]
        public int Id_MassUnit { get; set; }

        [StringLength(10)]
        public string Name_MassUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FARMER_PREFERENCE_DETAIL> FARMER_PREFERENCE_DETAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PURCHASE_OFFER_DETAIL> PURCHASE_OFFER_DETAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALE_OFFER_DETAIL> SALE_OFFER_DETAIL { get; set; }
    }
}

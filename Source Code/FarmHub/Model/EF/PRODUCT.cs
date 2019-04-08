namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCT")]
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            FARM_DETAIL = new HashSet<FARM_DETAIL>();
            FARMER_PREFERENCE_DETAIL = new HashSet<FARMER_PREFERENCE_DETAIL>();
            MARKET_TRANS_HIS = new HashSet<MARKET_TRANS_HIS>();
            PURCHASE_OFFER_DETAIL = new HashSet<PURCHASE_OFFER_DETAIL>();
            SALE_OFFER_DETAIL = new HashSet<SALE_OFFER_DETAIL>();
            TRANSACTION_ORDER = new HashSet<TRANSACTION_ORDER>();
        }

        [Key]
        public int Id_Product { get; set; }

        public int? Id_Crop { get; set; }

        public int? Id_Classification { get; set; }

        public int? Id_Seed { get; set; }

        public int? Id_ProductKind { get; set; }

        [StringLength(50)]
        public string Name_Product { get; set; }

        [StringLength(50)]
        public string Geography_Location { get; set; }

        [StringLength(200)]
        public string Image_Product { get; set; }

        public bool? Is_Deleted { get; set; }

        public virtual CLASSIFICATION CLASSIFICATION { get; set; }

        public virtual CROP CROP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FARM_DETAIL> FARM_DETAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FARMER_PREFERENCE_DETAIL> FARMER_PREFERENCE_DETAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MARKET_TRANS_HIS> MARKET_TRANS_HIS { get; set; }

        public virtual PRODUCT_KIND PRODUCT_KIND { get; set; }

        public virtual SEED SEED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PURCHASE_OFFER_DETAIL> PURCHASE_OFFER_DETAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALE_OFFER_DETAIL> SALE_OFFER_DETAIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACTION_ORDER> TRANSACTION_ORDER { get; set; }
    }
}

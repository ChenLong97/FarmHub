namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PURCHASE_OFFER_DETAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PURCHASE_OFFER_DETAIL()
        {
            TRANSACTION_ORDER = new HashSet<TRANSACTION_ORDER>();
        }

        [Key]
        public int Id_PurchaseOfferDetail { get; set; }

        public int? Id_PurchasesOffer { get; set; }

        public int? Id_Product { get; set; }

        public int? Id_MassUnit { get; set; }

        public int? Price_PurchaseOfferDetail { get; set; }

        public int? Quantity_PurchaseOfferDetail { get; set; }

        public byte? Status_PurchaseOfferDetail { get; set; }

        public bool? Is_Deleted { get; set; }

        public virtual MASS_UNIT MASS_UNIT { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }

        public virtual PURCHASE_OFFER PURCHASE_OFFER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACTION_ORDER> TRANSACTION_ORDER { get; set; }
    }
}

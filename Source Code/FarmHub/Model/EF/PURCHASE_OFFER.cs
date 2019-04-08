namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PURCHASE_OFFER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PURCHASE_OFFER()
        {
            PURCHASE_OFFER_DETAIL = new HashSet<PURCHASE_OFFER_DETAIL>();
        }

        [Key]
        public int Id_PurchasesOffer { get; set; }

        public int? Id_Trader { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_PurchaseOffer { get; set; }

        public int? Price_Purchase { get; set; }

        public int? Quantity_Purchase { get; set; }

        public int? Remain_PurchaseQuality { get; set; }

        public byte? Status_PurchaseOffer { get; set; }

        public bool? Is_Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PURCHASE_OFFER_DETAIL> PURCHASE_OFFER_DETAIL { get; set; }

        public virtual TRADER TRADER { get; set; }
    }
}

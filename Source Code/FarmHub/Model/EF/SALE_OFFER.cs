namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SALE_OFFER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SALE_OFFER()
        {
            SALE_OFFER_DETAIL = new HashSet<SALE_OFFER_DETAIL>();
        }

        [Key]
        public int Id_SaleOffer { get; set; }

        public int? Id_Farm { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_SaleOffer { get; set; }

        public int? Price_Offer { get; set; }

        public int? Quantity_Offer { get; set; }

        public int? Remain_SellQuantity { get; set; }

        public byte Status_SaleOffer { get; set; }

        public bool? Is_Deleted { get; set; }

        public virtual FARM FARM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALE_OFFER_DETAIL> SALE_OFFER_DETAIL { get; set; }
    }
}

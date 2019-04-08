namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRANSACTION_ORDER
    {
        [Key]
        public int Id_TransactionOrder { get; set; }

        public int? Id_SaleOfferDetail { get; set; }

        public int? Id_PurchaseOfferDetail { get; set; }

        public int? Id_Product { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Transaction_Date { get; set; }

        public int? Transaction_Mass { get; set; }

        public int? Transaction_Price { get; set; }

        public byte? Status_TransactionOrder { get; set; }

        public bool? Is_Deleted { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }

        public virtual PURCHASE_OFFER_DETAIL PURCHASE_OFFER_DETAIL { get; set; }

        public virtual SALE_OFFER_DETAIL SALE_OFFER_DETAIL { get; set; }
    }
}

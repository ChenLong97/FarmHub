namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MARKET_TRANS_HIS
    {
        [Key]
        public int Id_MarketTransHis { get; set; }

        public int? Id_Product { get; set; }

        [StringLength(50)]
        public string City_Market { get; set; }

        public int? Average_TransPrice { get; set; }

        public int? Average_OfferPrice { get; set; }

        public int? Average_PurchasePrice { get; set; }

        public int? Product_SupplyQuantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? From_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? To_Date { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }
    }
}

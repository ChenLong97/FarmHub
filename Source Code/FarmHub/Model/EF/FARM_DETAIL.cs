namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FARM_DETAIL
    {
        [Key]
        public int Id_FarmDetail { get; set; }

        public int? Id_Farm { get; set; }

        public int? Id_Product { get; set; }

        public bool? Is_Deleted { get; set; }

        public virtual FARM FARM { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }
    }
}

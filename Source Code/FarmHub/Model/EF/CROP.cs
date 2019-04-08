namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CROP")]
    public partial class CROP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CROP()
        {
            PRODUCTs = new HashSet<PRODUCT>();
        }

        [Key]
        public int Id_Crop { get; set; }

        [StringLength(50)]
        public string Name_Crop { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Start_Time { get; set; }

        [Column(TypeName = "date")]
        public DateTime? End_Time { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Harvest_StartTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Harvest_EndTime { get; set; }

        public int? Quantity_Expected { get; set; }

        public bool? Is_Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTs { get; set; }
    }
}

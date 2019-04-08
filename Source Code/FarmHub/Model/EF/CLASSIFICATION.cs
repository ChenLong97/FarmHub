namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLASSIFICATION")]
    public partial class CLASSIFICATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLASSIFICATION()
        {
            PRODUCTs = new HashSet<PRODUCT>();
        }

        [Key]
        public int Id_Classification { get; set; }

        [StringLength(50)]
        public string Name_Classification { get; set; }

        [StringLength(50)]
        public string Packing_Specifications { get; set; }

        [StringLength(50)]
        public string Color_Classification { get; set; }

        public int? Weight_Classification { get; set; }

        [StringLength(50)]
        public string Size_Classification { get; set; }

        public bool? Is_Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTs { get; set; }
    }
}

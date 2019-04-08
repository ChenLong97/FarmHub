namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_KIND
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER_KIND()
        {
            USER_AUTHENTICATION = new HashSet<USER_AUTHENTICATION>();
        }

        [Key]
        public int Id_UserKind { get; set; }

        [StringLength(50)]
        public string Name_UserKind { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_AUTHENTICATION> USER_AUTHENTICATION { get; set; }
    }
}

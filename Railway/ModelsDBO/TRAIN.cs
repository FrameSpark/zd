namespace Railway
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRAIN")]
    public partial class TRAIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRAIN()
        {
            TRAIN_COMPOSITION = new HashSet<TRAIN_COMPOSITION>();
            TRIPs = new HashSet<TRIP>();
        }

        [Key]
        public int id_train { get; set; }

        [Required]
        [StringLength(255)]
        public string number_train { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAIN_COMPOSITION> TRAIN_COMPOSITION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIP> TRIPs { get; set; }
    }
}

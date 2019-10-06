namespace Railway
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRAIN_TYPE
    {
        [Key]
        public int id_train { get; set; }

        [Required]
        [StringLength(255)]
        public string type_train { get; set; }
    }
}

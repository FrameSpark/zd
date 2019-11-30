namespace Railway
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRAIN_COMPOSITION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_composition { get; set; }

        public int id_train { get; set; }

        public int id_carriage { get; set; }


        public virtual CARRIAGE CARRIAGE { get; set; }

        public virtual TRAIN TRAIN { get; set; }
    }
}

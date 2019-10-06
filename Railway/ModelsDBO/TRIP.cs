namespace Railway
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRIP")]
    public partial class TRIP
    {
        [Key]
        public int id_trip { get; set; }

        public int id_train { get; set; }

        public int id_ticket { get; set; }

        [Required]
        [StringLength(255)]
        public string status { get; set; }

        public DateTime time_start { get; set; }

        public DateTime time_finish { get; set; }

        public int id_route { get; set; }

        public virtual ROUTE ROUTE { get; set; }

        public virtual TICKET TICKET { get; set; }

        public virtual TRAIN TRAIN { get; set; }
    }
}

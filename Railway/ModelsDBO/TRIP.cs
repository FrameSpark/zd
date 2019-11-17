namespace Railway
{
    using Railway.Forms;
    using Railway.Models;
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

        [Required]
        [StringLength(255)]
        public string status { get; set; }

        public DateTime time_start { get; set; }

        public DateTime time_finish { get; set; }

       public int id_route { get; set; }

    }
}

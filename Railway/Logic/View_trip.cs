namespace Railway.Logic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_trip
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string number_train { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string name_station { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Expr1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_trip { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime time_start { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime time_finish { get; set; }
    }
}

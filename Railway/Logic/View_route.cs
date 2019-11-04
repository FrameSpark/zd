namespace Railway.Logic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_route
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int route_time { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_route { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string name_station { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string Expr1 { get; set; }
    }
}

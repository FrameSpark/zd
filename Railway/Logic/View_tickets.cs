namespace Railway.Logic
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_tickets
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_ticket { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_passanger { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string number_train { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_carriage { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int price { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(255)]
        public string name_station { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(255)]
        public string Expr1 { get; set; }
    }
}

namespace Railway
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TICKET")]
    public partial class TICKET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TICKET()
        {
           // TRIPs = new HashSet<TRIP>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_ticket { get; set; }

        public int id_passanger { get; set; }

        public int id_train { get; set; }

        public int id_carriage { get; set; }

        public DateTime timeP { get; set; }

        public int price { get; set; }

        public int id_station { get; set; }

        public int id_trip { get; set; }
          public virtual CARRIAGE CARRIAGE { get; set; }

         public virtual PASSANGER PASSANGER { get; set; }

       /*  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
          public virtual ICollection<TRIP> TRIPs { get; set; }*/
    }
}

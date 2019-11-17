using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Railway
{
    [Table("TripRoutes")]
    public partial class TripRoutes
    {
        public int IdTrip { get; set; }
        public int IdRoute { get; set; }
        [Key]
        public int id { get; set; }
    }
}

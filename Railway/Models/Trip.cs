using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Models
{
    class Trip
    {
        public List<Route> routes { get; set; }
        public int id_trip { get; set; }

        public int id_train { get; set; }

        public string number_train { get; set; }

        public string status { get; set; }

        public DateTime time_start { get; set; }

        public DateTime time_finish { get; set; }

        public int id_route { get; set; }

        public string start_station { get; set; }
        public string finish_station { get; set; }
    }
}

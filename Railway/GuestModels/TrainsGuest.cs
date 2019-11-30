using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.GuestModels
{
    class TrainsGuest
    {
        public int id_train { get; set; }
        public string number_train { get; set; }
        public string start { get; set; }
        public string finish { get; set; }
        public string type { get; set; }

        public DateTime time_start { get; set; }
        public DateTime time_fiinish { get; set; }       
        public double time { get; set; }
    }
}

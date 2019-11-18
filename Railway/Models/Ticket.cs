using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Models
{
    class Ticket
    {
        public int id_ticket { get; set; }

        public int id_passanger { get; set; }

        public string name { get; set; }

        public string number_train { get; set; }

        public DateTime time { get; set; }

        public string start { get; set; }
        public string finish { get; set; }

        public string station { get; set; }

        public int id_train { get; set; }

        public int id_carriage { get; set; }

        public int price { get; set; }

        public int id_trip { get; set; }
    }
}

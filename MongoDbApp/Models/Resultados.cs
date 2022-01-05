using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Models
{
    public class Resultados
    {
        public string idEquipo { get; set; }
        public string idEncuentroDeportivo { get; set; }
        public string idArbitro { get; set; }
        public int resultado { get; set; }
    }
}

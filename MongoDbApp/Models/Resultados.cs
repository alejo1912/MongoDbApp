using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Models
{
    public class Resultados
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string idEquipo { get; set; }
        public string idEncuentroDeportivo { get; set; }
        
        public int resultado { get; set; }
    }
}

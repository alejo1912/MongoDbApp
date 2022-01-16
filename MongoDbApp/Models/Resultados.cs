using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MongoDbApp.Models
{
    public class Resultados: ReadOnlyResultados
    {
        public string idEquipo { get; set; }
        public string idDeportista { get; set; }
        public int goles { get; set; }
    }

    public class ReadOnlyResultados 
    {
        [BsonIgnore]
        public string equipo { get; set; }

        [BsonIgnore]
        public string deportista { get; set; }
    }
}

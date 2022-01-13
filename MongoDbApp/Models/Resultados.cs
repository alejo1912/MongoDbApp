using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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
        public string idDeportista { get; set; }

        public int goles { get; set; }

        public DateTime fecha { get; set; }
    }
}

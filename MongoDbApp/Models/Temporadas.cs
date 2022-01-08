using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Models
{
    public class Temporadas
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string Temporada { get; set; }
        public DateTime fecha { get; set; }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Models
{
    public class Equipos
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string nombreEquipo { get; set; }
    }
}

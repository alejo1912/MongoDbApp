using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MongoDbApp.Models
{
    public class EncuentrosDeportivos
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string temporada { get; set; }

        public string idEquipoA { get; set; }
        public string idEquipoB { get; set; }

        public string idArbitro { get; set; }

        /// <summary>
        /// fecha registro
        /// </summary>
        public DateTime fecha { get; set; }
    }
}

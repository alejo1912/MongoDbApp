using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MongoDbApp.Models
{
    public class EncuentrosDeportivos: ReadOnlyEncuentrosDeportivos
    {
        [BsonId]
        public ObjectId id { get; set; }

        public string encuentro { get; set; }
        public string idTemporada { get; set; }
        public string idEquipoA { get; set; }
        public string idEquipoB { get; set; }
        public string idArbitro { get; set; }
        public DateTime fecha { get; set; }

        public List<Resultados> listResultados { get; set; }
    }
    public class ReadOnlyEncuentrosDeportivos
    {
        [BsonIgnore]
        public string idTex { get; set; }

        [BsonIgnore]
        public string fechaTex { get; set; }

        [BsonIgnore]
        public string Temporada { get; set; }

        [BsonIgnore]
        public string EquipoA { get; set; }

        [BsonIgnore]
        public string EquipoB { get; set; }

        [BsonIgnore]
        public string Arbitro { get; set; }
    }
}

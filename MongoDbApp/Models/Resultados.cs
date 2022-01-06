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

        public string idEncuentrosDeportivo { get; set; }
        public string idEquipo { get; set; }

        public int golesAFavor { get; set; }//GF
        public int golesEnContra { get; set; }//GC
        public int puntos { get; set; }//Pts

        public bool gano { get; set; }
        public bool empate { get; set; }
        public bool perdio { get; set; }

        /// <summary>
        /// fecha registro
        /// </summary>
        public DateTime fecha { get; set; }
    }
}

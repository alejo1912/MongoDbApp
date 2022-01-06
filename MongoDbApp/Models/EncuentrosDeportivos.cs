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

        public string idEquipo { get; set; }

        public string idArbitro { get; set; }

        public int golesAFavor { get; set; }//GF
        public int golesEnContra { get; set; }//GC
        public int puntos { get; set; }//Pts

        /// <summary>
        /// fecha registro
        /// </summary>
        public DateTime fecha { get; set; }
    }
}

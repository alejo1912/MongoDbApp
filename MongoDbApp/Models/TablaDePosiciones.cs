using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Models
{
    public class TablaDePosiciones
    {
        [BsonId]
        public ObjectId id { get; set; }

        /// <summary>
        /// Nombre juados
        /// </summary>
        public string temporada { get; set; }

        /// <summary>
        /// numero camiseta
        /// </summary>
        public int equipo { get; set; }

        /// <summary>
        /// fecha registro
        /// </summary>
        public DateTime fecha { get; set; }

        public bool gano { get; set; }
        public bool empate { get; set; }
        public bool perdio { get; set; }

        public int partidosJugado { get; set; }//PJ
        public int ganados { get; set; }//G
        public int perdidos { get; set; }//P
        public int golesAFavor { get; set; }//GF
        public int golesEnContra { get; set; }//GC
        public int dg { get; set; }//DG
        public int puntos { get; set; }//Pts
    }
}

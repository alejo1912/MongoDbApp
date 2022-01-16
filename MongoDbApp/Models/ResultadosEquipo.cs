using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Models
{
    public class ResultadosEquipo
    {
        public string equipo { get; set; }
        public int golesAFavor { get; set; }
        public int golesEnContra { get; set; }
        public bool gano { get; set; }
        public bool empate { get; set; }
    }
}

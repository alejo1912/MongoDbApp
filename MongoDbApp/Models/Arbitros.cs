using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Models
{
    public class Arbitros
    {
        [BsonId]
        public ObjectId id { get; set; }

        /// <summary>
        /// Nombre juados
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// fecha registro
        /// </summary>
        public DateTime fecha { get; set; }
    }
}

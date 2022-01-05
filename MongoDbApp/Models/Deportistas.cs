using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Models
{
    public class Deportistas
    {
        public string _id { get; set; }

        /// <summary>
        /// Nombre juados
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// numero camiseta
        /// </summary>
        public int numero { get; set; }

        /// <summary>
        /// posision en el area de juego ejemplo: DC defensa central
        /// </summary>
        public string posision { get; set; }

        /// <summary>
        /// identificacion del jugador
        /// </summary>
        public string documento { get; set; }

        /// <summary>
        /// id automatico de la tabla de equipos
        /// </summary>
        public string idEquipo { get; set; }
    }
}

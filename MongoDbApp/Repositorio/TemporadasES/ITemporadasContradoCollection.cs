using MongoDbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.TemporadasES
{
    public class ITemporadasContradoCollection
    {
        Task InsertTemporadas(Temporadas entidad);
        Task<List<Temporadas>> GetListTemporadas();
    }
}

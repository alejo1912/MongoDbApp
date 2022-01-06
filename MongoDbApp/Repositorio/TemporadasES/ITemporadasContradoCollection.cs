using MongoDbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.TemporadasES
{
    public class ITemporadasContradoCollection
    {
        Task InsertTemporada(Temporadas entidad);
        Task UpdateTemporada(Temporadas entidad);
        Task DeleteTemporada(string id);

        Task<List<Temporadas>> GetListTemporadas();
        Task<Temporadas> GetTemporadaById(string id);
    }
}

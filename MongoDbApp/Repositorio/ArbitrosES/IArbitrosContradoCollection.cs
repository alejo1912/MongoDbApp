using MongoDbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.ArbitrosES
{
    public interface IArbitrosContradoCollection
    {
        Task InsertArbitro(Arbitros entidad);
        Task UpdateArbitro(Arbitros entidad);
        Task DeleteArbitro(string id);

        Task<List<Arbitros>> GetListArbitross();
        Task<Arbitros> GetArbitroById(string id);
    }
}

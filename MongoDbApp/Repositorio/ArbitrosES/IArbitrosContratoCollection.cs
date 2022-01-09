using MongoDbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.ArbitrosES
{
    public interface IArbitrosContratoCollection
    {
        Task InsertArbitro(Arbitros entidad);
        Task UpdateArbitro(Arbitros entidad);
        Task DeleteArbitro(string id);

        Task<List<Arbitros>> GetListArbitros();
        Task<Arbitros> GetArbitroById(string id);
    }
}

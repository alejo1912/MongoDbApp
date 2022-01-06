using MongoDbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.DeportistasES
{
    public interface IDeportistasContratoCollection
    {
        Task InsertDeportistas(Deportistas jugador);
        Task UpdateDeportistas(Deportistas jugador);
        Task DeleteDeportistas(string id);

        Task<List<Deportistas>> GetListDeportistas();
        Task<Deportistas> GetDeportistasById(string id);
    }
}

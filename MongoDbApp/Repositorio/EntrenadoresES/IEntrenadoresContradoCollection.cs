using MongoDbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.EntrenadoresES
{
    public interface IEntrenadoresContradoCollection
    {
        Task InsertEntrenador(Entrenadores entidad);
        Task UpdateEntrenador(Entrenadores entidad);
        Task DeleteEEntrenador(string id);

        Task<List<Entrenadores>> GetListEntrenadores();
        Task<Entrenadores> GetEntrenadoreById(string id);
    }
}

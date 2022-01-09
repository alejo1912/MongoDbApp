using MongoDbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.EntrenadoresES
{
    public interface IEntrenadoresContratoCollection
    {
        Task InsertEntrenador(Entrenadores entidad);
        Task UpdateEntrenador(Entrenadores entidad);
        Task DeleteEntrenador(string id);

        Task<List<Entrenadores>> GetListEntrenadores();
        Task<Entrenadores> GetEntrenadorById(string id);
    }
}

using MongoDbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.EquiposES
{
    public interface IEquiposContradoCollection
    {
        Task InsertEquipo(Equipos entidad);
        Task UpdateEquipo(Equipos entidad);
        Task DeleteEquipo(string id);

        Task<List<Equipos>> GetListEquipos();
        Task<Equipos> GetEquiposById(string id);
    }
}

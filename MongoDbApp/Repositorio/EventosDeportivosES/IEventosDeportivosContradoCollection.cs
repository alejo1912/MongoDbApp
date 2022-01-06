using MongoDbApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.EventosDeportivosES
{
    public interface IEventosDeportivosContradoCollection
    {
        #region EncuentrosDeportivos
        Task InsertEncuentrosDeportivo(EncuentrosDeportivos entidad);
        Task UpdateEncuentrosDeportivo(EncuentrosDeportivos entidad);
        Task DeleteEncuentrosDeportivo(string id);

        Task<List<EncuentrosDeportivos>> GetListEncuentrosDeportivos();
        Task<EncuentrosDeportivos> GetEncuentrosDeportivoById(string id);
        #endregion

        #region Resultados
        Task InsertResultado(Resultados entidad);
        Task UpdateResultado(Resultados entidad);
        Task DeleteResultado(string id);

        Task<List<Resultados>> GetListResultados();
        Task<Resultados> GetResultadoById(string id);
        #endregion

        #region Reportes
        /// <summary>
        /// Obtiene los resultados de los encuentros entre equipos 
        /// </summary>
        /// <param name="busqueda"></param>
        /// <returns></returns>
        Task<List<TablaDePosiciones>> GetListTablaDePosicionesSmart(string busqueda);
        #endregion
    }
}

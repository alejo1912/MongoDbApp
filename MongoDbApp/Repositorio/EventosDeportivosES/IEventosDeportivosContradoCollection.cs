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

        /// <summary>
        /// crea un nuevo evento deportivo
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        Task InsertEncuentrosDeportivo(EncuentrosDeportivos entidad);

        /// <summary>
        /// modifica un evento deportivo existente
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        Task UpdateEncuentrosDeportivo(EncuentrosDeportivos entidad);

        /// <summary>
        /// elimina un evento deportivo existente de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteEncuentrosDeportivo(string id);

        /// <summary>
        /// obtine todos los eventos deportivos creados
        /// </summary>
        /// <returns></returns>
        Task<List<EncuentrosDeportivos>> GetListEncuentrosDeportivos();

        /// <summary>
        /// obtiene un evento deportivo segun su _id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

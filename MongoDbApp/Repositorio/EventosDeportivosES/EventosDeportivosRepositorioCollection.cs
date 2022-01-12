using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbApp.Models;
using MongoDbApp.Models.ModelDbConexion;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.EventosDeportivosES
{
    public class EventosDeportivosRepositorioCollection : IEventosDeportivosContradoCollection
    {
        internal MongoDBRepository _repository = new MongoDBRepository();
        private IMongoCollection<EncuentrosDeportivos> collectinEncuentrosDeportivos;
        private IMongoCollection<Resultados> collectinResultados;
        public EventosDeportivosRepositorioCollection()
        {
            // si no encuentra la collection crea una nueva
            collectinEncuentrosDeportivos = _repository.db.GetCollection<EncuentrosDeportivos>("EncuentrosDeportivos");
            collectinResultados = _repository.db.GetCollection<Resultados>("Resultados");
        }

        #region EncuentrosDeportivos
        public async Task<EncuentrosDeportivos> GetEncuentrosDeportivoById(string id)
        {
            EncuentrosDeportivos encuentros = new EncuentrosDeportivos();
            try
            {
                encuentros = await collectinEncuentrosDeportivos.FindAsync(new BsonDocument { { "_id", new ObjectId(id) } }).Result.FirstAsync();
            }
            catch (Exception e)
            {
                return encuentros;
            }
            return encuentros;
        }

        public async Task<List<EncuentrosDeportivos>> GetListEncuentrosDeportivos()
        {
            return await collectinEncuentrosDeportivos.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task InsertEncuentrosDeportivo(EncuentrosDeportivos entidad)
        {
            //var builder = Builders<EncuentrosDeportivos>.Update.Set(x => x.id, entidad.id);

            //foreach (PropertyInfo prop in entidad.GetType().GetProperties())
            //{
            //    var value = entidad.GetType().GetProperty(prop.Name).GetValue(entidad, null);

            //    if (prop.Name != "id")
            //    {
            //        if (value != null)
            //        {
            //            builder = builder.Set(prop.Name, value);
            //        }
            //        else
            //        {
            //            builder = builder.Unset(prop.Name);
            //        }

            //    }
            //}
            //var filter = Builders<EncuentrosDeportivos>.Filter;
            //var filter_def = filter.Eq(x => x.id, entidad.id);


            //await collectinEncuentrosDeportivos.InsertOneAsync(filter_def, entidad, new ReplaceOptions { IsUpsert = true });

            entidad.fecha = DateTime.Now;
            await collectinEncuentrosDeportivos.InsertOneAsync(entidad);
        }

        public async Task UpdateEncuentrosDeportivo(EncuentrosDeportivos entidad)
        {
            var builder = Builders<EncuentrosDeportivos>.Update.Set(x => x.id, entidad.id);

            foreach (PropertyInfo prop in entidad.GetType().GetProperties())
            {
                var value = entidad.GetType().GetProperty(prop.Name).GetValue(entidad, null);

                if (prop.Name != "id")
                {
                    if (value != null)
                    {
                        builder = builder.Set(prop.Name, value);
                    }
                    else
                    {
                        builder = builder.Unset(prop.Name);
                    }

                }
            }

            var filter = Builders<EncuentrosDeportivos>.Filter;
            var filter_def = filter.Eq(x => x.id, entidad.id);

            await collectinEncuentrosDeportivos.UpdateOneAsync(filter_def, builder);


            //var filtro = Builders<EncuentrosDeportivos>.Filter.Eq(x => x.id, entidad.id);
            //entidad.fecha = DateTime.Now;
            //await collectinEncuentrosDeportivos.ReplaceOneAsync(filtro, entidad);
        }

        public async Task DeleteEncuentrosDeportivo(string id)
        {
            var filtro = Builders<EncuentrosDeportivos>.Filter.Eq(x => x.id, new MongoDB.Bson.ObjectId(id));
            await collectinEncuentrosDeportivos.DeleteOneAsync(filtro);
        }
        #endregion


        #region Resultados
        public async Task DeleteResultado(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Resultados>> GetListResultados()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Resultados> GetResultadoById(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task InsertResultado(Resultados entidad)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateResultado(Resultados entidad)
        {
            throw new System.NotImplementedException();
        }
        #endregion


        #region TablaDePosiciones
        public async Task<List<TablaDePosiciones>> GetListTablaDePosicionesSmart(string busqueda)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}

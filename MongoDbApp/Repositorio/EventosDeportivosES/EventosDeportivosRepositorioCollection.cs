using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using MongoDbApp.Models;
using MongoDbApp.Models.ModelDbConexion;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.EventosDeportivosES
{
    public class EventosDeportivosRepositorioCollection : IEventosDeportivosContradoCollection
    {
        CultureInfo culture = new CultureInfo("en-US", true);
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
             var eventos = await collectinEncuentrosDeportivos.FindAsync(new BsonDocument()).Result.ToListAsync();

            foreach (var item in eventos)
            {
                item.idTex = item.id.ToString();
                item.fechaTex = item.fecha.ToString("yyyy-MM-dd", culture);
            }
            return eventos;
        }

        public async Task<EncuentrosDeportivos> InsertEncuentrosDeportivo(EncuentrosDeportivos entidad)
        {
            entidad.fecha = DateTime.Now;
            await collectinEncuentrosDeportivos.InsertOneAsync(entidad);

            entidad.idTex = entidad.id.ToString();
            entidad.fechaTex = entidad.fecha.ToString("yyyy-MM-dd", culture);

            if (!string.IsNullOrWhiteSpace(entidad.idTex)&& entidad.idTex!= "000000000000000000000000")
            {
                var x =_repository.db.GetCollection<EncuentrosDeportivos>("EncuentrosDeportivos");

            }

            return entidad;
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

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbApp.Models;
using MongoDbApp.Models.ModelDbConexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbApp.Repositorio.DeportistasES
{
    public class DeportistasRepositorioCollection : IDeportistasContratoCollection
    {
        internal MongoDBRepository _repository = new MongoDBRepository();
        private IMongoCollection<Deportistas> collectin;
        public DeportistasRepositorioCollection() 
        {
            collectin = _repository.db.GetCollection<Deportistas>("Deportistas");
        }
        public async Task DeleteDeportistas(string id)
        {
            var filtro = Builders<Deportistas>.Filter.Eq(x=>x.id,new MongoDB.Bson.ObjectId(id));
            await collectin.DeleteOneAsync(filtro);
        }

        public async Task<Deportistas> GetDeportistasById(string id)
        {
            return await collectin.FindAsync(
                new BsonDocument { { "_id", new ObjectId(id)}}).Result.FirstAsync();
        }

        public async Task<List<Deportistas>> GetListDeportistas()
        {
            return await collectin.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task InsertDeportistas(Deportistas jugador)
        {
            await collectin.InsertOneAsync(jugador);
        }

        public async Task UpdateDeportistas(Deportistas jugador)
        {
            var filtro = Builders<Deportistas>.Filter.Eq(x => x.id, jugador.id);
            await collectin.ReplaceOneAsync(filtro,jugador);
        }
    }
}

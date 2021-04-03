using ConsoleApp2.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{


    public class MongoDbRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly IMongoDatabase database;
        private IMongoCollection<TEntity> Collection => database.GetCollection<TEntity>(typeof(TEntity).Name);

        public MongoDbRepository()
        {
            var dbClient = new MongoClient("__ADD__HERE__");
            database = dbClient.GetDatabase("CarDealership");
        }

        public void Insert(TEntity entity)
        {
            Collection.InsertOne(entity);
        }

        public TEntity GetById(Guid Id)
        {
            return Collection.Find(e => e.Id == Id).SingleOrDefault();
        }

        public IEnumerable<TEntity> GetByAll()
        {
            return Collection.Find(e => true).ToEnumerable();
        }

        public void Delete(TEntity entity)
        {
            Collection.DeleteOne(e => e.Id == entity.Id);
        }

        public void Update(TEntity entity)
        {
            Collection.ReplaceOne(e => e.Id == entity.Id, entity);
        }
    }
}

using App.Models;
using MongoDB.Driver;
using System;

namespace App
{
    public sealed class DBContext : IDisposable
    {
        private readonly IMongoDatabase _database;

        public DBContext()
        {
            var client = new MongoClient("mongodb+srv://vikashchauhan:Welcome123@cluster0-msoki.mongodb.net/test?retryWrites=true&w=majority");
            if (client != null)
                _database = client.GetDatabase("microbloggers");
        }

        public IMongoCollection<SignUpModel> Users => _database.GetCollection<SignUpModel>("Users");

         public IMongoCollection<OrderModel> Orders => _database.GetCollection<OrderModel>("Orders");

        public void Dispose()
        {

        }
    }
}
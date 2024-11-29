using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDbOrder.Services
{
	public class MongoDbConnection
	{
		private IMongoDatabase _database;

		public MongoDbConnection()
		{
			var client = new MongoClient("mongodb://localhost:27017");// server yolunu tanımlıyoruz
			_database = client.GetDatabase("Db9ProjectOrder"); // veri tabanı varsa seçer yoksa oluştuğu zaman alacağı ismi veriyoruz
		}
		//BsonDocument = mongodb'de kullanılan format 
		public IMongoCollection<BsonDocument> GetOrdersCollection() // tablo oluşturmamızı sağlayan metod tanımlıyoruz
		{
			return _database.GetCollection<BsonDocument>("Orders"); // Tablo ismini tanımlama yöntemi
		}
	}
}

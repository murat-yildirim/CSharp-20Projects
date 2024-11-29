using MongoDB.Bson;
using MongoDB.Driver;
using Project9_MongoDbOrder.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Project9_MongoDbOrder.Services
{
	public class OrderOperation
	{
		public void AddOrder(Order order)
		{
			var connection = new MongoDbConnection(); // bağlantının olduğu adrese gidiyor
			var orderCollection = connection.GetOrdersCollection(); // tablomuza erişim sağlıyoruz

			var document = new BsonDocument // burada her bir dökümanı koleksiyon öğesini tek tek atama yapıcaz
			{
				{"CustomerName",order.CustomerName },
				{"City",order.City },
				{"District",order.District },
				{"TotalPrice",order.TotalPrice }

			};
			orderCollection.InsertOne(document); // ekleme işlemi için kullanılıyor
		}

		public List<Order> GetAllOrders()
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();

			var orders = orderCollection.Find(new BsonDocument()).ToList(); // hafıza tuttuğumuz verileri

			List<Order> orderList = new List<Order>(); //Listeye aktarıp
			foreach (var order in orders) // Datagrid'e göndermek için döngü kullanıyoruz
			{
				orderList.Add(new Order
				{
					City = order["City"].ToString(),
					CustomerName = order["CustomerName"].ToString(),
					District = order["District"].ToString(),
					OrderId = order["_id"].ToString(),
					TotalPrice = order["TotalPrice"].AsDecimal
				});
			}
			return orderList;
		}

		public void DeleteOrder(string orderId)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id",ObjectId.Parse( orderId));
			orderCollection.DeleteOne(filter);
		}

		public void UpdateOrder(Order order)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
			var updatedValue = Builders<BsonDocument>.Update
				.Set("CustomerName", order.CustomerName)
				.Set("District", order.District)
				.Set("City", order.City)
				.Set("TotalPrice", order.TotalPrice);
			orderCollection.UpdateOne(filter, updatedValue);
		}

		public Order GetORderById(string orderId)
		{
			var connection = new MongoDbConnection();	
			var orderCollection = connection.GetOrdersCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
			var result = orderCollection.Find(filter).FirstOrDefault();
			if(result!=null)
			{
				return new Order
				{
					City = result["City"].ToString(),
					CustomerName = result["CustomerName"].ToString(),
					District = result["District"].ToString(),
					OrderId=orderId,
					TotalPrice = decimal.Parse(result["TotalPrice"].ToString())
				};
			}
			else
			{
				return null;
			}
		}

	}
}

using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace MongoDBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new MongoClient(
                "mongodb+srv://davidfico22:davidfico22@cluster0.mrtwa.mongodb.net/test");

            var db = client.GetDatabase("sample_mflix");

            var collection = db.GetCollection<BsonDocument>("movies");

            var result = collection.Find("{title:'The Princess Bride'}").FirstOrDefault();

            Console.WriteLine(result);
        }
    }
}

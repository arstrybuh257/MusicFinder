using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MuzicFinder
{
    class SongContext
    {
        IMongoDatabase database;
        

        public SongContext()
        {
            string connectionString = "mongodb://localhost:27017"; // адрес сервера
            MongoClient client = new MongoClient(connectionString);
            database = client.GetDatabase("MucicFinderDB");
            var collection = database.GetCollection<Song>("Music");
        }

        public IMongoCollection<Song> Songs
        {
            get { return database.GetCollection<Song>("Music"); }
        }

        public void Insert(Song s)
        {
            if (s.File!="")Songs.InsertOne(s);
        }

       

    }
}

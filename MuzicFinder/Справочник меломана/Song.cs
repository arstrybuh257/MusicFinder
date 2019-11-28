using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MuzicFinder
{
    public class Song
    {
        public ObjectId _id { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Album { get; set; }
        public string Year { get; set; }
        public string Country { get; set; }
        public string File { get; set; }
        public string Image { get; set; }
    }
}
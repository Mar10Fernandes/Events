using Events.Infrastructure.Database;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Domain.Entities
{
    [MongoCollectionName("peoples")]
    public sealed class Event
    {
        [BsonRequired()]
        [BsonId()]
        public ObjectId Id { get; set; }

        [BsonRequired()]
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonRequired()]
        [BsonElement("created")]
        public DateTime Created { get; set; }

        [BsonRequired()]
        [BsonElement("value")]
        public double Value { get; set; }

        [BsonRequired()]
        [BsonElement("active")]
        public bool Active { get; set; }
    }
}


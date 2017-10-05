using System;
using System.Runtime.InteropServices;

namespace Events.Infrastructure.Database
{
    [AttributeUsage(AttributeTargets.Class)]
    [ComVisible(true)]
    public class MongoCollectionName: Attribute
    {
        public string TableName { get; private set; }
        public MongoCollectionName(string TableName)
        {
            this.TableName = TableName;
        }
    }
}

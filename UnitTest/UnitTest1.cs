using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PredictHq.Services;
using PredictHq.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            DataService service = new DataService();
            IList<Event> result = await service.GetEvents("Lisbon");
        }
    }
}

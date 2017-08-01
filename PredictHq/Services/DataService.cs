using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using PredictHq.Entities;
//using System.Net.Http.Formatting;

namespace PredictHq.Services
{
    class DataService
    {


        //public async Task<IList<Event>> GetEvents(string city)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://api.predicthq.com/v1/");
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        // HTTP GET
        //        HttpResponseMessage response = await client.GetAsync($"events/?place='{city}'");
        //        if (response.IsSuccessStatusCode)
        //        {
        //            IList<Event> events = await response.Content.ReadAsAsync<List<Event>>();
        //            Console.WriteLine("{0}\t${1}\t{2}", events.First().title, events.First().description, events.First().location);
        //        }
        //    }
        //}
    }
}

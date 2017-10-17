using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PredictHq
{
    public class ExternalAccess
    {

        public async Task<string> GetEvents(string city)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://api.predicthq.com/v1/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/JSON"));
                    //client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer kladeelPbErvVWhg7Ix3131kAoxfFb");

                    var stringTask = await client.GetStreamAsync($"events/?place='{city}'");

                    // HTTP GET
                    HttpResponseMessage response = await client.GetAsync($"events/?place='{city}'");
                    if (response.IsSuccessStatusCode)
                    {

                        string stringData = response.Content.ReadAsStringAsync().Result;
                        //List<Event> data = JsonConvert.DeserializeObject<List<Event>>(stringData);

                        //var serializer = new DataContractJsonSerializer(typeof(List<Event>));
                        //var repositories = serializer.ReadObject(stringTask) as List<Event>;
                        //IList<Event> events = await response.Content.ReadAsAsync<List<Event>>();
                        //Console.WriteLine("{0}\t${1}\t{2}", events.First().title, events.First().description, events.First().location);
                        return stringData;


                    }

                    return null;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

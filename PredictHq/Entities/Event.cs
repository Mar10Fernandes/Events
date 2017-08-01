using System;
using System.Collections.Generic;
using System.Text;

namespace PredictHq.Entities
{
    class Event
    {
        public int relevance { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string[] labels { get; set; }
        public int rank { get; set; }
        public int duration { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public DateTime updated { get; set; }
        public string timezone { get; set; }
        public float[] location { get; set; }
        public string scope { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public Venues entities { get; set; }
    }

    public class Venues
    {
        public string[] Name { get; set; }

    }
}

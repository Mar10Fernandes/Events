using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntities
{
    public class EventLocation
    {
        public int ID { get; set; }
        public int Country { get; set; } //f key
        public int City { get; set; } //f key
    }
}

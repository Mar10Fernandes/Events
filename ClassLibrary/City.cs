using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntities
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Country { get; set; } //f key
    }
}

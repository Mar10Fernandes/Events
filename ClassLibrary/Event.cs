using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntities
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; } //f key
        public int Rank { get; set; } //f key
        public string Address { get; set; }
        public int City { get; set; } //f key
        public int Country { get; set; } //f key
        public DateTime Time { get; set; }
        

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntities
{
    public class EventRank
    {
        public int ID { get; set; }
        public int EventRanking { get; set; }
    }
}

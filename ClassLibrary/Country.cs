﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataEntities
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

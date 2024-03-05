﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteCreditSuisse.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Risk { get; set; }
        public double Value { get; set; }
        public string ClientSector { get; set; }
        public bool Active { get; set; }
        public bool ValueGreaterThan { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.SearchModels
{
    public class PlaneSearchModel
    {
        public int? Id {  get; set; }
        public string? ModelName {  get; set; }
        public int? EconomPlacesCount {  get; set; }
        public int? BusinessPlacesCount {  get; set; }
    }
}

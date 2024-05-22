using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.SearchModels
{
    public class DirectionSearchModel
    {
        public int? Id { get; set; }
        public string? CountryFrom { get; set; }
        public string? CountryTo { get; set; }
        public string? CityFrom { get; set; }
        public string? CityTo { get; set; }
    }
}

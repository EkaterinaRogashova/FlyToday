using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class DirectionBindingModel : IDirectionModel
    {
        public string CountryFrom { get; set; } = string.Empty;

        public string CountryTo { get; set; } = string.Empty;

        public string CityFrom { get; set; } = string.Empty;

        public string CityTo { get; set; } = string.Empty;

        public int Id { get; set; } 
    }
}

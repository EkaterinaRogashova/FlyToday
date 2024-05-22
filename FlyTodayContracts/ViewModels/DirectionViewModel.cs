using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class DirectionViewModel : IDirectionModel
    {
        [DisplayName("Страна откуда")]
        public string CountryFrom { get; set; } = string.Empty;
        [DisplayName("Страна куда")]
        public string CountryTo { get; set; } = string.Empty;
        [DisplayName("Город откуда")]
        public string CityFrom { get; set; } = string.Empty;
        [DisplayName("Город куда")]
        public string CityTo { get; set; } = string.Empty;

        public int Id { get; set; }
    }
}

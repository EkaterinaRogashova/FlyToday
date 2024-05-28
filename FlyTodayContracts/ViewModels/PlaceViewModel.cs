using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class PlaceViewModel : IPlaceModel
    {
        [DisplayName("Место")]
        public string PlaceName { get; set; } = string.Empty;
        [DisplayName("Рейс")]
        public int FlightId { get; set; }
        [DisplayName("Статус")]
        public bool IsFree { get; set; }
        public int Id { get; set; }
    }
}

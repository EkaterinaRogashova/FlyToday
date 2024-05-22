using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class FlightViewModel : IFlightModel
    {
        [DisplayName("Самолет")]
        public int PlaneId { get; set; }
        [DisplayName("Дата вылета")]
        public DateTime DepartureDate { get; set; }
        [DisplayName("Свободные места")]
        public int FreePlacesCount { get; set; }
        [DisplayName("Направление")]
        public int DirectionId { get; set; }
        [DisplayName("Стоимость эконом")]
        public double EconomPrice { get; set; }
        [DisplayName("Стоимость бизнес")]
        public double BusinessPrice { get; set; }
        [DisplayName("Время в пути")]
        public double TimeInFlight { get; set; }

        public int Id { get; set; }
    }
}

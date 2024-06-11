using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class FlightSubscriberViewModel : IFlightSubscriberModel
    {
        [DisplayName("Рейс")]
        public int FlightId { get; set; }
        [DisplayName("Пользователь")]
        public int UserId { get; set; }
        public int Id { get; set; }
    }
}

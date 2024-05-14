using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.ViewModels
{
    public class BoardingPassViewModel : IBoardingPassModel
    {
        [DisplayName("Рейс")]
        public int TicketId { get; set; }
        [DisplayName("Место")]
        public int PlaceId { get; set; }

        public int Id { get; set; }
    }
}

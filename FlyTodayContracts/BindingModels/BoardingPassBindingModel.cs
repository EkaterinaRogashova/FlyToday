using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class BoardingPassBindingModel: IBoardingPassModel
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int PlaceId { get; set; }
    }
}

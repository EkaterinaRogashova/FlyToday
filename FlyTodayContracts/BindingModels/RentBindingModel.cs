using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class RentBindingModel : IRentModel
    {
        public int FlightId { get; set; }

        public int UserId { get; set; }

        public double Cost { get; set; }

        public int NumberOfBusiness { get; set; }

        public int NumberOfEconomy { get; set; }

        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}

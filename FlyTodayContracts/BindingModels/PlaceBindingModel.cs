using FlyTodayDataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BindingModels
{
    public class PlaceBindingModel : IPlaceModel
    {
        public string Place { get; set; } = string.Empty;

        public int FlightId { get; set; }

        public bool IsFree { get; set; } = true;

        public int Id { get; set; }
    }
}

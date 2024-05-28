using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface IPlaceModel : IId
    {
        string PlaceName { get; }
        int FlightId { get; }
        bool IsFree { get; }
    }
}

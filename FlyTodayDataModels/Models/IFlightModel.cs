using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDataModels.Models
{
    public interface IFlightModel : IId
    {
        int PlaneId { get; }
        DateTime DepartureDate {  get; }
        int FreePlacesCountEconom { get; }
        int FreePlacesCountBusiness { get; }
        int DirectionId { get; }
        double EconomPrice { get; }
        double BusinessPrice { get; }
        double TimeInFlight { get; }
    }
}

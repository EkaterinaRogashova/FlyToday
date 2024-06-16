using FlyTodayDataModels.Enums;

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
        int TimeInFlight { get; }
        FlightStatusEnum FlightStatus { get; }
    }
}

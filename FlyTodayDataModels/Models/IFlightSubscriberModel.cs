namespace FlyTodayDataModels.Models
{
    public interface IFlightSubscriberModel : IId
    {
        int UserId { get; }
        int FlightId { get; }
    }
}

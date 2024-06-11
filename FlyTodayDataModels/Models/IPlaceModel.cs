namespace FlyTodayDataModels.Models
{
    public interface IPlaceModel : IId
    {
        string PlaceName { get; }
        int FlightId { get; }
        bool IsFree { get; }
    }
}

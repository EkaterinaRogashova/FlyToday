namespace FlyTodayDataModels.Models
{
    public interface IPlaneModel : IId
    {
        string ModelName { get; }
        int EconomPlacesCount { get; }
        int BusinessPlacesCount { get; }
        int PlaneSchemeId { get; }
    }
}

namespace FlyTodayDataModels.Models
{
    public interface IPlaneSchemeModel : IId
    {
        public string Name { get; }
        public int BusinessPlacesCount { get; }
        public int EconomPlacesCount { get; }
        public int PlacesInFirstLineEconom { get; }
        public int PlacesInMiddleLineEconom { get; }
        public int PlacesInLastLineEconom { get; }
        public int PlacesInFirstLineBusiness { get; }
        public int PlacesInLastLineBusiness { get; }
    }
}

namespace FlyTodayContracts.SearchModels
{
    public class PlaneSchemeSearchModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? BusinessPlacesCount { get; set; }
        public int? EconomPlacesCount { get; set; }
        public int? PlacesInFirstLineEconom { get; set; }
        public int? PlacesInMiddleLineEconom { get; set; }
        public int? PlacesInLastLineEconom { get; set; }
        public int? PlacesInFirstLineBusiness { get; set; }
        public int? PlacesInLastLineBusiness { get; set; }
    }
}

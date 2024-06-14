using FlyTodayDataModels.Models;

namespace FlyTodayContracts.BindingModels
{
    public class PlaneSchemeBindingModel : IPlaneSchemeModel
    {
        public string Name { get; set; } = string.Empty;

        public int BusinessPlacesCount { get; set; }

        public int EconomPlacesCount { get; set; }

        public int PlacesInFirstLineEconom { get; set; }

        public int PlacesInMiddleLineEconom { get; set; }

        public int PlacesInLastLineEconom { get; set; }

        public int PlacesInFirstLineBusiness { get; set; }

        public int PlacesInLastLineBusiness { get; set; }

        public int Id { get; set; }
    }
}

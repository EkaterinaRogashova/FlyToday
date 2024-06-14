using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyTodayDatabaseImplements.Models
{
    public class PlaneScheme : IPlaneSchemeModel
    {
        [Required]
        public string Name { get; private set; } = string.Empty;
        [Required]
        public int BusinessPlacesCount { get; private set; }
        [Required]
        public int EconomPlacesCount { get; private set; }
        [Required]
        public int PlacesInFirstLineEconom { get; private set; }
        [Required]
        public int PlacesInMiddleLineEconom { get; private set; }
        [Required]
        public int PlacesInLastLineEconom { get; private set; }
        [Required]
        public int PlacesInFirstLineBusiness { get; private set; }
        [Required]
        public int PlacesInLastLineBusiness { get; private set; }
        public int Id { get; private set; }
        [ForeignKey("PlaneSchemeId")]
        public virtual List<Plane> Planes { get; set; } = new();

        public static PlaneScheme? Create(PlaneSchemeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new PlaneScheme()
            {
                Id = model.Id,
                Name = model.Name,
                BusinessPlacesCount = model.BusinessPlacesCount,
                EconomPlacesCount = model.EconomPlacesCount,
                PlacesInFirstLineEconom = model.PlacesInFirstLineEconom,
                PlacesInMiddleLineEconom = model.PlacesInMiddleLineEconom,
                PlacesInLastLineEconom = model.PlacesInLastLineEconom,
                PlacesInFirstLineBusiness = model.PlacesInFirstLineBusiness,
                PlacesInLastLineBusiness = model.PlacesInLastLineBusiness
            };
        }

        public void Update(PlaneSchemeBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            Name = model.Name;
            BusinessPlacesCount = model.BusinessPlacesCount;
            EconomPlacesCount = model.EconomPlacesCount;
            PlacesInFirstLineEconom = model.PlacesInFirstLineEconom;
            PlacesInMiddleLineEconom = model.PlacesInMiddleLineEconom;
            PlacesInLastLineEconom = model.PlacesInLastLineEconom;
            PlacesInFirstLineBusiness = model.PlacesInFirstLineBusiness;
            PlacesInLastLineBusiness = model.PlacesInLastLineBusiness;
        }

        public PlaneSchemeViewModel GetViewModel => new()
        {
            Id = Id,
            Name = Name,
            BusinessPlacesCount = BusinessPlacesCount,
            EconomPlacesCount = EconomPlacesCount,
            PlacesInFirstLineEconom = PlacesInFirstLineEconom,
            PlacesInMiddleLineEconom = PlacesInMiddleLineEconom,
            PlacesInLastLineEconom = PlacesInLastLineEconom,
            PlacesInFirstLineBusiness = PlacesInFirstLineBusiness,
            PlacesInLastLineBusiness = PlacesInLastLineBusiness
        };
    }
}

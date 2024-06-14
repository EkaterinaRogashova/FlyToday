using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyTodayDatabaseImplements.Models
{
    public class Plane : IPlaneModel
    {
        public int Id { get; private set; }
        [Required]
        public string ModelName { get; private set; } = string.Empty;
        [Required]
        public int EconomPlacesCount { get; private set; }
        [Required]
        public int BusinessPlacesCount { get; private set; }
        [Required]
        public int PlaneSchemeId { get; private set; }
        public virtual PlaneScheme PlaneScheme { get; set; }

        public static Plane? Create(PlaneBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Plane()
            {
                Id = model.Id,
                ModelName = model.ModelName,
                EconomPlacesCount = model.EconomPlacesCount,
                BusinessPlacesCount = model.BusinessPlacesCount,
                PlaneSchemeId = model.PlaneSchemeId
            };
        }

        public void Update(PlaneBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            ModelName = model.ModelName;
            EconomPlacesCount = model.EconomPlacesCount;
            BusinessPlacesCount = model.BusinessPlacesCount;
            PlaneSchemeId = model.PlaneSchemeId;
        }

        public PlaneViewModel GetViewModel => new()
        {
            Id = Id,
            ModelName = ModelName,
            EconomPlacesCount = EconomPlacesCount,
            BusinessPlacesCount = BusinessPlacesCount,
            PlaneSchemeId = PlaneSchemeId
        };        
    }
}

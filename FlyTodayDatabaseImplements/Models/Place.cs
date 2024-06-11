using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyTodayDatabaseImplements.Models
{
    public class Place : IPlaceModel
    {
        [Required]
        public int FlightId { get; private set; }
        [Required]
        public bool IsFree { get; private set; }

        public int Id { get; private set; }
        [Required]
        public string PlaceName { get; private set; } = string.Empty;
        [ForeignKey("PlaceId")]
        public List<BoardingPass> BoardingPasses { get; set; } = new();

        public static Place? Create(PlaceBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Place()
            {
                Id = model.Id,
                FlightId = model.FlightId,
                IsFree = model.IsFree,
                PlaceName = model.PlaceName
            };
        }
        public void Update(PlaceBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            IsFree = model.IsFree;
            PlaceName = model.PlaceName;
        }
        public PlaceViewModel GetViewModel => new()
        {
            Id = Id,
            FlightId = FlightId,
            IsFree = IsFree,
            PlaceName = PlaceName
        };
    }
}

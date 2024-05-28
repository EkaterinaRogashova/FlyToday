using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using FlyTodayDataModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyTodayDatabaseImplements.Models
{
    public class Flight : IFlightModel
    {
        public int Id { get; private set; }
        [Required]
        public int PlaneId { get; private set; }
        [Required]
        public DateTime DepartureDate { get; private set; } = DateTime.Now;
        [Required]
        public int FreePlacesCount { get; private set; }
        [Required]
        public int DirectionId { get; private set; }
        [Required]
        public double EconomPrice { get; private set; }
        [Required]
        public double BusinessPrice { get; private set; }
        [Required]
        public double TimeInFlight { get; private set; }
        [ForeignKey("FlightId")]
        public virtual List<Employee> Employees { get; set; } = new();
        public Plane Plane { get; set; }
        public Direction Direction { get; set; }

        public static Flight? Create(FlightBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Flight()
            {
                Id = model.Id,
                PlaneId = model.PlaneId,
                DepartureDate = model.DepartureDate,
                FreePlacesCount = model.FreePlacesCount,
                DirectionId = model.DirectionId,
                EconomPrice = model.EconomPrice,
                BusinessPrice = model.BusinessPrice,
                TimeInFlight = model.TimeInFlight
            };
        }

        public void Update(FlightBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            DepartureDate = model.DepartureDate;
            FreePlacesCount = model.FreePlacesCount;
            EconomPrice = model.EconomPrice;
            BusinessPrice = model.BusinessPrice;
            TimeInFlight = model.TimeInFlight;
        }

        public FlightViewModel GetViewModel => new()
        {
            Id = Id,
            PlaneId = PlaneId,
            DepartureDate = DepartureDate,
            FreePlacesCount = FreePlacesCount,
            DirectionId = DirectionId,
            EconomPrice = EconomPrice,
            BusinessPrice = BusinessPrice,
            TimeInFlight = TimeInFlight
        };
    }
}

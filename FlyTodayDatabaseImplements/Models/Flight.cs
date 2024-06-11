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
        public int FreePlacesCountEconom { get; private set; }
        [Required]
        public int FreePlacesCountBusiness { get; private set; }
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
                FreePlacesCountEconom = model.FreePlacesCountEconom,
                FreePlacesCountBusiness = model.FreePlacesCountBusiness,
                DirectionId = model.DirectionId,
                EconomPrice = model.EconomPrice,
                BusinessPrice = model.BusinessPrice,
                TimeInFlight = model.TimeInFlight
            };
        }

        public void UpdatePlane(FlyTodayDatabase context, FlightBindingModel model)
        {
            Plane plane = context.Planes.First(x => x.Id == model.PlaneId);
            if (plane == null)
            {
                return;
            }
            else
            {
                model.PlaneId = plane.Id;
                Plane = plane;
            }            
        }

        public void UpdateDirection(FlyTodayDatabase context, FlightBindingModel model)
        {
            Direction direction = context.Directions.First(x => x.Id == model.DirectionId);
            if (direction == null)
            {
                return;
            }
            else
            {
                model.DirectionId = direction.Id;
                Direction = direction;
            }
        }

        public void Update(FlightBindingModel model)
        {
            if (model == null)
            {
                return;
            }
            DepartureDate = model.DepartureDate;
            FreePlacesCountEconom = model.FreePlacesCountEconom;
            FreePlacesCountBusiness = model.FreePlacesCountBusiness;
            EconomPrice = model.EconomPrice;
            BusinessPrice = model.BusinessPrice;
            TimeInFlight = model.TimeInFlight;
        }

        public FlightViewModel GetViewModel => new()
        {
            Id = Id,
            PlaneId = PlaneId,
            DepartureDate = DepartureDate,
            FreePlacesCountEconom = FreePlacesCountEconom,
            FreePlacesCountBusiness = FreePlacesCountBusiness,
            DirectionId = DirectionId,
            EconomPrice = EconomPrice,
            BusinessPrice = BusinessPrice,
            TimeInFlight = TimeInFlight
        };
    }
}

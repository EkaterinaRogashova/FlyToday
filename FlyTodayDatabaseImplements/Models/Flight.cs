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
        public virtual Plane Plane { get; set; }
        public virtual Direction Direction { get; set; }
        [ForeignKey("FlightId")]
        public virtual List<FlightSubscriber> Subscribers { get; set; } = new();

        private Dictionary<int, IUserModel>? _flightSubscribers = null;
        [NotMapped]
        public Dictionary<int, IUserModel> FlightSubscribers
        {
            get
            {
                if (_flightSubscribers == null)
                {
                    _flightSubscribers = Subscribers
                        .ToDictionary(rec => rec.UserId, rec => (rec.User as IUserModel));
                }
                return _flightSubscribers;
            }
        }

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

        public void UpdateSubscribers(FlyTodayDatabase context, FlightBindingModel model)
        {
            var flightSubscribers = context.FlightSubscribers.Where(rec => rec.FlightId == model.Id).ToList();
            if (flightSubscribers != null && flightSubscribers.Count > 0)
            { 
                context.FlightSubscribers.RemoveRange(flightSubscribers.Where(rec => !model.FlightSubscribers.ContainsKey(rec.UserId)));
                context.SaveChanges();
                foreach (var updateUser in flightSubscribers)
                {
                    model.FlightSubscribers.Remove(updateUser.UserId);
                }
                context.SaveChanges();
            }
            var flight = context.Flights.First(x => x.Id == Id);
            foreach (var fs in model.FlightSubscribers)
            {
                context.FlightSubscribers.Add(new FlightSubscriber
                {
                    Flight = flight,
                    User = context.Users.First(x => x.Id == fs.Key)
                });
                context.SaveChanges();
            }
            _flightSubscribers = null;
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

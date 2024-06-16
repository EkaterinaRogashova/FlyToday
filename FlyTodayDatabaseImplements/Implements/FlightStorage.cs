using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using FlyTodayDataModels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace FlyTodayDatabaseImplements.Implements
{
    public class FlightStorage : IFlightStorage
    {
        public FlightViewModel? Delete(FlightBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var element = context.Flights
                .Include(x => x.Plane)
                .Include(x => x.Direction)
                .Include(x => x.Subscribers)
                .FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Flights.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public FlightViewModel? GetElement(FlightSearchModel model)
        {
            if (model.FreePlacesCountBusiness == null && model.BusinessPrice == null && model.FreePlacesCountEconom == null && model.EconomPrice == null && model.DirectionId == null && model.DepartureDate == null && !model.Id.HasValue)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            if (model.FlightStatus != null)
            {
                return context.Flights.Include(x => x.Plane)
             .Include(x => x.Direction)
             .Include(x => x.Subscribers)
             .ThenInclude(x => x.User)
             .FirstOrDefault(x => (
            x.FlightStatus == model.FlightStatus) &&
            (model.Id.HasValue && x.Id == model.Id))
            ?.GetViewModel;
            }

            return context.Flights
             .Include(x => x.Plane)
             .Include(x => x.Direction)
             .Include(x => x.Subscribers)
             .ThenInclude(x => x.User)
             .FirstOrDefault(x => (model.DepartureDate != null &&
            x.DepartureDate == model.DepartureDate) || (x.DirectionId == model.DirectionId) ||
            (model.Id.HasValue && x.Id == model.Id))
            ?.GetViewModel;
        }

        public List<FlightViewModel> GetFilteredList(FlightSearchModel model)
        {
            if (model.DirectionId == null)
            {
                return new();
            }
            using var context = new FlyTodayDatabase();

            if (model.FlightStatus != null)
            {
                return context.Flights.Include(x => x.Plane)
             .Include(x => x.Direction)
             .Include(x => x.Subscribers)
             .ThenInclude(x => x.User)
             .Where(x => (x.FlightStatus == model.FlightStatus) &&
                (model.Id.HasValue && x.Id == model.Id)).ToList()
            .Select(x => x.GetViewModel).ToList();
            }
            
            return context.Flights
                .Include(x => x.Direction)
                .Include(x => x.Plane)
                .Include(x => x.Subscribers)
                .ThenInclude(x => x.User)
            .Where(x => x.DirectionId.Equals(model.DirectionId))
            .ToList()
            .Select(x => x.GetViewModel)
            .ToList();
        }

        public List<FlightViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.Flights
             .Include(x => x.Direction)
            .Include(x => x.Plane)
            .Include(x => x.Subscribers)
            .ThenInclude(x => x.User)
            .ToList()
            .Select(x => x.GetViewModel)
            .ToList();
        }

        public Dictionary<int, int> GetSubscribers(FlightSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            return context.FlightSubscribers.Where(rec => rec.FlightId == model.Id).ToList()
                .ToDictionary(
                    fs => fs.FlightId,
                    fs => fs.UserId
                );
        }

        public FlightViewModel? Insert(FlightBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var newFlight = Flight.Create(context, model);
            if (newFlight == null)
            {
                return null;
            }
            context.Flights.Add(newFlight);
            context.SaveChanges();
            return newFlight.GetViewModel;
        }

        public FlightViewModel? Update(FlightBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var flight = context.Flights.FirstOrDefault(rec => rec.Id == model.Id);
                if (flight == null)
                {
                    return null;
                }

                flight.Update(model);
                context.SaveChanges();
                flight.UpdateSubscribers(context, model);
                flight.UpdateDirection(context, model);
                flight.UpdatePlane(context, model);

                if (transaction != null)
                {
                    transaction.Commit();
                }

                return flight.GetViewModel;
            }
            catch
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                throw;
            }
        }

    }
}

using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;

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
            if (model.DepartureDate == null && !model.Id.HasValue)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            return context.Flights
             .Include(x => x.Plane)
             .Include(x => x.Direction)
             .FirstOrDefault(x => (model.DepartureDate != null &&
            x.DepartureDate == model.DepartureDate) ||
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
            return context.Flights
                .Include(x => x.Direction)
                .Include(x => x.Plane)
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
            .ToList()
            .Select(x => x.GetViewModel)
            .ToList();
        }

        public FlightViewModel? Insert(FlightBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var newFlight = Flight.Create(model);
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
                flight.UpdateDirection(context, model);
                flight.UpdatePlane(context, model);
                flight.Update(model);
                context.SaveChanges();
                transaction.Commit();
                return flight.GetViewModel;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}

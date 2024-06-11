using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;

namespace FlyTodayDatabaseImplements.Implements
{
    public class FlightSubscriberStorage : IFlightSubscriberStorage
    {
        public FlightSubscriberViewModel? Delete(FlightSubscriberBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var element = context.FlightSubscribers.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.FlightSubscribers.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public FlightSubscriberViewModel? GetElement(FlightSubscriberSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            if (model.Id.HasValue)
                return context.FlightSubscribers.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
            return null;
        }

        public List<FlightSubscriberViewModel> GetFilteredList(FlightSubscriberSearchModel model)
        {
            if (model.UserId == 0)
            {
                return new();
            }
            using var context = new FlyTodayDatabase();
            return context.FlightSubscribers
            .Where(x => x.UserId.Equals(model.UserId) || x.FlightId.Equals(model.FlightId))
           .Select(x => x.GetViewModel)
           .ToList();
        }

        public List<FlightSubscriberViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.FlightSubscribers.Select(x => x.GetViewModel).ToList();
        }

        public FlightSubscriberViewModel? Insert(FlightSubscriberBindingModel model)
        {
            var newFlightSubscriber = FlightSubscriber.Create(model);
            if (newFlightSubscriber == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.FlightSubscribers.Add(newFlightSubscriber);
            context.SaveChanges();
            return newFlightSubscriber.GetViewModel;
        }

        public FlightSubscriberViewModel? Update(FlightSubscriberBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var flightSubscriber = context.FlightSubscribers.FirstOrDefault(x => x.Id == model.Id);
            if (flightSubscriber == null)
            {
                return null;
            }
            flightSubscriber.Update(model);
            context.SaveChanges();
            return flightSubscriber.GetViewModel;
        }
    }
}

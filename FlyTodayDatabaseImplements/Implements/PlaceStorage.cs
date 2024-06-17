using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;

namespace FlyTodayDatabaseImplements.Implements
{
    public class PlaceStorage : IPlaceStorage
    {
        public PlaceViewModel? Delete(PlaceBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var element = context.Places.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Places.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public PlaceViewModel? GetElement(PlaceSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            if (string.IsNullOrEmpty(model.PlaceName) && !model.Id.HasValue && !model.FlightId.HasValue)
            {
                return null;
            }
            if (model.Id.HasValue)
            {
                return context.Places
                .Where(x => x.Id == model.Id)
                .Select(x => x.GetViewModel)
                .FirstOrDefault();
            }
            return context.Places
            .FirstOrDefault(x =>
           (!string.IsNullOrEmpty(model.PlaceName) && x.PlaceName ==
           model.PlaceName) &&
            (model.Id.HasValue && x.Id == model.Id) && (model.FlightId.HasValue && x.FlightId == model.FlightId))
            ?.GetViewModel;
        }

        public List<PlaceViewModel> GetFilteredList(PlaceSearchModel model)
        {            
            using var context = new FlyTodayDatabase();
            IQueryable<Place> placeQuery = context.Places;

            // Фильтрация по PositionAtWorkId
            if (model.FlightId.HasValue)
            {
                placeQuery = placeQuery.Where(x => x.FlightId == model.FlightId);
            }

            // Фильтрация по Id
            if (model.Id.HasValue)
            {
                placeQuery = placeQuery.Where(x => x.Id == model.Id);
            }

            return placeQuery.Select(x => x.GetViewModel).ToList();
        }

        public List<PlaceViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.Places
            .Select(x => x.GetViewModel)
           .ToList();
        }

        public PlaceViewModel? Insert(PlaceBindingModel model)
        {
            var newPlace = Place.Create(model);
            if (newPlace == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.Places.Add(newPlace);
            context.SaveChanges();
            return newPlace.GetViewModel;
        }

        public PlaceViewModel? Update(PlaceBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var place = context.Places.FirstOrDefault(x => x.Id ==
           model.Id);
            if (place == null)
            {
                return null;
            }
            place.Update(model);
            context.SaveChanges();
            return place.GetViewModel;
        }
    }
}

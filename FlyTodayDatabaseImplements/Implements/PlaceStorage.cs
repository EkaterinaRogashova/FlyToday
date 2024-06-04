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
            if (string.IsNullOrEmpty(model.PlaceName) && !model.Id.HasValue)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            return context.Places
            .FirstOrDefault(x =>
           (!string.IsNullOrEmpty(model.PlaceName) && x.PlaceName ==
           model.PlaceName) ||
            (model.Id.HasValue && x.Id == model.Id))
            ?.GetViewModel;
        }

        public List<PlaceViewModel> GetFilteredList(PlaceSearchModel model)
        {
            if (string.IsNullOrEmpty(model.PlaceName))
            {
                return new();
            }
            using var context = new FlyTodayDatabase();
            return context.Places
            .Where(x => x.PlaceName.Contains(model.PlaceName))
           .Select(x => x.GetViewModel)
           .ToList();
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

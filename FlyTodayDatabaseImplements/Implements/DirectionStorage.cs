using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;

namespace FlyTodayDatabaseImplements.Implements
{
    public class DirectionStorage : IDirectionStorage
    {
        public List<DirectionViewModel> Search(DirectionSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            return context.Directions
                .Where(x => x.CountryFrom.Contains(model.CountryFrom) || x.CityFrom.Contains(model.CityFrom) || x.CountryTo.Contains(model.CountryTo) || x.CityTo.Contains(model.CityTo))
                .ToList()
                .Select(x => x.GetViewModel)
                .ToList();
        }

        public DirectionViewModel? Delete(DirectionBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var element = context.Directions
            .FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Directions.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public DirectionViewModel? GetElement(DirectionSearchModel model)
        {
            if (string.IsNullOrEmpty(model.CountryFrom) && string.IsNullOrEmpty(model.CountryTo)
                && string.IsNullOrEmpty(model.CityFrom) && string.IsNullOrEmpty(model.CityTo) && !model.Id.HasValue)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            return context.Directions
                .Where(x => (model.CountryFrom == x.CountryFrom && model.CountryTo == x.CountryTo
                    && model.CityFrom == x.CityFrom && model.CityTo == x.CityTo) || (model.Id.HasValue && x.Id == model.Id))
                .FirstOrDefault()?.GetViewModel;
        }


        public List<DirectionViewModel> GetFilteredList(DirectionSearchModel model)
        {
            if (string.IsNullOrEmpty(model.CountryFrom) && string.IsNullOrEmpty(model.CountryTo)
                && string.IsNullOrEmpty(model.CityFrom) && string.IsNullOrEmpty(model.CityTo))
            {
                return new();
            }
            using var context = new FlyTodayDatabase();
            return context.Directions
            .Where(x => x.CountryFrom.Equals(model.CountryFrom) || x.CityFrom.Equals(model.CityFrom) || x.CountryTo.Equals(model.CountryTo) || x.CityTo.Equals(model.CityTo))
            .ToList()
            .Select(x => x.GetViewModel)
            .ToList();
        }

        public List<DirectionViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.Directions
                .Select(x => x.GetViewModel)
                .ToList();
        }

        public DirectionViewModel? Insert(DirectionBindingModel model)
        {
            var newDirection = Direction.Create(model);
            if (newDirection == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.Directions.Add(newDirection);
            context.SaveChanges();
            return newDirection.GetViewModel;
        }

        public DirectionViewModel? Update(DirectionBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var direction = context.Directions.FirstOrDefault(x => x.Id == model.Id);
            if (direction == null)
            {
                return null;
            }
            direction.Update(model);
            context.SaveChanges();
            return direction.GetViewModel;
        }
    }
}

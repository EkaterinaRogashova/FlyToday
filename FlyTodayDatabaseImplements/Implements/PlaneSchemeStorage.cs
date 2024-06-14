using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.IdentityModel.Tokens;

namespace FlyTodayDatabaseImplements.Implements
{
    public class PlaneSchemeStorage : IPlaneSchemeStorage
    {
        public PlaneSchemeViewModel? Delete(PlaneSchemeBindingModel model)
        {
            var context = new FlyTodayDatabase();
            var element = context.PlaneSchemes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.PlaneSchemes.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public PlaneSchemeViewModel? GetElement(PlaneSchemeSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            if (model.Name.IsNullOrEmpty() && !model.EconomPlacesCount.HasValue && !model.BusinessPlacesCount.HasValue && !model.PlacesInFirstLineEconom.HasValue 
                && !model.PlacesInMiddleLineEconom.HasValue && !model.PlacesInLastLineEconom.HasValue && !model.PlacesInFirstLineBusiness.HasValue 
                && !model.PlacesInLastLineBusiness.HasValue && !model.Id.HasValue)
            {
                return null;
            }
            if (model.Id.HasValue)
            {
                return context.PlaneSchemes
                .Where(x => x.Id == model.Id)
                .Select(x => x.GetViewModel)
                .FirstOrDefault();
            }
            return context.PlaneSchemes
            .FirstOrDefault(x =>
           (!string.IsNullOrEmpty(model.Name) && x.Name == model.Name) &&
            (model.Id.HasValue && x.Id == model.Id))
            ?.GetViewModel;
        }

        public List<PlaneSchemeViewModel> GetFilteredList(PlaneSchemeSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            IQueryable<PlaneScheme> query = context.PlaneSchemes;

            if (!model.Name.IsNullOrEmpty())
            {
                query = query.Where(x => x.Name == model.Name);
            }
            if (model.Id.HasValue)
            {
                query = query.Where(x => x.Id == model.Id);
            }
            if (model.BusinessPlacesCount.HasValue)
            {
                query = query.Where(x => x.BusinessPlacesCount == model.BusinessPlacesCount);
            }
            if (model.EconomPlacesCount.HasValue)
            {
                query = query.Where(x => x.EconomPlacesCount == model.EconomPlacesCount);
            }
            if (model.PlacesInFirstLineEconom.HasValue)
            {
                query = query.Where(x => x.PlacesInFirstLineEconom == model.PlacesInFirstLineEconom);
            }
            if (model.PlacesInMiddleLineEconom.HasValue)
            {
                query = query.Where(x => x.PlacesInMiddleLineEconom == model.PlacesInMiddleLineEconom);
            }
            if (model.PlacesInLastLineEconom.HasValue)
            {
                query = query.Where(x => x.PlacesInLastLineEconom == model.PlacesInLastLineEconom);
            }
            if (model.PlacesInFirstLineBusiness.HasValue)
            {
                query = query.Where(x => x.PlacesInFirstLineBusiness == model.PlacesInFirstLineBusiness);
            }
            if (model.PlacesInLastLineBusiness.HasValue)
            {
                query = query.Where(x => x.PlacesInLastLineBusiness == model.PlacesInLastLineBusiness);
            }

            return query.Select(x => x.GetViewModel).ToList();
        }

        public List<PlaneSchemeViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.PlaneSchemes
                .Select(x => x.GetViewModel)
                .ToList();
        }

        public PlaneSchemeViewModel? Insert(PlaneSchemeBindingModel model)
        {
            var newPlaneScheme = PlaneScheme.Create(model);
            if (newPlaneScheme == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.PlaneSchemes.Add(newPlaneScheme);
            context.SaveChanges();
            return newPlaneScheme.GetViewModel;
        }

        public PlaneSchemeViewModel? Update(PlaneSchemeBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var planeScheme = context.PlaneSchemes.FirstOrDefault(x => x.Id == model.Id);
            if (planeScheme == null)
            {
                return null;
            }
            planeScheme.Update(model);
            context.SaveChanges();
            return planeScheme.GetViewModel;
        }
    }
}

using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;

namespace FlyTodayDatabaseImplements.Implements
{
    public class PlaneStorage : IPlaneStorage
    {
        public PlaneViewModel? Delete(PlaneBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var element = context.Planes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Planes.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public PlaneViewModel? GetElement(PlaneSearchModel model)
        {
            if (string.IsNullOrEmpty(model.ModelName) && !model.Id.HasValue)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            return context.Planes
            .FirstOrDefault(x =>
           (!string.IsNullOrEmpty(model.ModelName) && x.ModelName ==
           model.ModelName) ||
            (model.Id.HasValue && x.Id == model.Id))
            ?.GetViewModel;
        }

        public List<PlaneViewModel> GetFilteredList(PlaneSearchModel model)
        {
            if (string.IsNullOrEmpty(model.ModelName))
            {
                return new();
            }
            using var context = new FlyTodayDatabase();
            return context.Planes
                .Include(x => x.PlaneScheme)
            .Where(x => x.ModelName.Contains(model.ModelName))
           .Select(x => x.GetViewModel)
           .ToList();
        }

        public List<PlaneViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.Planes
                .Include(x => x.PlaneScheme)
            .Select(x => x.GetViewModel)
           .ToList();
        }

        public PlaneViewModel? Insert(PlaneBindingModel model)
        {
            var newPlane = Plane.Create(model);
            if (newPlane == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.Planes.Add(newPlane);
            context.SaveChanges();
            return newPlane.GetViewModel;
        }

        public PlaneViewModel? Update(PlaneBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var component = context.Planes.FirstOrDefault(x => x.Id == model.Id);
            if (component == null)
            {
                return null;
            }
            component.Update(model);
            context.SaveChanges();
            return component.GetViewModel;
        }
    }
}

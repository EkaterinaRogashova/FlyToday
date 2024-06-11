using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayDatabaseImplements.Implements
{
    public class RentStorage : IRentStorage
    {
        public RentViewModel? Delete(RentBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var element = context.Rents.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Rents.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public RentViewModel? GetElement(RentSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            if (model.Id.HasValue)
                return context.Rents.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
            //if (!string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(model.Password))
            //    return context.Rents.FirstOrDefault(x => x.Email.Equals(model.Email) && x.Password.Equals(model.Password))?.GetViewModel;
            //if (!string.IsNullOrEmpty(model.Email))
            //    return context.Rents.FirstOrDefault(x => x.Email.Equals(model.Email))?.GetViewModel;
            return null;
        }

        public List<RentViewModel> GetFilteredList(RentSearchModel model)
        {
            if (model.UserId == null)
            {
                return new();
            }
            using var context = new FlyTodayDatabase();
            return context.Rents    
            .Where(x => x.UserId.Equals(model.UserId))
           .Select(x => x.GetViewModel)
           .ToList();
        }

        public List<RentViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.Rents.Select(x => x.GetViewModel).ToList();
        }

        public RentViewModel? Insert(RentBindingModel model)
        {
            var newRent = Rent.Create(model);
            if (newRent == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.Rents.Add(newRent);
            context.SaveChanges();
            return newRent.GetViewModel; ;
        }
        public RentViewModel? Update(RentBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var rent = context.Rents.FirstOrDefault(x => x.Id == model.Id);
            if (rent == null)
            {
                return null;
            }
            rent.Update(model);
            context.SaveChanges();
            return rent.GetViewModel;
        }
    }
}

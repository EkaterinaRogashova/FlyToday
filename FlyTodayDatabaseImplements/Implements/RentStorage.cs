using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using FlyTodayDatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;
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
            return null;
        }

        public List<RentViewModel> GetFilteredList(RentSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            var query = context.Rents.Include(x => x.Flight).Include(x => x.User);

            if (model.Id.HasValue)
            {
                return query.Where(x => x.Id == model.Id).Select(x => x.GetViewModel).ToList();
            }

            else if (model.UserId.HasValue)
            {
                return query.Where(x => x.UserId == model.UserId).Select(x => x.GetViewModel).ToList();
            }

            else if (model.FlightId.HasValue)
            {
                return query.Where(x => x.FlightId == model.FlightId).Select(x => x.GetViewModel).ToList();
            }

            return null;            
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

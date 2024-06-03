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
    public class PositionAtWorkStorage : IPositionAtWorkStorage
    {
        public PositionAtWorkViewModel? Delete(PositionAtWorkBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var element = context.PositionAtWorks.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.PositionAtWorks.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public PositionAtWorkViewModel? GetElement(PositionAtWorkSearchModel model)
        {
            using var context = new FlyTodayDatabase();
            if (model.Id.HasValue)
                return context.PositionAtWorks.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
            return null;
        }

        public List<PositionAtWorkViewModel> GetFilteredList(PositionAtWorkSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<PositionAtWorkViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.PositionAtWorks.Select(x => x.GetViewModel).ToList();
        }

        public PositionAtWorkViewModel? Insert(PositionAtWorkBindingModel model)
        {
            var newPositionAtWork = PositionAtWork.Create(model);
            if (newPositionAtWork == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.PositionAtWorks.Add(newPositionAtWork);
            context.SaveChanges();
            return newPositionAtWork.GetViewModel;
        }

        public PositionAtWorkViewModel? Update(PositionAtWorkBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var sale = context.PositionAtWorks.FirstOrDefault(x => x.Id == model.Id);
            if (sale == null)
            {
                return null;
            }
            sale.Update(model);
            context.SaveChanges();
            return sale.GetViewModel;
        }
    }
}

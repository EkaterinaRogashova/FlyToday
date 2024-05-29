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
    public class SaleStorage : ISaleStorage
    {
        public SaleViewModel? Delete(SaleBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var element = context.Sales.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Sales.Remove(element);
                context.SaveChanges();
                return element.GetViewModel;
            }
            return null;
        }

        public SaleViewModel? GetElement(SaleSearchModel model)
        {
            //using var context = new FlyTodayDatabase();
            //if (model.Id.HasValue)
            //    return context.Sales.FirstOrDefault(x => x.Id == model.Id)?.GetViewModel;
            //if (!string.IsNullOrEmpty(model.Email) && !string.IsNullOrEmpty(model.Password))
            //    return context.Sales.FirstOrDefault(x => x.Email.Equals(model.Email) && x.Password.Equals(model.Password))?.GetViewModel;
            //if (!string.IsNullOrEmpty(model.Email))
            //    return context.Sales.FirstOrDefault(x => x.Email.Equals(model.Email))?.GetViewModel;
            return null;
        }

        public List<SaleViewModel> GetFilteredList(SaleSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<SaleViewModel> GetFullList()
        {
            using var context = new FlyTodayDatabase();
            return context.Sales.Select(x => x.GetViewModel).ToList();
        }

        public SaleViewModel? Insert(SaleBindingModel model)
        {
            var newSale = Sale.Create(model);
            if (newSale == null)
            {
                return null;
            }
            using var context = new FlyTodayDatabase();
            context.Sales.Add(newSale);
            context.SaveChanges();
            return newSale.GetViewModel;
        }

        public SaleViewModel? Update(SaleBindingModel model)
        {
            using var context = new FlyTodayDatabase();
            var sale = context.Sales.FirstOrDefault(x => x.Id == model.Id);
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

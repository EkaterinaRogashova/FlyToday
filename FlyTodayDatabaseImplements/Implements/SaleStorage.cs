using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
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
            throw new NotImplementedException();
        }

        public SaleViewModel? GetElement(SaleSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<SaleViewModel> GetFilteredList(SaleSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<SaleViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public SaleViewModel? Insert(SaleBindingModel model)
        {
            throw new NotImplementedException();
        }

        public SaleViewModel? Update(SaleBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}

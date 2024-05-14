using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.StoragesContracts
{
    public interface ISaleStorage
    {
        List<SaleViewModel> GetFullList();
        List<SaleViewModel> GetFilteredList(SaleSearchModel model);
        SaleViewModel? GetElement(SaleSearchModel model);
        SaleViewModel? Insert(SaleBindingModel model);
        SaleViewModel? Update(SaleBindingModel model);
        SaleViewModel? Delete(SaleBindingModel model);
    }
}

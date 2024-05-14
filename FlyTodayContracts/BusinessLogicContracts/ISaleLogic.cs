using FlyTodayContracts.BindingModels;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BusinessLogicContracts
{
    public interface ISaleLogic
    {
        List<SaleViewModel>? ReadList(SaleSearchModel? model);
        SaleViewModel? ReadElement(SaleSearchModel model);
        bool Create(SaleBindingModel model);
        bool Update(SaleBindingModel model);
        bool Delete(SaleBindingModel model);
    }
}

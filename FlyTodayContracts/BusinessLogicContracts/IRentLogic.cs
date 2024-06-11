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
    public interface IRentLogic
    {
        List<RentViewModel>? ReadList(RentSearchModel? model);
        RentViewModel? ReadElement(RentSearchModel model);
        bool Create(RentBindingModel model);
        bool Delete(RentBindingModel model);
        bool Update(RentBindingModel model);
    }
}

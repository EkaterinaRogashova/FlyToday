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
    public interface IBoardingPassLogic
    {
        List<BoardingPassViewModel>? ReadList(BoardingPassSearchModel? model);
        BoardingPassViewModel? ReadElement(BoardingPassSearchModel model);
        bool Create(BoardingPassBindingModel model);
    }
}

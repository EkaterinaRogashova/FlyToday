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
    public interface IBoardingPassStorage
    {
        List<BoardingPassViewModel> GetFullList();
        List<BoardingPassViewModel> GetFilteredList(BoardingPassSearchModel model);
        BoardingPassViewModel? GetElement(BoardingPassSearchModel model);
        BoardingPassViewModel? Insert(BoardingPassBindingModel model);
    }
}

using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class BoardingPassLogic : IBoardingPassLogic
    {
        public bool Create(BoardingPassBindingModel model)
        {
            throw new NotImplementedException();
        }

        public BoardingPassViewModel? ReadElement(BoardingPassSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<BoardingPassViewModel>? ReadList(BoardingPassSearchModel? model)
        {
            throw new NotImplementedException();
        }
    }
}

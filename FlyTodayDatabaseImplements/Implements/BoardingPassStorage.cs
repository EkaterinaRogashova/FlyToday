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
    public class BoardingPassStorage : IBoardingPassStorage
    {
        public BoardingPassViewModel? Delete(BoardingPassBindingModel model)
        {
            throw new NotImplementedException();
        }

        public BoardingPassViewModel? GetElement(BoardingPassSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<BoardingPassViewModel> GetFilteredList(BoardingPassSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<BoardingPassViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public BoardingPassViewModel? Insert(BoardingPassBindingModel model)
        {
            throw new NotImplementedException();
        }

        public BoardingPassViewModel? Update(BoardingPassBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}

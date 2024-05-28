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
    public class DirectionStorage : IDirectionStorage
    {
        public DirectionViewModel? Delete(DirectionBindingModel model)
        {
            throw new NotImplementedException();
        }

        public DirectionViewModel? GetElement(DirectionSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<DirectionViewModel> GetFilteredList(DirectionSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<DirectionViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public DirectionViewModel? Insert(DirectionBindingModel model)
        {
            throw new NotImplementedException();
        }

        public DirectionViewModel? Update(DirectionBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class RentStorage : IRentStorage
    {
        public RentViewModel? Delete(RentBindingModel model)
        {
            throw new NotImplementedException();
        }

        public RentViewModel? GetElement(RentSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<RentViewModel> GetFilteredList(RentSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<RentViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public RentViewModel? Insert(RentBindingModel model)
        {
            throw new NotImplementedException();
        }

        public RentViewModel? Update(RentBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}

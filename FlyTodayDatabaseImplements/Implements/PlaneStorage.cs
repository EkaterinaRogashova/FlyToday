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
    public class PlaneStorage : IPlaneStorage
    {
        public PlaneViewModel? Delete(PlaneBindingModel model)
        {
            throw new NotImplementedException();
        }

        public PlaneViewModel? GetElement(PlaneSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<PlaneViewModel> GetFilteredList(PlaneSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<PlaneViewModel> GetFullList()
        {
            throw new NotImplementedException();
        }

        public PlaneViewModel? Insert(PlaneBindingModel model)
        {
            throw new NotImplementedException();
        }

        public PlaneViewModel? Update(PlaneBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}

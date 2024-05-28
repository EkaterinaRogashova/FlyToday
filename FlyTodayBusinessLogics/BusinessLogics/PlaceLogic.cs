using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class PlaceLogic : IPlaceLogic
    {
        private readonly ILogger _logger;
        private readonly IPlaceStorage _PlaceStorage;
        public PlaceLogic(ILogger<PlaceLogic> logger, IPlaceStorage placeStorage)
        {
            _logger = logger;
            _placeStorage = placeStorage;
        }
        public bool Create(PlaceBindingModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(PlaceBindingModel model)
        {
            throw new NotImplementedException();
        }

        public PlaceViewModel? ReadElement(PlaceSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<PlaceViewModel>? ReadList(PlaceSearchModel? model)
        {
            throw new NotImplementedException();
        }

        public bool Update(PlaceBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}

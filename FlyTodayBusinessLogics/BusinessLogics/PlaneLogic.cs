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
    public class PlaneLogic : IPlaneLogic
    {
        private readonly ILogger _logger;
        private readonly IPlaneStorage _planeStorage;
        public PlaneLogic(ILogger<PlaneLogic> logger, IPlaneStorage planeStorage)
        {
            _logger = logger;
            _planeStorage = planeStorage;
        }
        public bool Create(PlaneBindingModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(PlaneBindingModel model)
        {
            throw new NotImplementedException();
        }

        public PlaneViewModel? ReadElement(PlaneSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<PlaneViewModel>? ReadList(PlaneSearchModel? model)
        {
            throw new NotImplementedException();
        }

        public bool Update(PlaneBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}

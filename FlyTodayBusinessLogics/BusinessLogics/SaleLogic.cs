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
    public class SaleLogic : ISaleLogic
    {
        private readonly ILogger _logger;
        private readonly ISaleStorage _saleStorage;
        public SaleLogic(ILogger<SaleLogic> logger, ISaleStorage saleStorage)
        {
            _logger = logger;
            _saleStorage = saleStorage;
        }
        public bool Create(SaleBindingModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(SaleBindingModel model)
        {
            throw new NotImplementedException();
        }

        public SaleViewModel? ReadElement(SaleSearchModel model)
        {
            throw new NotImplementedException();
        }

        public List<SaleViewModel>? ReadList(SaleSearchModel? model)
        {
            throw new NotImplementedException();
        }

        public bool Update(SaleBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}

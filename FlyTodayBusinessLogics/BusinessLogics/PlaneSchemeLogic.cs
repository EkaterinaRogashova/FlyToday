using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.SearchModels;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using Microsoft.Extensions.Logging;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class PlaneSchemeLogic : IPlaneSchemeLogic
    {
        private readonly ILogger _logger;
        private readonly IPlaneSchemeStorage _planeSchemeStorage;
        public PlaneSchemeLogic(ILogger<PlaneSchemeLogic> logger, IPlaneSchemeStorage planeSchemeStorage)
        {
            _logger = logger;
            _planeSchemeStorage = planeSchemeStorage;
        }
        public bool Create(PlaneSchemeBindingModel model)
        {
            CheckModel(model);
            if (_planeSchemeStorage.Insert(model) == null)
            {
                _logger.LogWarning("Insert operation failed");
                return false;
            }
            return true;
        }

        public bool Delete(PlaneSchemeBindingModel model)
        {
            CheckModel(model, false);
            _logger.LogInformation("Delete. Id:{Id}", model.Id);
            if (_planeSchemeStorage.Delete(model) == null)
            {
                _logger.LogWarning("Delete operation failed");
                return false;
            }
            return true;
        }

        public PlaneSchemeViewModel? ReadElement(PlaneSchemeSearchModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            _logger.LogInformation("ReadElement. Id:{Id}, Name:{Name}, BusinessPlacesCount:{BusinessPlacesCount}, EconomPlacesCount:{EconomPlacesCount}, PlacesInFirstLineEconom:{PlacesInFirstLineEconom}, PlacesInMiddleLineEconom:{PlacesInMiddleLineEconom}, PlacesInLastLineEconom:{PlacesInLastLineEconom}, PlacesInFirstLineBusiness:{PlacesInFirstLineBusiness}, PlacesInLastLineBusiness:{PlacesInLastLineBusiness}",
                model.Id, model.Name, model.BusinessPlacesCount, model.EconomPlacesCount, model.PlacesInFirstLineEconom, model.PlacesInMiddleLineEconom, model.PlacesInLastLineEconom, model.PlacesInFirstLineBusiness, model.PlacesInLastLineBusiness);

            var element = _planeSchemeStorage.GetElement(model);
            if (element == null)
            {
                _logger.LogWarning("ReadElement element not found");
                return null;
            }

            _logger.LogInformation("ReadElement find. Id:{Id}", element.Id);
            return element;
        }

        public List<PlaneSchemeViewModel>? ReadList(PlaneSchemeSearchModel? model)
        {
            _logger.LogInformation("ReadList. Id:{Id}, Name:{Name}, BusinessPlacesCount:{BusinessPlacesCount}, EconomPlacesCount:{EconomPlacesCount}, PlacesInFirstLineEconom:{PlacesInFirstLineEconom}, PlacesInMiddleLineEconom:{PlacesInMiddleLineEconom}, PlacesInLastLineEconom:{PlacesInLastLineEconom}, PlacesInFirstLineBusiness:{PlacesInFirstLineBusiness}, PlacesInLastLineBusiness:{PlacesInLastLineBusiness}",
                 model?.Id, model?.Name, model?.BusinessPlacesCount, model?.EconomPlacesCount, model?.PlacesInFirstLineEconom, model?.PlacesInMiddleLineEconom, model?.PlacesInLastLineEconom, model?.PlacesInFirstLineBusiness, model?.PlacesInLastLineBusiness);
            var list = model == null ? _planeSchemeStorage.GetFullList() : _planeSchemeStorage.GetFilteredList(model);
            if (list == null)
            {
                _logger.LogWarning("ReadList return null list");
                return null;
            }
            _logger.LogInformation("ReadList. Count:{Count}", list.Count);
            return list;
        }


        public bool Update(PlaneSchemeBindingModel model)
        {
            CheckModel(model);
            if (_planeSchemeStorage.Update(model) == null)
            {
                _logger.LogWarning("Update operation failed");
                return false;
            }
            return true;
        }

        private void CheckModel(PlaneSchemeBindingModel model, bool withParams = true)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (!withParams)
            {
                return;
            }

            if (string.IsNullOrEmpty(model.Name))
            {
                throw new ArgumentException("Нет названия схемы самолета", nameof(model.Name));
            }

            if (model.EconomPlacesCount < 0)
            {
                throw new ArgumentException("Количество мест эконом-класса должно быть больше нуля", nameof(model.EconomPlacesCount));
            }

            if (model.BusinessPlacesCount < 0)
            {
                throw new ArgumentException("Количество мест эконом-класса должно быть больше нуля", nameof(model.BusinessPlacesCount));
            }

            if (model.PlacesInFirstLineEconom < 0)
            {
                throw new ArgumentException("Количество мест в первом ряду эконом класса должно быть больше нуля", nameof(model.PlacesInFirstLineEconom));
            }

            if (model.PlacesInMiddleLineEconom < 0)
            {
                throw new ArgumentException("Количество мест в среднем ряду эконом класса должно быть больше нуля", nameof(model.PlacesInMiddleLineEconom));
            }

            if (model.PlacesInLastLineEconom < 0)
            {
                throw new ArgumentException("Количество мест в последнем ряду эконом класса должно быть больше нуля", nameof(model.PlacesInLastLineEconom));
            }

            if (model.PlacesInFirstLineBusiness < 0)
            {
                throw new ArgumentException("Количество мест в первом ряду бизнес класса должно быть больше нуля", nameof(model.PlacesInFirstLineBusiness));
            }

            if (model.PlacesInLastLineBusiness < 0)
            {
                throw new ArgumentException("Количество мест в последнем ряду бизнес класса должно быть больше нуля", nameof(model.PlacesInLastLineBusiness));
            }

            if (!int.TryParse(model.BusinessPlacesCount.ToString(), out _))
            {
                throw new ArgumentException("Количество мест бизнес-класса должно быть целым числом", nameof(model.BusinessPlacesCount));
            }

            if (!int.TryParse(model.EconomPlacesCount.ToString(), out _))
            {
                throw new ArgumentException("Количество мест эконом-класса должно быть целым числом", nameof(model.EconomPlacesCount));
            }

            if (!int.TryParse(model.PlacesInFirstLineEconom.ToString(), out _))
            {
                throw new ArgumentException("Количество мест в первом ряду эконом-класса должно быть целым числом", nameof(model.PlacesInFirstLineEconom));
            }

            if (!int.TryParse(model.PlacesInMiddleLineEconom.ToString(), out _))
            {
                throw new ArgumentException("Количество мест в среднем ряду эконом-класса должно быть целым числом", nameof(model.PlacesInMiddleLineEconom));
            }

            if (!int.TryParse(model.PlacesInLastLineEconom.ToString(), out _))
            {
                throw new ArgumentException("Количество мест в последнем ряду эконом-класса должно быть целым числом", nameof(model.PlacesInLastLineEconom));
            }

            if (!int.TryParse(model.PlacesInFirstLineBusiness.ToString(), out _))
            {
                throw new ArgumentException("Количество мест в первом ряду бизнес-класса должно быть целым числом", nameof(model.PlacesInFirstLineBusiness));
            }

            if (!int.TryParse(model.PlacesInLastLineBusiness.ToString(), out _))
            {
                throw new ArgumentException("Количество мест в последнем ряду бизнес-класса должно быть целым числом", nameof(model.PlacesInLastLineBusiness));
            }

            _logger.LogInformation("PlaneScheme. Id:{Id}, Name:{Name}, BusinessPlacesCount:{BusinessPlacesCount}, EconomPlacesCount:{EconomPlacesCount}, PlacesInFirstLineEconom:{PlacesInFirstLineEconom}, PlacesInMiddleLineEconom:{PlacesInMiddleLineEconom}, PlacesInLastLineEconom:{PlacesInLastLineEconom}, PlacesInFirstLineBusiness:{PlacesInFirstLineBusiness}, PlacesInLastLineBusiness:{PlacesInLastLineBusiness}",
             model.Id, model.Name, model.BusinessPlacesCount, model.EconomPlacesCount, model.PlacesInFirstLineEconom, model.PlacesInMiddleLineEconom, model.PlacesInLastLineEconom, model.PlacesInFirstLineBusiness, model.PlacesInLastLineBusiness);

            var element = _planeSchemeStorage.GetElement(new PlaneSchemeSearchModel
            {
                Name = model.Name,
                BusinessPlacesCount = model.BusinessPlacesCount,
                EconomPlacesCount = model.EconomPlacesCount,
                PlacesInFirstLineEconom = model.PlacesInFirstLineEconom,
                PlacesInMiddleLineEconom = model.PlacesInMiddleLineEconom,
                PlacesInLastLineEconom = model.PlacesInLastLineEconom,
                PlacesInFirstLineBusiness = model.PlacesInFirstLineBusiness,
                PlacesInLastLineBusiness = model.PlacesInLastLineBusiness
            });

            if (element != null && element.Id != model.Id)
            {
                throw new InvalidOperationException("Такая схема самолета уже существует.");
            }
        }

    }
}

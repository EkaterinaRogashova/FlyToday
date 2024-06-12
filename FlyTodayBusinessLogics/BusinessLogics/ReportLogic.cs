using FlyTodayBusinessLogics.OfficePackage;
using FlyTodayContracts.BindingModels;
using FlyTodayContracts.BusinessLogicContracts;
using FlyTodayContracts.StoragesContracts;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayBusinessLogics.BusinessLogics
{
    public class ReportLogic : IReportLogic
    {
        private readonly IEmployeeStorage _employeeStorage;
        private readonly IScheduleStorage _scheduleStorage;
        private readonly AbstractSaveToPdf _saveToPdf;
        public ReportLogic(IEmployeeStorage employeeStorage, IScheduleStorage scheduleStorage, AbstractSaveToPdf saveToPdf)
        {
            _saveToPdf = saveToPdf;
            _employeeStorage = employeeStorage;
            _scheduleStorage = scheduleStorage;
        }
        public List<ReportScheduleViewModel> GetSchedule(List<int> Ids)
        {
            var listAll = new List<ReportScheduleViewModel>();

            var listRecipes = _scheduleStorage.GetFilteredList(new RecipesSearchModel
            {
                ClientId = model.ClientId,
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            });

            foreach (var recipe in listRecipes)
            {
                listAll.Add(new ReportScheduleViewModel
                {
                    Date = recipe.Date,
                    Dose = recipe.Dose,
                    ModeofApplication = recipe.ModeOfApplication
                });
            }
            return listAll;
        }

        public List<ReportScheduleViewModel> GetScheduleForEmployee(List<int> Ids)
        {
            throw new NotImplementedException();
        }

        public void SaveRecipesToPdfFile(ReportBindingModel model)
        {
            throw new NotImplementedException();
        }
    }
}

using FlyTodayContracts.BindingModels;
using FlyTodayContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTodayContracts.BusinessLogicContracts
{
    public interface IReportLogic
    {
        List<ReportScheduleViewModel> GetSchedule(List<int> Ids);
        List<ReportScheduleViewModel> GetScheduleForEmployee(List<int> Ids);
        void SaveRecipesToPdfFile(ReportBindingModel model);
        void SaveBoardingPassesToPdf(ReportBindingModel model);
    }
}

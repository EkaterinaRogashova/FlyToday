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
        List<ReportScheduleViewModel> GetSchedule(ReportBindingModel model);
        List<ReportScheduleForEmployeeViewModel> GetScheduleForEmployee(List<int> Ids);
        void SaveReportScheduleToPdfFile(ReportBindingModel model);
        void SaveReportScheduleForEmployeeToPdfFile(ReportBindingModel model);
        void SaveBoardingPassesToPdf(ReportBindingModel model);
        void SaveBoardingPassToPdf(ReportBindingModel model);
    }
}

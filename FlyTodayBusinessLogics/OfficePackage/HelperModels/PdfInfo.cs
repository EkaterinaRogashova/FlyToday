using FlyTodayContracts.ViewModels;

namespace FlyTodayBusinessLogics.OfficePackage.HelperModels
{
    public class PdfInfo
    {
        public string FileName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string EmployeeFIO { get; set; } = string.Empty;
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string? DepartureDate { get; set; }
        public string? Direction { get; set; }
        public string? Plane { get; set; }
        public List<ReportBoardingPassesViewModel> BoardingPass { get; set; }
        public List<ReportScheduleViewModel> Schedule { get; set; } = new();
        public List<ReportScheduleForEmployeeViewModel> ScheduleForEmployee { get; set; } = new();
        public List<ReportBoardingPassesViewModel> BoardingPasses { get; set; } = new();
    }
}

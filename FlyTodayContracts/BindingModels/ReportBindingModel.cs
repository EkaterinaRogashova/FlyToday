using FlyTodayContracts.ViewModels;

namespace FlyTodayContracts.BindingModels
{
    public class ReportBindingModel
    {
        public string FileName { get; set; } = string.Empty;
        public int? FlightId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public List<int>? Ids { get; set; }
        public int EmployeeId { get; set; }
        public int TicketId { get; set; }
        public string Female { get; set; } = string.Empty;
        public string Male { get; set; } = string.Empty;
        public string WithBags { get; set; } = string.Empty;
        public string NotWithBags { get; set; } = string.Empty;
        public string Children { get; set; } = string.Empty;
        public string People { get; set; } = string.Empty;
        public string OlderPeople { get; set; } = string.Empty;
        //public Dictionary<string, (int, string)> Statistics = new();
        public List<ReportDirectionsViewModel> Statistics { get; set; }
    }
}

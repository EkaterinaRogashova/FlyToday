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
    }
}

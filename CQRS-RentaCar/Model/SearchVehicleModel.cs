namespace CQRS_RentaCar.Model
{
    public class SearchVehicleModel
    {
        public int BodyStyle { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? StartLocation { get; set; }
        public int? EndLocation { get; set; }
    }
}

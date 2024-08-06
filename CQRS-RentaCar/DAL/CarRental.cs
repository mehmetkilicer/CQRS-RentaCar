namespace CQRS_RentaCar.DAL
{
    public class CarRental
    {
        public int CarRentalId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? StartLocationId { get; set; }
        public int? EndLocationId { get; set; }
        public RentalLocation StartLocation { get; set; }
        public RentalLocation EndLocation { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}

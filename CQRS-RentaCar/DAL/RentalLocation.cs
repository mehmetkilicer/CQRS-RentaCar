namespace CQRS_RentaCar.DAL
{
    public class RentalLocation
    {
        public int RentalLocationId { get; set; }
        public string LocationName { get; set; }
        public bool IsActive { get; set; }
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<CarRental> StartRentals { get; set; } = new List<CarRental>();
        public List<CarRental> EndRentals { get; set; } = new List<CarRental>();
    }
}

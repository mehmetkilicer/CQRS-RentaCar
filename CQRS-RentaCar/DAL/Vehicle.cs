namespace CQRS_RentaCar.DAL
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int Mileage { get; set; }
        public string Gearbox { get; set; }
        public int NumberOfSeats { get; set; }
        public string FuelType { get; set; }
        public decimal Price { get; set; }
        public decimal DailyRate { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int RentalLocationId { get; set; }
        public RentalLocation RentalLocation { get; set; }
        public int BodyStyleId { get; set; }
        public BodyStyle BodyStyle { get; set; }
        public List<CarRental> CarRentals { get; set; } = new List<CarRental>();
    }
}

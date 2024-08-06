namespace CQRS_RentaCar.Mediator.Results
{
    public class GetVehicleByIdQueryResult
    {
        public int VehicleId { get; set; }
        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
        public string Gearbox { get; set; }
        public int NumberOfSeats { get; set; }
        public string FuelType { get; set; }
        public decimal DailyRate { get; set; }
        public int BrandId { get; set; }
        public int RentalLocationId { get; set; }
        public int BodyStyleId { get; set; }
    }
}

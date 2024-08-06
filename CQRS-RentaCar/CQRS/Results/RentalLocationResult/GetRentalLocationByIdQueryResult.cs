namespace CQRS_RentaCar.CQRS.Results.RentalLocationResult
{
    public class GetRentalLocationByIdQueryResult
    {
        public int RentalLocationId { get; set; }
        public string LocationName { get; set; }
        public bool IsActive { get; set; }
    }
}

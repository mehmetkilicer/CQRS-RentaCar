namespace CQRS_RentaCar.CQRS.Results.RentalLocationResult
{
    public class GetRentalLocationQueryResult
    {
        public int RentalLocationId { get; set; }
        public string LocationName { get; set; }
        public bool IsActive { get; set; }
    }
}

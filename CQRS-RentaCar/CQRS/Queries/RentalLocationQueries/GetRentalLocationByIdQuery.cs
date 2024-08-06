namespace CQRS_RentaCar.CQRS.Queries.RentalLocationQueries
{
    public class GetRentalLocationByIdQuery
    {
        public int Id { get; set; }

        public GetRentalLocationByIdQuery(int id)
        {
            Id = id;
        }
    }
}

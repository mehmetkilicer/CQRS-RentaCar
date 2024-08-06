namespace CQRS_RentaCar.CQRS.Queries.BodyStyleQueries
{
    public class GetBodyStyleByIdQuery
    {
        public int Id { get; set; }

        public GetBodyStyleByIdQuery(int id)
        {
            Id = id;
        }
    }
}

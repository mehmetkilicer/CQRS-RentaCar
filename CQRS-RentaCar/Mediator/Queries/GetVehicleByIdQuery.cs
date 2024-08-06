using CQRS_RentaCar.Mediator.Results;
using MediatR;
namespace CQRS_RentaCar.Mediator.Queries
{
    public class GetVehicleByIdQuery : IRequest<GetVehicleByIdQueryResult>
    {
        public int Id { get; set; }

        public GetVehicleByIdQuery(int id)
        {
            Id = id;
        }
    }
}

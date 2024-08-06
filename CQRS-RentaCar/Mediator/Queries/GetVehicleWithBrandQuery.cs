using CQRS_RentaCar.Mediator.Results;
using MediatR;

namespace CQRS_RentaCar.Mediator.Queries
{
    public class GetVehicleWithBrandQuery : IRequest<List<GetVehicleWithBrandQueryResult>>
    {
    }
}

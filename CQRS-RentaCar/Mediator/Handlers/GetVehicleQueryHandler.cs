using AutoMapper;
using CQRS_RentaCar.DAL;
using CQRS_RentaCar.Mediator.Queries;
using CQRS_RentaCar.Mediator.Results;
using MediatR;

namespace CQRS_RentaCar.Mediator.Handlers
{
    public class GetVehicleQueryHandler : IRequestHandler<GetVehicleQuery, List<GetVehicleQueryResult>>
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public GetVehicleQueryHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public async Task<List<GetVehicleQueryResult>> Handle(GetVehicleQuery query, CancellationToken cancellationToken)
        {
            var values = _carRentalContext.Vehicles.ToList();
            return _mapper.Map<List<GetVehicleQueryResult>>(values);
        }
    }
}

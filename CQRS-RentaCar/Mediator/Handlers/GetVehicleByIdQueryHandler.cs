using AutoMapper;
using CQRS_RentaCar.DAL;
using CQRS_RentaCar.Mediator.Queries;
using CQRS_RentaCar.Mediator.Results;
using MediatR;

namespace CQRS_RentaCar.Mediator.Handlers
{
    public class GetVehicleByIdQueryHandler : IRequestHandler<GetVehicleByIdQuery,GetVehicleByIdQueryResult>
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public GetVehicleByIdQueryHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public Task<GetVehicleByIdQueryResult> Handle(GetVehicleByIdQuery query, CancellationToken cancellationToken) 
        {
            var values=_carRentalContext.Vehicles.Find(query.Id);
            var result =_mapper.Map<GetVehicleByIdQueryResult>(values);
            return Task.FromResult(result);
        }
    }
}

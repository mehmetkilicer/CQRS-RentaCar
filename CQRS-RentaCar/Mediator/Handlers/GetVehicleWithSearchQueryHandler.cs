using AutoMapper;
using CQRS_RentaCar.DAL;
using CQRS_RentaCar.Mediator.Queries;
using CQRS_RentaCar.Mediator.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_RentaCar.Mediator.Handlers
{
    public class GetVehicleWithSearchQueryHandler : IRequestHandler<GetVehicleWithSearchQuery, List<GetVehicleWithSearchQueryResult>>
    {
   private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public GetVehicleWithSearchQueryHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public Task<List<GetVehicleWithSearchQueryResult>> Handle(GetVehicleWithSearchQuery query, CancellationToken cancellationToken)
        {
            var values = _carRentalContext.Vehicles
                .Include(x => x.BodyStyle)
                .Include(x => x.Brand)
                .Include(x => x.RentalLocation)
                .Where(x => x.BodyStyleId == query.BodyStyle && x.RentalLocationId == query.StartLocation)
                .ToList();
            var result = values.Select(x => new GetVehicleWithSearchQueryResult
            {
                BrandName = x.Brand.BrandName,
                VehicleId = x.VehicleId,
                Model = x.Model,
                IsActive = x.IsActive,
                Mileage = x.Mileage,
                ImageUrl = x.ImageUrl,
                Gearbox = x.Gearbox,
                NumberOfSeats = x.NumberOfSeats,
                FuelType = x.FuelType,
                DailyRate = x.DailyRate,
                Price =x.Price,
                BodyStyle = x.BodyStyle.StyleName,
                RentalLocation = x.RentalLocation.LocationName,
            }).ToList();

            return Task.FromResult(result);
        }
    }
}

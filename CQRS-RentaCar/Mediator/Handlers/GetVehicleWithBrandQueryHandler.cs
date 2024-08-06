using AutoMapper;
using CQRS_RentaCar.DAL;
using CQRS_RentaCar.Mediator.Queries;
using CQRS_RentaCar.Mediator.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_RentaCar.Mediator.Handlers
{
    public class GetVehicleWithBrandQueryHandler : IRequestHandler<GetVehicleWithBrandQuery, List<GetVehicleWithBrandQueryResult>>
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public GetVehicleWithBrandQueryHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }

        public async Task<List<GetVehicleWithBrandQueryResult>> Handle(GetVehicleWithBrandQuery query, CancellationToken cancellationToken)
        {
            var values = await _carRentalContext.Vehicles.Include(x => x.Brand).Include(x => x.BodyStyle).Include(x => x.RentalLocation).ToListAsync();

            return values.Select(x => new GetVehicleWithBrandQueryResult
            {
                BrandName = x.Brand.BrandName,
                VehicleId = x.VehicleId,
                Model = x.Model,
                Mileage =x.Mileage,
                Gearbox = x.Gearbox,
                ImageUrl = x.ImageUrl,
                NumberOfSeats = x.NumberOfSeats,
                FuelType = x.FuelType,
                DailyRate = x.DailyRate,
                IsActive = x.IsActive,
                Price = x.Price,
                BodyStyle = x.BodyStyle.StyleName,
                RentalLocation = x.RentalLocation.LocationName,
            }).ToList();
        }
    }
}

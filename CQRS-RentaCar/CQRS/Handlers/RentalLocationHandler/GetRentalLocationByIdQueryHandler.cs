using AutoMapper;
using CQRS_RentaCar.CQRS.Queries.BrandQueries;
using CQRS_RentaCar.CQRS.Queries.RentalLocationQueries;
using CQRS_RentaCar.CQRS.Results.BrandResults;
using CQRS_RentaCar.CQRS.Results.RentalLocationResult;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.RentalLocationHandler
{
    public class GetRentalLocationByIdQueryHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;

        public GetRentalLocationByIdQueryHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public GetRentalLocationByIdQueryResult Handle(GetRentalLocationByIdQuery query)
        {
            var values = _carRentalContext.RentalLocations.Find(query.Id);
            var result = _mapper.Map<GetRentalLocationByIdQueryResult>(values);
            return result;
        }
    }
}

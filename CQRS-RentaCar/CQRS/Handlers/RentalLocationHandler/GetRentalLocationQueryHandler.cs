using AutoMapper;
using CQRS_RentaCar.CQRS.Results.BrandResults;
using CQRS_RentaCar.CQRS.Results.RentalLocationResult;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.RentalLocationHandler
{
    public class GetRentalLocationQueryHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;

        public GetRentalLocationQueryHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public List<GetRentalLocationQueryResult> Handle()
        {
            var values = _carRentalContext.RentalLocations.ToList();
            var result = _mapper.Map<List<GetRentalLocationQueryResult>>(values);
            return result;
        }
    }
}

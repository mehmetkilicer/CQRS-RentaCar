using AutoMapper;
using CQRS_RentaCar.CQRS.Results.BodyStyleResults;
using CQRS_RentaCar.CQRS.Results.BrandResults;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;

        public GetBrandQueryHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public List<GetBrandQueryResult> Handle()
        {
            var values = _carRentalContext.Brands.ToList();
            var result = _mapper.Map<List<GetBrandQueryResult>>(values);
            return result;
        }


    }
}

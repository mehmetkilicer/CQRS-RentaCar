using AutoMapper;
using CQRS_RentaCar.CQRS.Queries.BodyStyleQueries;
using CQRS_RentaCar.CQRS.Queries.BrandQueries;
using CQRS_RentaCar.CQRS.Results.BodyStyleResults;
using CQRS_RentaCar.CQRS.Results.BrandResults;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;

        public GetBrandByIdQueryHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public GetBrandByIdQueryResult Handle(GetBrandByIdQuery query)
        {
            var values = _carRentalContext.Brands.Find(query.Id);
            var result = _mapper.Map<GetBrandByIdQueryResult>(values);
            return result;
        }
    }
}

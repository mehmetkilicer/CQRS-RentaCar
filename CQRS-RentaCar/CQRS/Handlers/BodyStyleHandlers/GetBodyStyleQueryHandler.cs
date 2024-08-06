using AutoMapper;
using CQRS_RentaCar.CQRS.Results.BodyStyleResults;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.BodyStyleHandlers
{
    public class GetBodyStyleQueryHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public GetBodyStyleQueryHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public List<GetBodyStyleQueryResult> Handle()
        {
            var values = _carRentalContext.BodyStyles.ToList();
            var result = _mapper.Map<List<GetBodyStyleQueryResult>>(values);
            return result;
        }
    }
}

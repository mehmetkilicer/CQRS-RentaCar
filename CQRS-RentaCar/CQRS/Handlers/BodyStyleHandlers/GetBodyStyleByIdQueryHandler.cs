using AutoMapper;
using CQRS_RentaCar.CQRS.Queries.BodyStyleQueries;
using CQRS_RentaCar.CQRS.Results.BodyStyleResults;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.BodyStyleHandlers
{
    public class GetBodyStyleByIdQueryHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;

        public GetBodyStyleByIdQueryHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public GetBodyStyleByIdQueryResult Handle(GetBodyStyleByIdQuery query) 
        {
            var values =_carRentalContext.BodyStyles.Find(query.Id);
            var result =_mapper.Map<GetBodyStyleByIdQueryResult>(values);
            return result;
        }
    }
}

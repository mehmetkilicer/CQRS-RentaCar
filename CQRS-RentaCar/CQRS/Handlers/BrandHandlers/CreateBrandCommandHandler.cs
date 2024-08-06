using AutoMapper;
using CQRS_RentaCar.CQRS.Commands.BodyStyleCommands;
using CQRS_RentaCar.CQRS.Commands.BrandCommands;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public CreateBrandCommandHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public void Handle(CreateBrandCommand command)
        {
            var result = _mapper.Map<Brand>(command);
            _carRentalContext.Brands.Add(result);
            _carRentalContext.SaveChanges();

        }
    }
}

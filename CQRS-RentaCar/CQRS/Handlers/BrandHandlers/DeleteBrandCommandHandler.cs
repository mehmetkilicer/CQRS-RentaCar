using AutoMapper;
using CQRS_RentaCar.CQRS.Commands.BodyStyleCommands;
using CQRS_RentaCar.CQRS.Commands.BrandCommands;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.BrandHandlers
{
    public class DeleteBrandCommandHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public DeleteBrandCommandHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public void Handle(DeleteBrandCommand command)
        {
            var values = _carRentalContext.Brands.Find(command.Id);
            _carRentalContext.Brands.Remove(values);
            _carRentalContext.SaveChanges();
        }
    }
}

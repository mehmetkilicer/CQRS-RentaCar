using AutoMapper;
using CQRS_RentaCar.CQRS.Commands.BrandCommands;
using CQRS_RentaCar.CQRS.Commands.RentalLocationCommands;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.RentalLocationHandler
{
    public class UpdateRentalLocationCommandHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public UpdateRentalLocationCommandHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public void Handle(UpdateRentalLocationCommand command)
        {
            var result = _mapper.Map<RentalLocation>(command);
            _carRentalContext.RentalLocations.Update(result);
            _carRentalContext.SaveChanges();
        }
    }
}

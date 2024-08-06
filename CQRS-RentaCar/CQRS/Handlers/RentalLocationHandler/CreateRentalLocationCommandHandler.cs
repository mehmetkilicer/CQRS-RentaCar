using AutoMapper;
using CQRS_RentaCar.CQRS.Commands.BrandCommands;
using CQRS_RentaCar.CQRS.Commands.RentalLocationCommands;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.RentalLocationHandler
{
    public class CreateRentalLocationCommandHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public CreateRentalLocationCommandHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public void Handle(CreateRentalLocationCommand command)
        {
            var result = _mapper.Map<RentalLocation>(command);
            _carRentalContext.RentalLocations.Add(result);
            _carRentalContext.SaveChanges();

        }
    }
}

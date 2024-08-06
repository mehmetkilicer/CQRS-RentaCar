using AutoMapper;
using CQRS_RentaCar.CQRS.Commands.BodyStyleCommands;
using CQRS_RentaCar.CQRS.Commands.RentalLocationCommands;
using CQRS_RentaCar.DAL;

namespace CQRS_RentaCar.CQRS.Handlers.RentalLocationHandler
{
    public class DeleteRentalLocationCommandHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public DeleteRentalLocationCommandHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public void Handle(DeleteRentalLocationCommand command)
        {
            var values = _carRentalContext.RentalLocations.Find(command.Id);
            _carRentalContext.RentalLocations.Remove(values);
            _carRentalContext.SaveChanges();
        }
    }
}

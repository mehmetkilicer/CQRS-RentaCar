using AutoMapper;
using CQRS_RentaCar.CQRS.Commands.BodyStyleCommands;
using CQRS_RentaCar.DAL;
using Microsoft.EntityFrameworkCore;

namespace CQRS_RentaCar.CQRS.Handlers.BodyStyleHandlers
{
    public class DeleteBodyStyleCommandHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public DeleteBodyStyleCommandHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public void Handle(DeleteBodyStyleCommand command)
        {
            var values = _carRentalContext.BodyStyles.Find(command.Id);
            _carRentalContext.BodyStyles.Remove(values);
            _carRentalContext.SaveChanges();
        }
    }
}

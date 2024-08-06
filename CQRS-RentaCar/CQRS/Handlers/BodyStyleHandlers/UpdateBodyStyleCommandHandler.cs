using AutoMapper;
using CQRS_RentaCar.CQRS.Commands.BodyStyleCommands;
using CQRS_RentaCar.DAL;
using Microsoft.EntityFrameworkCore;

namespace CQRS_RentaCar.CQRS.Handlers.BodyStyleHandlers
{
    public class UpdateBodyStyleCommandHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public UpdateBodyStyleCommandHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public void Handle(UpdateBodyStyleCommand command)
        {
            var result = _mapper.Map<BodyStyle>(command);
            _carRentalContext.BodyStyles.Update(result);
            _carRentalContext.SaveChanges();
        }
    }
}

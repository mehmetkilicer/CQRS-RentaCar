using AutoMapper;
using CQRS_RentaCar.CQRS.Commands.BodyStyleCommands;
using CQRS_RentaCar.DAL;
using Microsoft.EntityFrameworkCore;

namespace CQRS_RentaCar.CQRS.Handlers.BodyStyleHandlers
{
    public class CreateBodyStyleCommandHandler
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public CreateBodyStyleCommandHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public void Handle(CreateBodyStyleCommand command)
        {
            var result = _mapper.Map<BodyStyle>(command);
            _carRentalContext.BodyStyles.Add(result);
            _carRentalContext.SaveChanges();

        }
    }
}

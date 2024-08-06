using AutoMapper;
using CQRS_RentaCar.DAL;
using CQRS_RentaCar.Mediator.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_RentaCar.Mediator.Handlers
{
    public class UpdateVehicleCommandHandler : IRequestHandler<UpdateVehicleCommand>
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public UpdateVehicleCommandHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public Task Handle(UpdateVehicleCommand command, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<Vehicle>(command);

            _carRentalContext.Update(result);
            _carRentalContext.SaveChanges();
            return Task.CompletedTask;
        }

    }
}

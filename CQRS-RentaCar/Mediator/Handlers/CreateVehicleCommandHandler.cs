using AutoMapper;
using CQRS_RentaCar.DAL;
using CQRS_RentaCar.Mediator.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_RentaCar.Mediator.Handlers
{
    public class CreateVehicleCommandHandler : IRequestHandler<CreateVehicleCommand>
    {
        private readonly CarRentalContext _carRentalContext;
        private readonly IMapper _mapper;


        public CreateVehicleCommandHandler(CarRentalContext carRentalContext, IMapper mapper)
        {
            _carRentalContext = carRentalContext;
            _mapper = mapper;
        }
        public Task Handle(CreateVehicleCommand command, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<Vehicle>(command);
            _carRentalContext.Vehicles.Add(result);
            _carRentalContext.SaveChanges();

            return Task.CompletedTask;
        }
    }
}

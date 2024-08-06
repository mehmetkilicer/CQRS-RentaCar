using CQRS_RentaCar.DAL;
using CQRS_RentaCar.Mediator.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_RentaCar.Mediator.Handlers
{
    public class DeleteVehicleCommandHandler : IRequestHandler<DeleteVehicleCommand>
    {
        private readonly CarRentalContext _carRentalContext;

        public DeleteVehicleCommandHandler(CarRentalContext carRentalContext)
        {
            _carRentalContext = carRentalContext;
        }
        public Task Handle(DeleteVehicleCommand command, CancellationToken cancellationToken)
        {
            var values = _carRentalContext.Vehicles.Find(command.Id);

            _carRentalContext.Vehicles.Remove(values);
            _carRentalContext.SaveChanges();

            return Task.CompletedTask;
        }
    }
}

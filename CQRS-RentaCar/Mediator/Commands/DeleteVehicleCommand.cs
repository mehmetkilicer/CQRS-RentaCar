using MediatR;


namespace CQRS_RentaCar.Mediator.Commands


{
    public class DeleteVehicleCommand : IRequest 
    {
        public int Id { get; set; }

        public DeleteVehicleCommand(int id)
        {
            Id = id;
        }
    }
}

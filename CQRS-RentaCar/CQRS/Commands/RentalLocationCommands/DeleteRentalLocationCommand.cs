namespace CQRS_RentaCar.CQRS.Commands.RentalLocationCommands
{
    public class DeleteRentalLocationCommand
    {
        public int Id { get; set; }

        public DeleteRentalLocationCommand(int id)
        {
            Id = id;
        }
    }
}

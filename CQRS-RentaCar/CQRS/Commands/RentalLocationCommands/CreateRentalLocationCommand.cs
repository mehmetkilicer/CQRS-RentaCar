namespace CQRS_RentaCar.CQRS.Commands.RentalLocationCommands
{
    public class CreateRentalLocationCommand
    {
        public string LocationName { get; set; }
        public bool IsActive { get; set; }
    }
}

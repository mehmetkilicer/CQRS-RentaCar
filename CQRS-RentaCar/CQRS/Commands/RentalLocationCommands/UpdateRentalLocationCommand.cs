namespace CQRS_RentaCar.CQRS.Commands.RentalLocationCommands
{
    public class UpdateRentalLocationCommand
    {
        public int RentalLocationId { get; set; }
        public string LocationName { get; set; }
        public bool IsActive { get; set; }
    }
}

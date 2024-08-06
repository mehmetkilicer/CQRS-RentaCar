namespace CQRS_RentaCar.CQRS.Commands.BodyStyleCommands
{
    public class DeleteBodyStyleCommand
    {
        public int Id { get; set; }

        public DeleteBodyStyleCommand(int id)
        {
            Id = id;
        }
    }
}

namespace CQRS_RentaCar.CQRS.Commands.BodyStyleCommands
{
    public class UpdateBodyStyleCommand
    {
        public int BodyStyleId { get; set; }

        public string StyleName { get; set; }

    }
}

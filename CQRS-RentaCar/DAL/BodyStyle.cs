namespace CQRS_RentaCar.DAL
{
    public class BodyStyle
    {
        public int BodyStyleId { get; set; }
        public string StyleName { get; set; }
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}

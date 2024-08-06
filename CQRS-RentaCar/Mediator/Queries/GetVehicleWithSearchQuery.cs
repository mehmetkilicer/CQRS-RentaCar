using CQRS_RentaCar.DAL;
using CQRS_RentaCar.Mediator.Results;
using CQRS_RentaCar.Model;
using MediatR;

namespace CQRS_RentaCar.Mediator.Queries
{
    public class GetVehicleWithSearchQuery : IRequest<List<GetVehicleWithSearchQueryResult>>
    {
        public GetVehicleWithSearchQuery(SearchVehicleModel model)
        {
            BodyStyle = model.BodyStyle;
            StartDate = model.StartDate;
            EndDate = model.EndDate;
            StartLocation = model.StartLocation;
            EndLocation = model.EndLocation;
        }
        public int BodyStyle { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? StartLocation { get; set; }
        public int? EndLocation { get; set; }
    }
}

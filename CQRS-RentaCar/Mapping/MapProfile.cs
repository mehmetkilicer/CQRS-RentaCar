using AutoMapper;
using CQRS_RentaCar.CQRS.Commands.BodyStyleCommands;
using CQRS_RentaCar.CQRS.Commands.BrandCommands;
using CQRS_RentaCar.CQRS.Commands.RentalLocationCommands;
using CQRS_RentaCar.CQRS.Results.BodyStyleResults;
using CQRS_RentaCar.CQRS.Results.BrandResults;
using CQRS_RentaCar.CQRS.Results.RentalLocationResult;
using CQRS_RentaCar.DAL;
using CQRS_RentaCar.Mediator.Commands;
using CQRS_RentaCar.Mediator.Results;

namespace CQRS_RentaCar.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<GetBodyStyleByIdQueryResult,BodyStyle>().ReverseMap();
            CreateMap<GetBodyStyleQueryResult,BodyStyle>().ReverseMap();
            CreateMap<CreateBodyStyleCommand, BodyStyle>().ReverseMap();
            CreateMap<UpdateBodyStyleCommand, BodyStyle>().ReverseMap();

            CreateMap<GetRentalLocationQueryResult, RentalLocation>().ReverseMap();
            CreateMap<GetRentalLocationByIdQueryResult, RentalLocation>().ReverseMap();
            CreateMap<CreateRentalLocationCommand, RentalLocation>().ReverseMap();
            CreateMap<UpdateRentalLocationCommand, RentalLocation>().ReverseMap();

            CreateMap<Vehicle, GetVehicleQueryResult>().ReverseMap();
            CreateMap<Vehicle, GetVehicleByIdQueryResult>().ReverseMap();
            CreateMap<CreateVehicleCommand, Vehicle>().ReverseMap();
            CreateMap<UpdateVehicleCommand, Vehicle>().ReverseMap();
            CreateMap<GetVehicleWithBrandQueryResult, Vehicle>().ReverseMap();

            CreateMap<GetBrandQueryResult, Brand>().ReverseMap();
            CreateMap<GetBrandByIdQueryResult, Brand>().ReverseMap();
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<UpdateBrandCommand, Brand>().ReverseMap();

        }
    }
}

using AutoMapper;
using CQRS_RentaCar.CQRS.Handlers.BodyStyleHandlers;
using CQRS_RentaCar.CQRS.Handlers.RentalLocationHandler;
using CQRS_RentaCar.CQRS.Queries.RentalLocationQueries;
using CQRS_RentaCar.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;



namespace CQRS_RentaCar.ViewComponents
{
    public class _CarFilterComponentPartial : ViewComponent
    {
        private readonly GetRentalLocationQueryHandler _getRentalLocationQueryHandler;
        private readonly GetBodyStyleQueryHandler _getBodyStyleQueryHandler;
        private readonly IMapper _mapper;

        public _CarFilterComponentPartial(GetBodyStyleQueryHandler getBodyStyleQueryHandler, IMapper mapper, GetRentalLocationQueryHandler getRentalLocationQueryHandler)
        {
            _getBodyStyleQueryHandler = getBodyStyleQueryHandler;
            _mapper = mapper;
            _getRentalLocationQueryHandler = getRentalLocationQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var valuesLocation = _getRentalLocationQueryHandler.Handle();
            var resultLocation = _mapper.Map<List<RentalLocation>>(valuesLocation);

            var valuesBodyStyle = _getBodyStyleQueryHandler.Handle();
            var resultBodyStyle = _mapper.Map<List<BodyStyle>>(valuesBodyStyle);

            ViewBag.RentalLocations = resultLocation ?? new List<RentalLocation>();
            ViewBag.BodyStyles = resultBodyStyle ?? new List<BodyStyle>();

            return View();
        }
    }
}


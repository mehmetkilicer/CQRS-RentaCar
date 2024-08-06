using CQRS_RentaCar.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_RentaCar.ViewComponents
{
   
    public class _CarlistComponentPartial : ViewComponent
    {
        private readonly IMediator _mediator;

        public _CarlistComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _mediator.Send(new GetVehicleWithBrandQuery());
            return View(values);
        }
    }
}

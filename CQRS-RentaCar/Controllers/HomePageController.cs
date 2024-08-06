using CQRS_RentaCar.CQRS.Handlers.RentalLocationHandler;
using CQRS_RentaCar.CQRS.Queries.RentalLocationQueries;
using CQRS_RentaCar.Mediator.Handlers;
using CQRS_RentaCar.Mediator.Queries;
using CQRS_RentaCar.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CQRS_RentaCar.Controllers
{
    public class HomePageController : Controller
    {
        private readonly IMediator _mediator;
        private readonly GetRentalLocationByIdQueryHandler _getRentalLocationByIdQueryHandler;

        public HomePageController(IMediator mediator, GetRentalLocationByIdQueryHandler getRentalLocationByIdQueryHandler)
        {
            _mediator = mediator;
            _getRentalLocationByIdQueryHandler = getRentalLocationByIdQueryHandler;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarList()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchCar(SearchVehicleModel model)
        {
            // Tarih formatını belirleyin
            string dateFormat = "MM/dd/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            // Tarihleri parse edin
            DateTime startDate = DateTime.ParseExact(model.StartDate, dateFormat, provider);
            DateTime endDate = DateTime.ParseExact(model.EndDate, dateFormat, provider);

            // Tarihler arasındaki farkı hesaplayın
            TimeSpan fark = endDate - startDate;

            // Farkın gün cinsinden değerini al
            int gunSayisi = fark.Days;

            // ViewBag.days'e gün sayısını ata
            ViewBag.days = gunSayisi;

            if (model.StartLocation.HasValue && model.EndLocation.HasValue)
            {
                var pLocation = _getRentalLocationByIdQueryHandler.Handle(new GetRentalLocationByIdQuery(model.StartLocation.Value));
                var dLocation = _getRentalLocationByIdQueryHandler.Handle(new GetRentalLocationByIdQuery(model.EndLocation.Value));
                ViewBag.pickUpLocation = pLocation.LocationName;
                ViewBag.dropOffLocation = dLocation.LocationName;
            }
            else
            {
                // Hata durumunu işle
                ModelState.AddModelError(string.Empty, "StartLocation ve EndLocation null olamaz.");
                return View();
            }

            var values = await _mediator.Send(new GetVehicleWithSearchQuery(model));
            return View(values);
        }

        //[HttpPost]
        //public async Task<IActionResult> SearchCar(SearchVehicleModel model)
        //{
        //    // Tarih formatını belirleyin
        //    const string dateFormat = "MM/dd/yyyy";
        //    CultureInfo provider = CultureInfo.InvariantCulture;

        //    // Tarihleri parse etmeye çalışın ve hata durumunu işleyin
        //    if (!DateTime.TryParseExact(model.StartDate, dateFormat, provider, DateTimeStyles.None, out DateTime startDate) ||
        //        !DateTime.TryParseExact(model.EndDate, dateFormat, provider, DateTimeStyles.None, out DateTime endDate))
        //    {
        //        ModelState.AddModelError(string.Empty, "Geçersiz tarih formatı.");
        //        return View();
        //    }

        //    // Tarihler arasındaki farkı hesaplayın
        //    int gunSayisi = (endDate - startDate).Days;
        //    ViewBag.days = gunSayisi;

        //    // StartLocation ve EndLocation kontrolleri
        //    if (!model.StartLocation.HasValue || !model.EndLocation.HasValue)
        //    {
        //        ModelState.AddModelError(string.Empty, "StartLocation ve EndLocation null olamaz.");
        //        return View();
        //    }

        //    try
        //    {
        //        // Senkron olarak kiralama lokasyonlarını alın
        //        var pLocation = _getRentalLocationByIdQueryHandler.Handle(new GetRentalLocationByIdQuery(model.StartLocation.Value));
        //        var dLocation = _getRentalLocationByIdQueryHandler.Handle(new GetRentalLocationByIdQuery(model.EndLocation.Value));

        //        if (pLocation == null || dLocation == null)
        //        {
        //            ModelState.AddModelError(string.Empty, "Geçersiz lokasyon bilgisi.");
        //            return View();
        //        }

        //        ViewBag.pickUpLocation = pLocation.LocationName;
        //        ViewBag.dropOffLocation = dLocation.LocationName;

        //        // Araç arama işlemini gerçekleştirin
        //        var values = await _mediator.Send(new GetVehicleWithSearchQuery(model));
        //        return View(values);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Hata durumunu işle
        //        ModelState.AddModelError(string.Empty, $"Bir hata oluştu: {ex.Message}");
        //        return View();
        //    }
        //}

    }
}

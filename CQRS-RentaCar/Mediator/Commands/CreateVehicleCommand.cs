﻿using MediatR;

namespace CQRS_RentaCar.Mediator.Commands
{
    public class CreateVehicleCommand : IRequest
    {
        public string Model { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int Mileage { get; set; }
        public string Gearbox { get; set; }
        public decimal Price { get; set; }
        public int NumberOfSeats { get; set; }
        public string FuelType { get; set; }
        public decimal DailyRate { get; set; }
        public int BrandId { get; set; }
        public int RentalLocationId { get; set; }
        public int BodyStyleId { get; set; }
    }
}
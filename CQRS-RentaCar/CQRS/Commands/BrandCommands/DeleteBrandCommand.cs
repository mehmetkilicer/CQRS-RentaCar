﻿namespace CQRS_RentaCar.CQRS.Commands.BrandCommands
{
    public class DeleteBrandCommand
    {
        public int Id { get; set; }

        public DeleteBrandCommand(int id)
        {
            Id = id;
        }
    }
}

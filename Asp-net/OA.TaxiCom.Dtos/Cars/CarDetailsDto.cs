﻿using OA.TaxiCom.Dto.Bookings;
using OA.TaxiCom.Utils.Enums;

namespace OA.TaxiCom.Dto.Cars
{
    public class CarDetailsDto
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public string Model { get; set; }
        public int ModelDate { get; set; }
        public PowerType PowerType { get; set; }

        public string DriverFullName { get; set; }

        public List<BookingDto> Bookings { get; set; } = [];
    }
}

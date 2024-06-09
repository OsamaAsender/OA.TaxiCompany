using OA.TaxiCom.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.TaxiCom.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public required string PlateNumber { get; set; }
        public required string Model { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PowerType PowerType { get; set; }

        public int? DriverId { get; set; }
        public Driver? Driver { get; set; }


        public List<Booking> Bookings { get; set; } = [];


        public int ModelDate
        {
            get
            {
                return ManufactureDate.Year;
            }
        }

        public string Description
        {
            get
            {
                return $"{Model} - {PlateNumber}";
            }
        }
    }
}

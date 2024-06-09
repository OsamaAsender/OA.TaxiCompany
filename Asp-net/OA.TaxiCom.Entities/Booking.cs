using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.TaxiCom.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public required string FromAddress { get; set; }
        public required string ToAddress { get; set; }
        public DateTime PickUpTime { get; set; }


        [Column(TypeName = "decimal(4,2)")]
        public decimal Price { get; set; }

        public List<Passenger> Passengers { get; set; } = [];

        public int? CarId { get; set; }
        public Car? Car { get; set; }


        public int? DriverId { get; set; }
        public Driver? Driver { get; set; }
    }
}

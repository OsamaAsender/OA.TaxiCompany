using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.TaxiCom.Dto.Bookings
{
    public class CreateUpdateBookingDto
    {
        public int Id { get; set; }
        public required string FromAddress { get; set; }
        public required string ToAddress { get; set; }
        public DateTime PickUpTime { get; set; }



        public List<int> PassengerIds { get; set; } = [];
        public int? CarId { get; set; }
        public int? DriverId { get; set; }
    }
}

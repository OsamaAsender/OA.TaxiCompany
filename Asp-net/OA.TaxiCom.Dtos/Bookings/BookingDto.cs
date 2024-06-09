using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.TaxiCom.Dto.Bookings
{
    public class BookingDto
    {
        public int Id { get; set; }
        public required string FromAddress { get; set; }
        public required string ToAddress { get; set; }
        public DateTime PickUpTime { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal Price { get; set; }
        public string DriverFullName { get; set; }
        public string DriverPhoneNumber { get; set; }
        public string DriverRating { get; set; }
        public string CarPlateNumber { get; set; }
    }
}

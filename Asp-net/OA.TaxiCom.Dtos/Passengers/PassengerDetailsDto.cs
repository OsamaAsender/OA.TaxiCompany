using OA.TaxiCom.Dto.Bookings;
using OA.TaxiCom.Utils.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.TaxiCom.Dto.Passengers
{
    public class PassengerDetailsDto
    {
        public int Id { get; set; }
        public required string PhoneNumber { get; set; }

        public required string FullName { get; set; }
        public int? Age { get; set; }

        public List<BookingDto> Bookings { get; set; } = [];

        [Column(TypeName = "decimal(4,2)")]
        public decimal TotalSpent { get; set; }

        public Gender Gender { get; set; }
    }
}

using OA.TaxiCom.Dto.Passengers;
using System.ComponentModel.DataAnnotations.Schema;

namespace OA.TaxiCom.Dto.Bookings
{
    public class BookingDetailsDto
    {
        public int Id { get; set; }
        public required string FromAddress { get; set; }
        public required string ToAddress { get; set; }
        public DateTime PickUpTime { get; set; }


        [Column(TypeName = "decimal(4,2)")]
        public decimal Price { get; set; }


        public List<PassengerDto> Passengers { get; set; }
        public string DriverFullName { get; set; }
        public string CarPlateNumber { get; set; }
    }
}

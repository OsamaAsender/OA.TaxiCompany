using OA.TaxiCom.Utils.Enums;

namespace OA.TaxiCom.Dto.Passengers
{
    public class PassengerDto
    {
        public int Id { get; set; }
        public required string PhoneNumber { get; set; }

        public required string FullName { get; set; }
        public int? Age { get; set; }

        public Gender Gender { get; set; }
    }
}

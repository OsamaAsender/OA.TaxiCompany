using OA.TaxiCom.Utils.Enums;

namespace OA.TaxiCom.Dto.Drivers
{
    public class DriverDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public int Rating { get; set; }
    }
}

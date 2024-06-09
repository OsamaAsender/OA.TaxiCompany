using OA.TaxiCom.Utils.Enums;

namespace OA.TaxiCom.Dto.Cars
{
    public class CreateUpdateCarDto
    {
        public int Id { get; set; }
        public required string PlateNumber { get; set; }
        public required string Model { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PowerType PowerType { get; set; }
    }
}

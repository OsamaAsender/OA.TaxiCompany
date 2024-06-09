using OA.TaxiCom.Dto.Cars;
using OA.TaxiCom.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.TaxiCom.Dto.Drivers
{
    public class DriverDetailsDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public int Rating { get; set; }

        public List<CarDto> Cars { get; set; } = [];
    }
}

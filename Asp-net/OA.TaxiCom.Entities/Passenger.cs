using OA.TaxiCom.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OA.TaxiCom.Entities
{
    public class Passenger
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public required string PhoneNumber { get; set; }

        public Gender Gender { get; set; }


        public List<Booking> Bookings { get; set; } = [];

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public int? Age
        {
            get
            {
                if (DateOfBirth.HasValue)
                {
                    return DateTime.Now.Year - DateOfBirth.Value.Year;
                }
                else
                {
                    return null;
                }


                // Some times some developers do trinary operator
                //return DateOfBirth.HasValue ? DateTime.Now.Year - DateOfBirth.Value.Year : null;
            }
        }
    }
}

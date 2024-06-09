using OA.TaxiCom.Dto.Bookings;
using OA.TaxiCom.Entities;
using AutoMapper;
namespace OA.TaxiCom.WebApi.AutoMapperProfile
{
    public class BookingAutoMapperProfile : Profile
    { 
        public BookingAutoMapperProfile() {
            CreateMap<Booking, BookingDto>();
            CreateMap<Booking, BookingDetailsDto>();
            CreateMap<CreateUpdateBookingDto, Booking>();
        }
    }
}

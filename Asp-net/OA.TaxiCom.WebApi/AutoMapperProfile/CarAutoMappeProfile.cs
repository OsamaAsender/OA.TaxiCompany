using AutoMapper;
using OA.TaxiCom.Dto.Bookings;
using OA.TaxiCom.Dto.Cars;
using OA.TaxiCom.Entities;

namespace OA.TaxiCom.WebApi.AutoMapperProfile
{
    public class CarAutoMappeProfile : Profile
    {
        public CarAutoMappeProfile() {
            CreateMap<Car, CarDto>();
            CreateMap<Car, CarDetailsDto>();
            CreateMap<CreateUpdateCarDto,Car>().ReverseMap();
        }
    }
}

using OA.TaxiCom.Dto.Drivers;
using OA.TaxiCom.Entities;
using AutoMapper;
namespace OA.TaxiCom.WebApi.AutoMapperProfile
{
    public class DriverAutoMapperProfile : Profile
    {
        public DriverAutoMapperProfile() {
            CreateMap<Driver, DriverDto>();
            CreateMap<Driver, DriverDetailsDto>();
            CreateMap<Driver, CreateUpdateDriverDto>().ReverseMap();
        }
    }
}

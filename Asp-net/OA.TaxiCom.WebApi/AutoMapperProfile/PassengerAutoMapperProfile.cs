using AutoMapper;
using OA.TaxiCom.Dto.Passengers;
using OA.TaxiCom.Entities;

namespace OA.TaxiCom.WebApi.AutoMapperProfile
{
    public class PassengerAutoMapperProfile : Profile
    {
        public PassengerAutoMapperProfile() {
            CreateMap<Passenger, PassengerDto>();
            CreateMap<Passenger, PassengerDetailsDto>();
            CreateMap<CreateUpdatePassengerDto, Passenger>().ReverseMap();
        }
    }
}

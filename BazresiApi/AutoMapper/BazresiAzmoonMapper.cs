using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class BazresiAzmoonMapper : Profile
    {
        public BazresiAzmoonMapper()
        {
            CreateMap<T_Bazresi_Azmon,BazresiAzmonDto>();
            CreateMap<BazresiAzmonDto, T_Bazresi_Azmon>();
        }
    }
}

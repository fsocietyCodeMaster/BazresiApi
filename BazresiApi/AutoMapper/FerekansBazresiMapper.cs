using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class FerekansBazresiMapper : Profile
    {
        public FerekansBazresiMapper()
        {
            CreateMap<T_L_Ferekans_Bazresi,FerekansBazresiDto>();
            CreateMap<FerekansBazresiDto, T_L_Ferekans_Bazresi>();
        }
    }
}

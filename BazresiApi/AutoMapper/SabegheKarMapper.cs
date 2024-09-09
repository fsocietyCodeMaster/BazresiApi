using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class SabegheKarMapper : Profile
    {
        public SabegheKarMapper()
        {
            CreateMap<T_L_SabegheKar, SabegheKarDto>();
            CreateMap<SabegheKarDto, T_L_SabegheKar>();
        }
    }
}

using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class VahedMapper : Profile
    {
        public VahedMapper()
        {
            CreateMap<T_L_Vahed,VahedDto>();
            CreateMap<VahedDto, T_L_Vahed>();
        }
    }
}

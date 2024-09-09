using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class BazresVahedMapper : Profile
    {
        public BazresVahedMapper()
        {
            CreateMap<T_Bazres_Vahed,BazresiVahedDto>();
            CreateMap<BazresiVahedDto, T_Bazres_Vahed>();
        }
    }
}

using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class BazresMapper : Profile
    {
        public BazresMapper()
        {
            CreateMap<T_Bazres,BazresiDto>();
            CreateMap<BazresiDto, T_Bazres>();
        }
    }
}

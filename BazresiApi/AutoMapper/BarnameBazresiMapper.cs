using AutoMapper;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class BarnameBazresiMapper : Profile
    {
        public BarnameBazresiMapper()
        {
            CreateMap<T_Barname_Bazresi,BarnameBazresiDto>();
            CreateMap<BarnameBazresiDto, T_Barname_Bazresi>();
        }
    }
}

using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class RaveshBazresiMapper : Profile
    {
        public RaveshBazresiMapper()
        {
            CreateMap<T_L_Ravesh_Bazresi,RavesheBazresiDto>();
            CreateMap<RavesheBazresiDto, T_L_Ravesh_Bazresi>();
        }
    }
}

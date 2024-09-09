using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class RavsheItemBazresiMapper : Profile
    {
        public RavsheItemBazresiMapper()
        {
            CreateMap<T_Ravesh_Item_Bazresi,RaveshItemBazresiDto>();
            CreateMap<RaveshItemBazresiDto, T_Ravesh_Item_Bazresi>();

        }
    }
}

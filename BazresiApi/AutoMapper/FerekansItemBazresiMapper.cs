using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class FerekansItemBazresiMapper : Profile
    {
        public FerekansItemBazresiMapper()
        {
            CreateMap<T_Ferekans_Item_Bazresi,FerekansItemBazresiDto>();
            CreateMap<FerekansItemBazresiDto, T_Ferekans_Item_Bazresi>();
        }
    }
}

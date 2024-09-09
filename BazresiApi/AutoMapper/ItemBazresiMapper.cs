using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class ItemBazresiMapper : Profile
    {
        public ItemBazresiMapper()
        {
            CreateMap<T_Item_Bazresi,ItemBazresiDto>();
            CreateMap<ItemBazresiDto, T_Item_Bazresi>();
        }
    }
}

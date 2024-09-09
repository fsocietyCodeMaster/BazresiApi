using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class ZirClassItemMapper : Profile
    {
        public ZirClassItemMapper()
        {
            CreateMap<T_L_Zir_Class_Item,ZirClassItemDto>();
            CreateMap<ZirClassItemDto, T_L_Zir_Class_Item>();
        }
    }
}

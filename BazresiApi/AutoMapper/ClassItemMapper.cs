using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class ClassItemMapper : Profile
    {
        public ClassItemMapper()
        {
            CreateMap<T_L_Class_Item,ClassItemDto>();
            CreateMap<ClassItemDto, T_L_Class_Item>();
        }
    }
}

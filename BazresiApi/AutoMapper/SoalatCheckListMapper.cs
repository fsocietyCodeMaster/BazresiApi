using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class SoalatCheckListMapper : Profile
    {
        public SoalatCheckListMapper()
        {
            CreateMap<T_Soalat_CheckList,SoalatCheckListDto>();
            CreateMap<SoalatCheckListDto, T_Soalat_CheckList>();
        }
    }
}

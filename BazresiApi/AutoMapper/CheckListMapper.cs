using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class CheckListMapper : Profile
    {
        public CheckListMapper()
        {
            CreateMap<T_CheckList,CheckListDto>();
            CreateMap<CheckListDto, T_CheckList>();
        }
    }
}

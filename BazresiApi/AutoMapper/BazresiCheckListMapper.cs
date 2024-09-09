using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class BazresiCheckListMapper : Profile
    {
        public BazresiCheckListMapper()
        {
            CreateMap<T_Bazresi_CheckList_OK,BazresiCheckListOkDto>();
            CreateMap<BazresiCheckListOkDto, T_Bazresi_CheckList_OK>();
        }
    }
}

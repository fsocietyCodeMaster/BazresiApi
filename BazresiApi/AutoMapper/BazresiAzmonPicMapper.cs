using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class BazresiAzmonPicMapper : Profile
    {
        public BazresiAzmonPicMapper()
        {
            CreateMap<T_Bazresi_Azmon_Pic,BazresiAzmonPicDto>();
            CreateMap<BazresiAzmonPicDto, T_Bazresi_Azmon_Pic>();
        }
    }
}

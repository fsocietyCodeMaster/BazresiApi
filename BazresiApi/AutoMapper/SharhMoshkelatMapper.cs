using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class SharhMoshkelatMapper : Profile
    {
        public SharhMoshkelatMapper()
        {
            CreateMap<T_L_Sharh_Moshkelat, SharhMoshkelatDto>();
            CreateMap<SharhMoshkelatDto, T_L_Sharh_Moshkelat>();
        }
    }
}

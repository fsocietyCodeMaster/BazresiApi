using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class SharhMoshkelatBazresiMapper : Profile
    {
        public SharhMoshkelatBazresiMapper()
        {
            CreateMap<T_Sharh_Moshkelat_Bazresi,SharhMoshkelatBazresiDto>();
            CreateMap<SharhMoshkelatBazresiDto, T_Sharh_Moshkelat_Bazresi>();
        }
    }
}

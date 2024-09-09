using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class VaziatEjraMapper : Profile
    {
        public VaziatEjraMapper()
        {
            CreateMap<T_L_Vaziat_Ejra,VaziatEjraDto>();
            CreateMap<VaziatEjraDto, T_L_Vaziat_Ejra>();
        }
    }
}

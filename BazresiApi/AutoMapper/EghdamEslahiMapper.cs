using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class EghdamEslahiMapper : Profile
    {
        public EghdamEslahiMapper()
        {
            CreateMap<T_Eghdam_Eslahi,EghdamEslahiDto>();
            CreateMap<EghdamEslahiDto, T_Eghdam_Eslahi>();
        }
    }
}

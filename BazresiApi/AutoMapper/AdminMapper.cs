using AutoMapper;
using BazresiApi.DTO;
using BazresiApi.Models;

namespace BazresiApi.AutoMapper
{
    public class AdminMapper : Profile
    {
        public AdminMapper()
        {
            CreateMap<T_AdminApp,AdminAppDto>();
            CreateMap<AdminAppDto, T_AdminApp>();
;        }
    }
}

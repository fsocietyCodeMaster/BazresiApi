using BazresiApi.DTO;
using BazresiApi.Models;
using BazresiApi.Repository;
using BazresiApi.Services;

namespace BazresiApi.Extention
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IGenericRepository<AdminAppDto>, AdminService>();
            services.AddScoped<IGenericRepository<BarnameBazresiDto>, BarnameBazresiService>();
            services.AddScoped<IGenericRepository<BazresiDto>, BazresiService>();
            services.AddScoped<IGenericRepository<BazresiVahedDto>, BazresVahedService>();
            services.AddScoped<IGenericRepository<BazresiAzmonDto>, BazresAzmonService>();
            services.AddScoped<IGenericRepository<BazresiAzmonPicDto>, BazresAzmonPicService>();
            services.AddScoped<IGenericRepository<BazresiCheckListOkDto>, BazresiCheckOkService>();
            services.AddScoped<IGenericRepository<CheckListDto>, CheckListService>();
            services.AddScoped<IGenericRepository<EghdamEslahiDto>, EghdamEslahiService>();
            services.AddScoped<IGenericRepository<FerekansItemBazresiDto>, FerekansItemBazresiService>();
            services.AddScoped<IGenericRepository<ItemBazresiDto>, ItemBazresiService>();
            services.AddScoped<IGenericRepository<ClassItemDto>, ClassItemService>();
            services.AddScoped<IGenericRepository<FerekansBazresiDto>, FerekansBazresiService>();
            services.AddScoped<IGenericRepository<RavesheBazresiDto>, RaveshBazresiService>();
            services.AddScoped<IGenericRepository<SabegheKarDto>, SabegheKarService>();
            services.AddScoped<IGenericRepository<SharhMoshkelatDto>, SharhMoshkelatService>();
            services.AddScoped<IGenericRepository<VahedDto>, VahedService>();
            services.AddScoped<IGenericRepository<VaziatEjraDto>, VaziatService>();
            services.AddScoped<IGenericRepository<ZirClassItemDto>, ZirClassItemService>();
            services.AddScoped<IGenericRepository<RaveshItemBazresiDto>, RaveshItemBazresiService>();
            services.AddScoped<IGenericRepository<SharhMoshkelatBazresiDto>, SharhMoshkelatBazresiService>();
            services.AddScoped<IGenericRepository<SoalatCheckListDto>, SoalatCheckListService>();
            services.AddScoped<IUser, UserService>();

            return services;
        }
    }
}

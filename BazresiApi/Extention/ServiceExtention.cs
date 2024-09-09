using BazresiApi.Repository;
using BazresiApi.Services;

namespace BazresiApi.Extention
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IAdmin, AdminService>();
            services.AddScoped<IBarnameBazresi, BarnameBazresiService>();
            services.AddScoped<IBazres, BazresService>();
            services.AddScoped<IBazresVahed, BazresVahedService>();
            services.AddScoped<IBazresAzmon, BazresAzmonService>();
            services.AddScoped<IBazresAzmonPic, BazresAzmonPicService>();
            services.AddScoped<IBazresiCheckListOk, BazresiCheckOkService>();
            services.AddScoped<ICheckList, CheckListService>();
            services.AddScoped<IEghdamEslahi, EghdamEslahiService>();
            services.AddScoped<IFerekansItemBazresi, FerekansItemBazresiService>();
            services.AddScoped<IItemBazresi, ItemBazresiService>();
            services.AddScoped<IClassItem, ClassItemService>();
            services.AddScoped<IFerekansBazresi, FerekansBazresiService>();
            services.AddScoped<IRaveshBazresi, RaveshBazresiService>();
            services.AddScoped<ISabegheKar, SabegheKarService>();
            services.AddScoped<ISharhMoshkelat, SharhMoshkelatService>();
            services.AddScoped<IVahed, VahedService>();
            services.AddScoped<IVaziat, VaziatService>();
            services.AddScoped<IZirClassItem, ZirClassItemService>();
            services.AddScoped<IRaveshItemBazresi, RaveshItemBazresiService>();
            services.AddScoped<ISharhMoshkelatBazresi, SharhMoshkelatBazresiService>();
            services.AddScoped<ISoalatCheckList, SoalatCheckListService>();

            return services;
        }
    }
}

using BazresiApi.Models;
using BazresiApi.Repository;
using BazresiApi.Services;

namespace BazresiApi.Extention
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IGenericRepository<T_AdminApp>, AdminService>();
            services.AddScoped<IGenericRepository<T_Barname_Bazresi>, BarnameBazresiService>();
            services.AddScoped<IGenericRepository<T_Bazres>, BazresService>();
            services.AddScoped<IGenericRepository<T_Bazres_Vahed>, BazresVahedService>();
            services.AddScoped<IGenericRepository<T_Bazresi_Azmon>, BazresAzmonService>();
            services.AddScoped<IGenericRepository<T_Bazresi_Azmon_Pic>, BazresAzmonPicService>();
            services.AddScoped<IGenericRepository<T_Bazresi_CheckList_OK>, BazresiCheckOkService>();
            services.AddScoped<IGenericRepository<T_CheckList>, CheckListService>();
            services.AddScoped<IGenericRepository<T_Eghdam_Eslahi>, EghdamEslahiService>();
            services.AddScoped<IGenericRepository<T_Ferekans_Item_Bazresi>, FerekansItemBazresiService>();
            services.AddScoped<IGenericRepository<T_Item_Bazresi>, ItemBazresiService>();
            services.AddScoped<IGenericRepository<T_L_Class_Item>, ClassItemService>();
            services.AddScoped<IGenericRepository<T_L_Ferekans_Bazresi>, FerekansBazresiService>();
            services.AddScoped<IGenericRepository<T_L_Ravesh_Bazresi>, RaveshBazresiService>();
            services.AddScoped<IGenericRepository<T_L_SabegheKar>, SabegheKarService>();
            services.AddScoped<IGenericRepository<T_L_Sharh_Moshkelat>, SharhMoshkelatService>();
            services.AddScoped<IGenericRepository<T_L_Vahed>, VahedService>();
            services.AddScoped<IGenericRepository<T_L_Vaziat_Ejra>, VaziatService>();
            services.AddScoped<IGenericRepository<T_L_Zir_Class_Item>, ZirClassItemService>();
            services.AddScoped<IGenericRepository<T_Ravesh_Item_Bazresi>, RaveshItemBazresiService>();
            services.AddScoped<IGenericRepository<T_Sharh_Moshkelat_Bazresi>, SharhMoshkelatBazresiService>();
            services.AddScoped<IGenericRepository<T_Soalat_CheckList>, SoalatCheckListService>();
            services.AddScoped<IUser, UserService>();

            return services;
        }
    }
}

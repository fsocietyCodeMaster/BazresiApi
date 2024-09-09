using BazresiApi.Customized;
using BazresiApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BazresiApi.Context
{
    public class BazresiDb : IdentityDbContext<CustomUser>
    {
        public BazresiDb(DbContextOptions options) : base(options)
        {
        }

        public DbSet<T_AdminApp> admin {  get; set; }
        public DbSet<T_Barname_Bazresi> BarnameBazresi { get; set; }
        public DbSet<T_Bazres> Bazres { get; set; }
        public DbSet<T_Bazres_Vahed> BazresVahed { get; set; }
        public DbSet<T_Bazresi_Azmon> BazresiAzmon { get; set; }
        public DbSet<T_Bazresi_Azmon_Pic> BazresiAzmonPic { get; set; }
        public DbSet<T_Bazresi_CheckList_OK> BazresiCheckList { get; set; }
        public DbSet<T_CheckList> CheckList { get; set; }
        public DbSet<T_Eghdam_Eslahi> EghdamEslahi { get; set; }
        public DbSet<T_Ferekans_Item_Bazresi> FerekansItem { get; set; }
        public DbSet<T_Item_Bazresi> ItemBazresi { get; set; }
        public DbSet<T_L_Class_Item> ClassItem { get; set; }
        public DbSet<T_L_Ferekans_Bazresi> FerekansBazresi { get; set; }
        public DbSet<T_L_Ravesh_Bazresi> RaveshBazresi { get; set; }
        public DbSet<T_L_SabegheKar> SabegheKar { get; set; }
        public DbSet<T_L_Sharh_Moshkelat> SharhMoshkelat { get; set; }
        public DbSet<T_L_Vahed> Vahed { get; set; }
        public DbSet<T_L_Vaziat_Ejra> VaziatEjra { get; set; }
        public DbSet<T_L_Zir_Class_Item> ZirClassItem { get; set; }
        public DbSet<T_Ravesh_Item_Bazresi> RaveshItemBazresi { get; set; }
        public DbSet<T_Sharh_Moshkelat_Bazresi> SharhMoshkelatBazresi { get; set; }
        public DbSet<T_Soalat_CheckList> SoalatCheckList { get; set; }
    }
}

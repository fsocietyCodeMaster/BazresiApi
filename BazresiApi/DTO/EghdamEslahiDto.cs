using System.ComponentModel.DataAnnotations;

namespace BazresiApi.DTO
{
    public class EghdamEslahiDto
    {

        public int? T_L_Vahed_Id { get; set; }

        public int? T_L_Class_Item_Id { get; set; }

        public int? T_L_Zir_Class_Item_Id { get; set; }

        public int? T_Item_Bazresi_Id { get; set; }

        public int? Code_Eghdam_Eslahi { get; set; }

        public int? T_Sharh_Moshkelat_Bazresi_Id { get; set; }

        public int? T_Bazresi_Azmon_Id { get; set; }

        [StringLength(500)]
        public string Onvan_Eghdam_Eslahi { get; set; }

        public string Sharh_Eghdam_Eslahi { get; set; }

        public string Masol_Ejra { get; set; }

        public int? Zaman_Aghaz { get; set; }

        public int? Zaman_Payan { get; set; }

        public string Route_Voice { get; set; }

        public int? T_L_Vaziat_Ejra_Id { get; set; }

        [StringLength(50)]
        public string Vaziat_Ejra_Text { get; set; }

        public int? Is_Active { get; set; }

        public int? Is_Temp { get; set; }

        [StringLength(50)]
        public string DateCreate { get; set; }

        public long? T_AdminsBackups_ID { get; set; }

        public int? ID_Eghdam_EslahiApp { get; set; }
    }
}
